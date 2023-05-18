using DataLayer.Model;
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
    public partial class FormAddOrEditSection : Form
    {
        private UnitOfWorkDB _db;
        private Section _section;
        public FormAddOrEditSection(int Id = 0)
        {
            InitializeComponent();
            _db = new UnitOfWorkDB();
            if (Id != 0)
            {
                _section = _db.SectionRepository.GetByPrimaryKey(Id);
                foreverTextBoxSectionTitle.Text = _section.Title;
                this.Text = "Edit Section";
                foreverButtonSubmit.Text = "ویرایش";
                
            }

        }

        private void foreverButtonSubmit_Click(object sender, EventArgs e)
        {
            if (_section == null)
            {
                Section section = new Section()
                {
                    Title = foreverTextBoxSectionTitle.Text,
                };
                _db.SectionRepository.Insert(section);
            }
            else
            {
                _section.Title = foreverTextBoxSectionTitle.Text;
                _db.SectionRepository.Update(_section);
            }

            DialogResult = _db.Save() ? DialogResult.OK : DialogResult.None;
        }

        private void foreverButtonCancel_Click(object sender, EventArgs e)
        {
            _db.Dispose();
            Close();
        }
    }
}
