namespace Lens_Management
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AXE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CYL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.poisonDataGridViewLenses = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxSPH = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxCYL = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxAXE = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabelUserName = new System.Windows.Forms.ToolStripLabel();
            this.foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            this.toolStripButtonAddNewLens = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditLens = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveLens = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSections = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGetReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonChangePassword = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridViewLenses)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.foreverForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // AXE
            // 
            this.AXE.DataPropertyName = "AXE";
            this.AXE.HeaderText = "AXE";
            this.AXE.MinimumWidth = 6;
            this.AXE.Name = "AXE";
            // 
            // CYL
            // 
            this.CYL.DataPropertyName = "CYL";
            this.CYL.HeaderText = "CYL";
            this.CYL.MinimumWidth = 6;
            this.CYL.Name = "CYL";
            // 
            // SPH
            // 
            this.SPH.DataPropertyName = "SPH";
            this.SPH.HeaderText = "SPH";
            this.SPH.MinimumWidth = 6;
            this.SPH.Name = "SPH";
            // 
            // SectionTitle
            // 
            this.SectionTitle.DataPropertyName = "SectionTitle";
            this.SectionTitle.HeaderText = "SectionTitle";
            this.SectionTitle.MinimumWidth = 6;
            this.SectionTitle.Name = "SectionTitle";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 54);
            this.toolStripLabel1.Text = "جستجو =>";
            // 
            // poisonDataGridViewLenses
            // 
            this.poisonDataGridViewLenses.AllowUserToResizeRows = false;
            this.poisonDataGridViewLenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.poisonDataGridViewLenses.BackgroundColor = System.Drawing.Color.Gray;
            this.poisonDataGridViewLenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonDataGridViewLenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonDataGridViewLenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridViewLenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.poisonDataGridViewLenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poisonDataGridViewLenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SectionTitle,
            this.SPH,
            this.CYL,
            this.AXE,
            this.Count,
            this.Price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonDataGridViewLenses.DefaultCellStyle = dataGridViewCellStyle2;
            this.poisonDataGridViewLenses.EnableHeadersVisualStyles = false;
            this.poisonDataGridViewLenses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.poisonDataGridViewLenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.poisonDataGridViewLenses.Location = new System.Drawing.Point(12, 133);
            this.poisonDataGridViewLenses.Name = "poisonDataGridViewLenses";
            this.poisonDataGridViewLenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridViewLenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.poisonDataGridViewLenses.RowHeadersWidth = 51;
            this.poisonDataGridViewLenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.poisonDataGridViewLenses.RowTemplate.Height = 24;
            this.poisonDataGridViewLenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poisonDataGridViewLenses.Size = new System.Drawing.Size(1322, 480);
            this.poisonDataGridViewLenses.TabIndex = 1;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "Count";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddNewLens,
            this.toolStripButtonEditLens,
            this.toolStripButtonRemoveLens,
            this.toolStripButtonSections,
            this.toolStripButtonUsers,
            this.toolStripButtonGetReport,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripTextBoxSPH,
            this.toolStripLabel4,
            this.toolStripTextBoxCYL,
            this.toolStripLabel5,
            this.toolStripTextBoxAXE,
            this.toolStripLabelUserName,
            this.toolStripButtonExit,
            this.toolStripButtonLogOut,
            this.toolStripButtonChangePassword});
            this.toolStrip1.Location = new System.Drawing.Point(1, 51);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1344, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(39, 54);
            this.toolStripLabel2.Text = "SPH:";
            // 
            // toolStripTextBoxSPH
            // 
            this.toolStripTextBoxSPH.BackColor = System.Drawing.Color.Silver;
            this.toolStripTextBoxSPH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxSPH.Name = "toolStripTextBoxSPH";
            this.toolStripTextBoxSPH.Size = new System.Drawing.Size(100, 57);
            this.toolStripTextBoxSPH.TextChanged += new System.EventHandler(this.toolStripTextBoxSPH_TextChanged);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(36, 54);
            this.toolStripLabel4.Text = "CYL:";
            // 
            // toolStripTextBoxCYL
            // 
            this.toolStripTextBoxCYL.BackColor = System.Drawing.Color.Silver;
            this.toolStripTextBoxCYL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxCYL.Name = "toolStripTextBoxCYL";
            this.toolStripTextBoxCYL.Size = new System.Drawing.Size(100, 57);
            this.toolStripTextBoxCYL.TextChanged += new System.EventHandler(this.toolStripTextBoxCYL_TextChanged);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(39, 54);
            this.toolStripLabel5.Text = "AXE:";
            // 
            // toolStripTextBoxAXE
            // 
            this.toolStripTextBoxAXE.BackColor = System.Drawing.Color.Silver;
            this.toolStripTextBoxAXE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxAXE.Name = "toolStripTextBoxAXE";
            this.toolStripTextBoxAXE.Size = new System.Drawing.Size(100, 57);
            this.toolStripTextBoxAXE.TextChanged += new System.EventHandler(this.toolStripTextBoxAXE_TextChanged);
            // 
            // toolStripLabelUserName
            // 
            this.toolStripLabelUserName.Margin = new System.Windows.Forms.Padding(40, 2, 2, 2);
            this.toolStripLabelUserName.Name = "toolStripLabelUserName";
            this.toolStripLabelUserName.Size = new System.Drawing.Size(122, 53);
            this.toolStripLabelUserName.Text = "کاربر : علی رضایی";
            // 
            // foreverForm1
            // 
            this.foreverForm1.BackColor = System.Drawing.Color.White;
            this.foreverForm1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverForm1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.foreverForm1.Controls.Add(this.poisonDataGridViewLenses);
            this.foreverForm1.Controls.Add(this.toolStrip1);
            this.foreverForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foreverForm1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverForm1.ForeverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverForm1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverForm1.HeaderMaximize = false;
            this.foreverForm1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverForm1.Image = null;
            this.foreverForm1.Location = new System.Drawing.Point(0, 0);
            this.foreverForm1.MinimumSize = new System.Drawing.Size(210, 50);
            this.foreverForm1.Name = "foreverForm1";
            this.foreverForm1.Padding = new System.Windows.Forms.Padding(1, 51, 1, 1);
            this.foreverForm1.Sizable = true;
            this.foreverForm1.Size = new System.Drawing.Size(1346, 625);
            this.foreverForm1.TabIndex = 1;
            this.foreverForm1.Text = "Lens Management";
            this.foreverForm1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.foreverForm1.TextLight = System.Drawing.Color.SeaGreen;
            // 
            // toolStripButtonAddNewLens
            // 
            this.toolStripButtonAddNewLens.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddNewLens.Image = global::Lens_Management.Properties.Resources.kindpng_1120914;
            this.toolStripButtonAddNewLens.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddNewLens.Name = "toolStripButtonAddNewLens";
            this.toolStripButtonAddNewLens.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonAddNewLens.Text = "toolStripButton1";
            this.toolStripButtonAddNewLens.ToolTipText = "افزودن عدسی جدید";
            this.toolStripButtonAddNewLens.Click += new System.EventHandler(this.toolStripButtonAddNewLens_Click);
            // 
            // toolStripButtonEditLens
            // 
            this.toolStripButtonEditLens.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditLens.Image = global::Lens_Management.Properties.Resources.kindpng_7101247;
            this.toolStripButtonEditLens.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditLens.Name = "toolStripButtonEditLens";
            this.toolStripButtonEditLens.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonEditLens.Text = "toolStripButton2";
            this.toolStripButtonEditLens.ToolTipText = "ویرایش عدسی  ";
            this.toolStripButtonEditLens.Click += new System.EventHandler(this.toolStripButtonEditLens_Click);
            // 
            // toolStripButtonRemoveLens
            // 
            this.toolStripButtonRemoveLens.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveLens.Image = global::Lens_Management.Properties.Resources.kindpng_297503;
            this.toolStripButtonRemoveLens.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveLens.Name = "toolStripButtonRemoveLens";
            this.toolStripButtonRemoveLens.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonRemoveLens.Text = "toolStripButton3";
            this.toolStripButtonRemoveLens.ToolTipText = "حذف عدسی";
            this.toolStripButtonRemoveLens.Click += new System.EventHandler(this.toolStripButtonRemoveLens_Click);
            // 
            // toolStripButtonSections
            // 
            this.toolStripButtonSections.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSections.Image = global::Lens_Management.Properties.Resources.shop_icon_png_6;
            this.toolStripButtonSections.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSections.Name = "toolStripButtonSections";
            this.toolStripButtonSections.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonSections.Text = "toolStripButton4";
            this.toolStripButtonSections.ToolTipText = "بخش ها";
            this.toolStripButtonSections.Click += new System.EventHandler(this.toolStripButtonSections_Click);
            // 
            // toolStripButtonUsers
            // 
            this.toolStripButtonUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUsers.Image = global::Lens_Management.Properties.Resources.kindpng_7804962;
            this.toolStripButtonUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsers.Name = "toolStripButtonUsers";
            this.toolStripButtonUsers.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonUsers.Text = "toolStripButton6";
            this.toolStripButtonUsers.ToolTipText = "کاربران";
            this.toolStripButtonUsers.Click += new System.EventHandler(this.toolStripButtonUsers_Click);
            // 
            // toolStripButtonGetReport
            // 
            this.toolStripButtonGetReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGetReport.Image = global::Lens_Management.Properties.Resources.kindpng_2259167__1_;
            this.toolStripButtonGetReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGetReport.Name = "toolStripButtonGetReport";
            this.toolStripButtonGetReport.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonGetReport.Text = "toolStripButton7";
            this.toolStripButtonGetReport.ToolTipText = "گزارش گیری";
            this.toolStripButtonGetReport.Click += new System.EventHandler(this.toolStripButtonGetReport_Click);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = global::Lens_Management.Properties.Resources.kindpng_2004999__1_;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonExit.Text = "toolStripButton7";
            this.toolStripButtonExit.ToolTipText = "خروج از برنامه";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // toolStripButtonLogOut
            // 
            this.toolStripButtonLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLogOut.Image = global::Lens_Management.Properties.Resources.kindpng_3390176;
            this.toolStripButtonLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLogOut.Name = "toolStripButtonLogOut";
            this.toolStripButtonLogOut.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonLogOut.Text = "toolStripButton6";
            this.toolStripButtonLogOut.ToolTipText = "خروج از حساب کاربری";
            this.toolStripButtonLogOut.Click += new System.EventHandler(this.toolStripButtonLogOut_Click);
            // 
            // toolStripButtonChangePassword
            // 
            this.toolStripButtonChangePassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonChangePassword.Image = global::Lens_Management.Properties.Resources.kindpng_1041308;
            this.toolStripButtonChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonChangePassword.Name = "toolStripButtonChangePassword";
            this.toolStripButtonChangePassword.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonChangePassword.Text = "toolStripButton6";
            this.toolStripButtonChangePassword.ToolTipText = "تغیر رمز";
            this.toolStripButtonChangePassword.Click += new System.EventHandler(this.toolStripButtonChangePassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 625);
            this.Controls.Add(this.foreverForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dungeonForm1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridViewLenses)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.foreverForm1.ResumeLayout(false);
            this.foreverForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn AXE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CYL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionTitle;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonGetReport;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsers;
        private System.Windows.Forms.ToolStripButton toolStripButtonSections;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveLens;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditLens;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddNewLens;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridViewLenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSPH;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxCYL;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxAXE;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelUserName;
        private System.Windows.Forms.ToolStripButton toolStripButtonLogOut;
        private System.Windows.Forms.ToolStripButton toolStripButtonChangePassword;
    }
}

