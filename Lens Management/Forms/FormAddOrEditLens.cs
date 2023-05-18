using DataLayer.Model;
using DataLayer.ViewModels;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitOfWork;
using static System.Collections.Specialized.BitVector32;
using Section = DataLayer.Model.Section;

namespace Lens_Management.Forms
{
    public partial class FormAddOrEditLens : Form
    {
        private UnitOfWorkDB _db;
        private List<Section> _sections;
        private Lens _lens;
        private void InitializeSections()
        {
            _db = new UnitOfWorkDB();
            _sections = _db.SectionRepository.Get().ToList();
            foreverComboBoxSections.Items.AddRange(_sections.Select(s => s.Title).ToArray());
        }

        public FormAddOrEditLens(int Id = 0)
        {
            InitializeComponent();
            InitializeSections();
            if (Id != 0)
            {
                _lens = _db.LensRepository.GetByPrimaryKey(Id);
                foreverTextBoxSPH.Text = _lens.SPH.ToString();
                foreverTextBoxCYL.Text = _lens.CYL.ToString();
                foreverTextBoxAXE.Text = _lens.AXE.ToString();
                foreverTextBoxCount.Text = _lens.Count.ToString();
                foreverTextBoxPrice.Text = _lens.Price.ToString();
                foreverTextBoxDescription.Text = _lens.Description;
                foreverButtonSubmit.Text = "ویرایش";
                this.Text = "ویرایش";
                foreverComboBoxSections.SelectedIndex = _sections.IndexOf(_sections.Where(s => s.ID == _lens.SectionID).Single());
            }
        }

        private bool IsInputsValidate(out LensViewModel model)
        {
            model = null;
            int Count = 0, Price = 0;
            bool IsValidate = !string.IsNullOrEmpty(foreverTextBoxSPH.Text) &&
                !string.IsNullOrEmpty(foreverTextBoxCYL.Text) &&
                !string.IsNullOrEmpty(foreverTextBoxAXE.Text) &&
                int.TryParse(foreverTextBoxCount.Text, out Count) &&
                int.TryParse(foreverTextBoxPrice.Text, out Price) &&
                foreverComboBoxSections.SelectedIndex != -1;
            if (IsValidate)
            {
                model = new LensViewModel()
                {
                    SPH = foreverTextBoxSPH.Text,
                    CYL = foreverTextBoxCYL.Text,
                    AXE = foreverTextBoxAXE.Text,
                    Count = Count,
                    Price = Price,
                    Description = foreverTextBoxDescription.Text,
                    SectionID = _sections[foreverComboBoxSections.SelectedIndex].ID
                };
            }
            return IsValidate;
        }

        private void foreverButtoCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void foreverButtonSubmit_Click(object sender, EventArgs e)
        {
            LensViewModel model;
            if (IsInputsValidate(out model))
            {
                if (_lens == null)
                {
                    Lens lens = new Lens()
                    {
                        SPH = model.SPH,
                        CYL = model.CYL,
                        AXE = model.AXE,
                        Count = model.Count,
                        Price = model.Price,
                        Description = model.Description,
                        SectionID = model.SectionID
                    };

                    _db.LensRepository.Insert(lens);
                }
                else
                {
                    _lens.SPH = model.SPH;
                    _lens.CYL = model.CYL;
                    _lens.AXE = model.AXE;
                    _lens.Count = model.Count;
                    _lens.Price = model.Price;
                    _lens.Description = model.Description;
                    _lens.SectionID = model.SectionID;

                    _db.LensRepository.Update(_lens);
                }

                DialogResult = _db.Save() ? DialogResult.OK : DialogResult.None;
            }
            else
            {
                CrownMessageBox.ShowError("برخی موارد ورودی صحیح نیستند : عنوان اسفر سیلندر محور تعداد و انتخاب بخش اجباری هستند ", "اطلاعات ناقص");
            }

        }

        private void foreverButtoCancel_Click_1(object sender, EventArgs e)
        {
            _db.Dispose();
            Close();
        }
    }
}
