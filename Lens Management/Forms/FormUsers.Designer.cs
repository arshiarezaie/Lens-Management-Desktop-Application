namespace Lens_Management.Forms
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddNewUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowUserInformation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveUser = new System.Windows.Forms.ToolStripButton();
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
            this.foreverForm1.Controls.Add(this.listBoxUsers);
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
            this.foreverForm1.Size = new System.Drawing.Size(800, 600);
            this.foreverForm1.TabIndex = 0;
            this.foreverForm1.Text = "کاربران";
            this.foreverForm1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.foreverForm1.TextLight = System.Drawing.Color.SeaGreen;
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxUsers.ForeColor = System.Drawing.Color.White;
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 28;
            this.listBoxUsers.Location = new System.Drawing.Point(22, 140);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(753, 424);
            this.listBoxUsers.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddNewUser,
            this.toolStripButtonShowUserInformation,
            this.toolStripButtonRemoveUser,
            this.toolStripButtonExitForm});
            this.toolStrip1.Location = new System.Drawing.Point(1, 51);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(798, 57);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAddNewUser
            // 
            this.toolStripButtonAddNewUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddNewUser.Image = global::Lens_Management.Properties.Resources.kindpng_1120914;
            this.toolStripButtonAddNewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddNewUser.Name = "toolStripButtonAddNewUser";
            this.toolStripButtonAddNewUser.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonAddNewUser.Text = "toolStripButton1";
            this.toolStripButtonAddNewUser.ToolTipText = "افزودن کاربر جدید";
            this.toolStripButtonAddNewUser.Click += new System.EventHandler(this.toolStripButtonAddNewUser_Click);
            // 
            // toolStripButtonShowUserInformation
            // 
            this.toolStripButtonShowUserInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowUserInformation.Image = global::Lens_Management.Properties.Resources.kindpng_800252;
            this.toolStripButtonShowUserInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowUserInformation.Name = "toolStripButtonShowUserInformation";
            this.toolStripButtonShowUserInformation.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonShowUserInformation.ToolTipText = "مشاهده مشخصات ";
            this.toolStripButtonShowUserInformation.Click += new System.EventHandler(this.toolStripButtonShowUserInformation_Click);
            // 
            // toolStripButtonRemoveUser
            // 
            this.toolStripButtonRemoveUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveUser.Image = global::Lens_Management.Properties.Resources.kindpng_297503;
            this.toolStripButtonRemoveUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveUser.Name = "toolStripButtonRemoveUser";
            this.toolStripButtonRemoveUser.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonRemoveUser.Text = "toolStripButton3";
            this.toolStripButtonRemoveUser.ToolTipText = "حذف ";
            this.toolStripButtonRemoveUser.Click += new System.EventHandler(this.toolStripButtonRemoveUser_Click);
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
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.foreverForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsers";
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
        private System.Windows.Forms.ToolStripButton toolStripButtonAddNewUser;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveUser;
        private System.Windows.Forms.ToolStripButton toolStripButtonExitForm;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowUserInformation;
    }
}