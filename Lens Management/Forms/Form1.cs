using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Model;
using DataLayer.ViewModels;
using Lens_Management.Classes;
using Lens_Management.Forms;
using ReaLTaiizor;
using ReaLTaiizor.Action;
using ReaLTaiizor.Animate;
using ReaLTaiizor.Child;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Design;
using ReaLTaiizor.Docking;
using ReaLTaiizor.Drawing;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Interface;
using UnitOfWork;

namespace Lens_Management
{
    public partial class Form1 : Form
    {
        private UnitOfWorkDB _db;
        private List<LensViewModel> _Lenses;
        private void RefreshDataGrid(Expression<Func<Lens, bool>> where = null)
        {
            _Lenses = new List<LensViewModel>();

            if (_db != null)
                _db.Dispose();

            _db = new UnitOfWorkDB();

            foreach (Lens lens in _db.LensRepository.Get(where).ToList())
            {
                _Lenses.Add(new LensViewModel()
                {
                    ID = lens.ID,
                    SPH = lens.SPH,
                    CYL = lens.CYL,
                    AXE = lens.AXE,
                    Count = lens.Count,
                    Price = lens.Price,
                    Description = lens.Description,
                    SectionTitle = lens.Section.Title

                });

            }

            poisonDataGridViewLenses.DataSource = _Lenses;
            poisonDataGridViewLenses.Columns["SectionID"].Visible = false;
            poisonDataGridViewLenses.Columns["ID"].Visible = false;
        }
        public Form1()
        {
            InitializeComponent();
            poisonDataGridViewLenses.EditMode = DataGridViewEditMode.EditProgrammatically;
            toolStripLabelUserName.Text = "کاربر : " + Authorize.user.Username;
            RefreshDataGrid();
        }


        private void toolStripButtonSections_Click(object sender, EventArgs e)
        {
            if (new FormSections().ShowDialog() == DialogResult.OK)
                RefreshDataGrid();
        }

        private void toolStripButtonAddNewLens_Click(object sender, EventArgs e)
        {
            if (new FormAddOrEditLens().ShowDialog() == DialogResult.OK)
            {
                RefreshDataGrid();
            }
        }

        private void toolStripButtonEditLens_Click(object sender, EventArgs e)
        {
            if (poisonDataGridViewLenses.SelectedRows.Count > 0)
            {
                if (new FormAddOrEditLens(_Lenses[poisonDataGridViewLenses.SelectedRows[0].Index].ID).ShowDialog() == DialogResult.OK)
                {
                    RefreshDataGrid();
                }
            }
            else
            {
                CrownMessageBox.ShowError("برای ویرایش باید ابتدا موردی را انتخاب کنید ", "چیزی انتخاب نشده");
            }
        }

        private void toolStripButtonRemoveLens_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ایا از حذف این مورد اطمینان دارید ؟ ", "تایید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _db.LensRepository.DeleteByPrimarykey(poisonDataGridViewLenses.SelectedRows[0].Cells[0].Value);
                if (_db.Save())
                    RefreshDataGrid();
            }
        }


        private void Search()
        {
            Expression<Func<Lens, bool>> expression = null;

            bool isAnyThingSearch = !string.IsNullOrEmpty(toolStripTextBoxSPH.Text) || !string.IsNullOrEmpty(toolStripTextBoxCYL.Text)
                || !string.IsNullOrEmpty(toolStripTextBoxAXE.Text);

            if (isAnyThingSearch)
            {
                expression = l => l.SPH == toolStripTextBoxSPH.Text || l.CYL == toolStripTextBoxCYL.Text || l.AXE == toolStripTextBoxAXE.Text;
            }


            RefreshDataGrid(expression);
        }

        private void toolStripTextBoxSPH_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void toolStripTextBoxCYL_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void toolStripTextBoxAXE_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void toolStripButtonGetReport_Click(object sender, EventArgs e)
        {
            new FormReport().ShowDialog();
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            _db.Dispose();
            Application.Exit();
        }

        private void toolStripButtonUsers_Click(object sender, EventArgs e)
        {
            if (Authorize.user.RoleID == 2)
                new FormUsers().ShowDialog();
            else
                CrownMessageBox.ShowError("شما اجازه ورود به این بخش را ندارید ", "دسترسی ممکن نیست ");
        }

        private void toolStripButtonLogOut_Click(object sender, EventArgs e)
        {
            Authorize.LogOut();
            new FormLogin().ShowDialog();
        }

        private void toolStripButtonChangePassword_Click(object sender, EventArgs e)
        {
            new FormChnagePassword().ShowDialog();
        }
    }
}
