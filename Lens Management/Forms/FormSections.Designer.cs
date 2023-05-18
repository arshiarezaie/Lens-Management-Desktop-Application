namespace Lens_Management.Forms
{
    partial class FormSections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSections));
            this.foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            this.listBoxSections = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddNewSection = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditSection = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveSection = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExitForm = new System.Windows.Forms.ToolStripButton();
            this.foreverForm1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // foreverForm1
            // 
            this.foreverForm1.BackColor = System.Drawing.Color.White;
            this.foreverForm1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverForm1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.foreverForm1.Controls.Add(this.listBoxSections);
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
            this.foreverForm1.Size = new System.Drawing.Size(574, 478);
            this.foreverForm1.TabIndex = 0;
            this.foreverForm1.Text = "بخش ها";
            this.foreverForm1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.foreverForm1.TextLight = System.Drawing.Color.SeaGreen;
            // 
            // listBoxSections
            // 
            this.listBoxSections.FormattingEnabled = true;
            this.listBoxSections.ItemHeight = 28;
            this.listBoxSections.Location = new System.Drawing.Point(12, 144);
            this.listBoxSections.Name = "listBoxSections";
            this.listBoxSections.Size = new System.Drawing.Size(550, 312);
            this.listBoxSections.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddNewSection,
            this.toolStripButtonEditSection,
            this.toolStripButtonRemoveSection,
            this.toolStripButtonExitForm});
            this.toolStrip1.Location = new System.Drawing.Point(132, 63);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(229, 57);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAddNewSection
            // 
            this.toolStripButtonAddNewSection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddNewSection.Image = global::Lens_Management.Properties.Resources.kindpng_1120914;
            this.toolStripButtonAddNewSection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddNewSection.Name = "toolStripButtonAddNewSection";
            this.toolStripButtonAddNewSection.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonAddNewSection.Text = "toolStripButton1";
            this.toolStripButtonAddNewSection.ToolTipText = "افزودن بخش جدید";
            this.toolStripButtonAddNewSection.Click += new System.EventHandler(this.toolStripButtonAddNewSection_Click);
            // 
            // toolStripButtonEditSection
            // 
            this.toolStripButtonEditSection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditSection.Image = global::Lens_Management.Properties.Resources.kindpng_7101247;
            this.toolStripButtonEditSection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditSection.Name = "toolStripButtonEditSection";
            this.toolStripButtonEditSection.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonEditSection.Text = "toolStripButton2";
            this.toolStripButtonEditSection.ToolTipText = "ویرایش بخش ";
            this.toolStripButtonEditSection.Click += new System.EventHandler(this.toolStripButtonEditSection_Click);
            // 
            // toolStripButtonRemoveSection
            // 
            this.toolStripButtonRemoveSection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveSection.Image = global::Lens_Management.Properties.Resources.kindpng_297503;
            this.toolStripButtonRemoveSection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveSection.Name = "toolStripButtonRemoveSection";
            this.toolStripButtonRemoveSection.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonRemoveSection.Text = "toolStripButton3";
            this.toolStripButtonRemoveSection.ToolTipText = "حذف بخش";
            this.toolStripButtonRemoveSection.Click += new System.EventHandler(this.toolStripButtonRemoveSection_Click);
            // 
            // toolStripButtonExitForm
            // 
            this.toolStripButtonExitForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExitForm.Image = global::Lens_Management.Properties.Resources.kindpng_2004999__1_;
            this.toolStripButtonExitForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExitForm.Name = "toolStripButtonExitForm";
            this.toolStripButtonExitForm.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonExitForm.Text = "toolStripButton7";
            this.toolStripButtonExitForm.ToolTipText = "خروج از صفحه";
            this.toolStripButtonExitForm.Click += new System.EventHandler(this.toolStripButtonExitForm_Click);
            // 
            // FormSections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 478);
            this.Controls.Add(this.foreverForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSections";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.foreverForm1.ResumeLayout(false);
            this.foreverForm1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddNewSection;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditSection;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveSection;
        private System.Windows.Forms.ToolStripButton toolStripButtonExitForm;
        private System.Windows.Forms.ListBox listBoxSections;
    }
}