using DataLayer.Model;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitOfWork;

namespace Lens_Management.Forms
{
    public partial class FormSections : Form
    {
        private UnitOfWorkDB _db;
        private List<Section> _sections;
        private bool _IsAnyThingEdited = default(bool);
        public FormSections()
        {
            InitializeComponent();
            RefreshSections();
        }
        private void RefreshSections()
        {
            _db = new UnitOfWorkDB();
            _sections = _db.SectionRepository.Get().ToList();
            string[] items = _sections.Select(s => s.Title).ToArray();
            listBoxSections.Items.Clear();
            listBoxSections.Items.AddRange(items);
        }

        private void AddOrEdit(int Id = 0)
        {
            if (new FormAddOrEditSection(Id).ShowDialog() == DialogResult.OK)
            {
                _IsAnyThingEdited = Id != 0 ? true : false;
                RefreshSections();
            }
        }
        private void toolStripButtonAddNewSection_Click(object sender, EventArgs e)
        {
            AddOrEdit();
        }

        private void toolStripButtonEditSection_Click(object sender, EventArgs e)
        {
            if (listBoxSections.SelectedIndex != -1)
                AddOrEdit(_sections[listBoxSections.SelectedIndex].ID);
            else
                CrownMessageBox.ShowError("لطفا یک مورد را انتخاب نمایید ", "موردی انتخاب نشده ");
        }

        private void toolStripButtonRemoveSection_Click(object sender, EventArgs e)
        {
            if (listBoxSections.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show(" با اینکار همه عدسی های این گروه نیز حذف میشوند ایا از حذف این مورد اطمینان دارید ؟", "تایید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int Id = _sections[listBoxSections.SelectedIndex].ID;
                    foreach (Lens lens in _db.LensRepository.Get(l => l.SectionID == Id).ToList())
                    {
                        _db.LensRepository.Delete(lens);
                    }

                    _db.SectionRepository.DeleteByPrimarykey(Id);
                    if (_db.Save())
                    {
                        RefreshSections();
                        _IsAnyThingEdited = true;
                    }


                }

            }
            else
                CrownMessageBox.ShowError("لطفا یک مورد را انتخاب نمایید ", "موردی انتخاب نشده ");

        }

        private void toolStripButtonExitForm_Click(object sender, EventArgs e)
        {
            _db.Dispose();
            DialogResult = _IsAnyThingEdited ? DialogResult.OK : DialogResult.OK;
        }
    }
}
