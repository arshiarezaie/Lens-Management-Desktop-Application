using Lens_Management.Classes;
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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void foreverCheckBoxShowPasswordChar_CheckedChanged(object sender)
        {
            foreverTextBoxPassWord.UseSystemPasswordChar = !foreverCheckBoxShowPasswordChar.Checked;
        }

        private void foreverCheckBoxShowHint_CheckedChanged(object sender)
        {
            foreverTextBoxHint.UseSystemPasswordChar = !foreverCheckBoxShowHint.Checked;
        }

        private void foreverButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void foreverButtonRegister_Click(object sender, EventArgs e)
        {
            bool result = Authorize.Register(new DataLayer.Model.User()
            {
                Username = foreverTextBoxUserName.Text,
                Password = foreverTextBoxPassWord.Text,
                Hint = foreverTextBoxHint.Text,
                RoleID = 1
            });
            DialogResult = result ? DialogResult.OK : DialogResult.None;
        }
    }
}
