using Lens_Management.Classes;
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

namespace Lens_Management.Forms
{
    public partial class FormChnagePassword : Form
    {
        public FormChnagePassword()
        {
            InitializeComponent();
        }

        private void foreverCheckBoxShowCurrentPasswordChar_CheckedChanged(object sender)
        {
            foreverTextBoxCurrentPassword.UseSystemPasswordChar = !foreverCheckBoxShowCurrentPasswordChar.Checked;
        }

        private void foreverCheckBoxShowNewPassWordChar_CheckedChanged(object sender)
        {
            foreverTextBoxNewPassword.UseSystemPasswordChar = !foreverCheckBoxShowNewPassWordChar.Checked;
        }

        private void foreverButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void foreverButtonChangePassword_Click(object sender, EventArgs e)
        {
            bool result = Authorize.ChangePassword(foreverTextBoxCurrentPassword.Text,
                foreverTextBoxNewPassword.Text);
            if (result)
            {
                CrownMessageBox.ShowInformation("رمز عبور تغیر کرد", "موفق");
                DialogResult = DialogResult.OK;
            }
            else
            {
                CrownMessageBox.ShowError("رمزعبور فعلی اشتباه است ", "ناموفق");
            }
        }
    }
}
