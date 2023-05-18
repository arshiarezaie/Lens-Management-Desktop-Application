using DataLayer.Model;
using Lens_Management.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitOfWork;

namespace Lens_Management.Forms
{
    public partial class FormReport : Form
    {
        private UnitOfWorkDB _db;
        private List<Section> _sections;
        void InitializeSections()
        {
            if (_db != null)
                _db.Dispose();

            _db = new UnitOfWorkDB();
            _sections = _db.SectionRepository.Get().ToList();
            foreverComboBoxSections.Items.AddRange(_sections.Select(s => s.Title).ToArray());
        }
        public FormReport()
        {
            InitializeComponent();
            foreverComboBoxSections.SelectedIndex = 0;
            InitializeSections();
        }

        Expression<Func<Lens, bool>> SetExpression()
        {
            if (foreverComboBoxSections.SelectedIndex == 0)
                return null;
            else
            {
                int Id = _sections[foreverComboBoxSections.SelectedIndex - 1].ID;
                return l => l.SectionID == Id;
            }

        }

        private void foreverButtonReport_Click(object sender, EventArgs e)
        {
            Report.GetReport(SetExpression(), foreverCheckBoxFullReport.Checked, foreverCheckBoxShowWord.Checked);
        }


        private void foreverButtonClose_Click(object sender, EventArgs e)
        {
            _db.Dispose();
            Close();
        }
    }
}
