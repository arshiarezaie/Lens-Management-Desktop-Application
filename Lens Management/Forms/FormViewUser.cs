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
using User = DataLayer.Model.User;

namespace Lens_Management.Forms
{
    public partial class FormViewUser : Form
    {
        void InitializeFormData(User user)
        {
            foreverTextBoxUserName.Text = user.Username;
            foreverTextBoxRoleTitle.Text = user.RoleID == 1 ? "کاربر  عادی " : "مدیر سیستم ";
        }
        public FormViewUser(User user)
        {
            InitializeComponent();
            InitializeFormData(user);
        }

        private void foreverButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
