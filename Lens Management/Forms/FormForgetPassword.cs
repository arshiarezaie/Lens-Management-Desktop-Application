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
    public partial class FormForgetPassword : Form
    {
        public FormForgetPassword()
        {
            InitializeComponent();
        }

        private void foreverButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void foreverCheckBoxShowPasswordChar_CheckedChanged(object sender)
        {
            foreverTextBoxPassWord.UseSystemPasswordChar = !foreverCheckBoxShowPasswordChar.Checked;
        }

        private void foreverCheckBoxShowHint_CheckedChanged(object sender)
        {
            foreverTextBoxHint.UseSystemPasswordChar = !foreverCheckBoxShowHint.Checked;
        }

        private void foreverButtonRegister_Click(object sender, EventArgs e)
        {
            if (Authorize.ForgetPasssword(foreverTextBoxUserName.Text,
                foreverTextBoxHint.Text, foreverTextBoxPassWord.Text))
            {
                CrownMessageBox.ShowInformation("رمز جدید برای شما ثبت شد ", "موفق");
                DialogResult = DialogResult.OK;
            }
            else
            {
                CrownMessageBox.ShowError("کاربری با مشخصات وارد شده پیدا نشد ", "چیزی یافت نشد ");
            }
        }
    }
}
