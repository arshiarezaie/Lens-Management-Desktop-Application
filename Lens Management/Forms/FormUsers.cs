using Lens_Management.Classes;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormUsers : Form
    {
        private UnitOfWorkDB _db;
        private List<DataLayer.Model.User> _users;

        public void InitializeUsersList()
        {
            if (_db != null)
                _db.Dispose();

            _db = new UnitOfWorkDB();

            _users = _db.UserRepository.Get().ToList();
            listBoxUsers.Items.Clear();
            listBoxUsers.Items.AddRange(_users.Select(s => s.Username).ToArray());
        }


        public FormUsers()
        {
            InitializeComponent();
            InitializeUsersList();
        }

        private void toolStripButtonRemoveUser_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("آیا از حذف این کاربر اطمینان دارید ؟", "تایید حذف",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _db.UserRepository.Delete(_users[listBoxUsers.SelectedIndex]);
                    if (_db.Save())
                        InitializeUsersList();
                }
            }
            else
            {
                CrownMessageBox.ShowError("لطفا ابتدا موردی را انتخاب نمایید ", "موردی انتخاب نشده ");
            }

        }

        private void toolStripButtonAddNewUser_Click(object sender, EventArgs e)
        {
            if (new FormRegister().ShowDialog() == DialogResult.OK)
            {
                InitializeUsersList();
            }
        }

        private void toolStripButtonShowUserInformation_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndex != -1)
            {
                new FormViewUser(_users[listBoxUsers.SelectedIndex]).ShowDialog();
            }
            else
            {
                CrownMessageBox.ShowError("لطفا ابتدا موردی را انتخاب نمایید ", "موردی انتخاب نشده ");
            }
        }

        private void toolStripButtonExitForm_Click(object sender, EventArgs e)
        {
            _db.Dispose();
            Close();
        }
    }
}
