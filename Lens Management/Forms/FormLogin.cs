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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void foreverButtonLogin_Click(object sender, EventArgs e)
        {
            bool result = Authorize.Login(foreverTextBoxUserName.Text, foreverTextBoxPassWord.Text);
            if (result)
            {
                Hide();
                new Form1().ShowDialog();
            }
            else
                CrownMessageBox.ShowError("کاربری با مشخصات وارد شده پیدا نشد ", "نادرست");

        }

        private void foreverButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void poisonLinkLabelForgetPassword_Click(object sender, EventArgs e)
        {
            new FormForgetPassword().ShowDialog();
        }
    }
}
