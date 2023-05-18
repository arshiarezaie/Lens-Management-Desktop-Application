namespace Lens_Management.Forms
{
    partial class FormAddOrEditSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrEditSection));
            this.foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverButtonCancel = new ReaLTaiizor.Controls.ForeverButton();
            this.foreverButtonSubmit = new ReaLTaiizor.Controls.ForeverButton();
            this.foreverTextBoxSectionTitle = new ReaLTaiizor.Controls.ForeverTextBox();
            this.foreverForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // foreverForm1
            // 
            this.foreverForm1.BackColor = System.Drawing.Color.White;
            this.foreverForm1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverForm1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.foreverForm1.Controls.Add(this.foreverLabel1);
            this.foreverForm1.Controls.Add(this.foreverButtonCancel);
            this.foreverForm1.Controls.Add(this.foreverButtonSubmit);
            this.foreverForm1.Controls.Add(this.foreverTextBoxSectionTitle);
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
            this.foreverForm1.Size = new System.Drawing.Size(444, 230);
            this.foreverForm1.TabIndex = 0;
            this.foreverForm1.Text = "افزودن بخش";
            this.foreverForm1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.foreverForm1.TextLight = System.Drawing.Color.SeaGreen;
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.foreverLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel1.Location = new System.Drawing.Point(340, 75);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(79, 19);
            this.foreverLabel1.TabIndex = 2;
            this.foreverLabel1.Text = "عنوان بخش ";
            // 
            // foreverButtonCancel
            // 
            this.foreverButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.foreverButtonCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.foreverButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverButtonCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverButtonCancel.Location = new System.Drawing.Point(41, 156);
            this.foreverButtonCancel.Name = "foreverButtonCancel";
            this.foreverButtonCancel.Rounded = false;
            this.foreverButtonCancel.Size = new System.Drawing.Size(166, 40);
            this.foreverButtonCancel.TabIndex = 1;
            this.foreverButtonCancel.Text = "لغو";
            this.foreverButtonCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverButtonCancel.Click += new System.EventHandler(this.foreverButtonCancel_Click);
            // 
            // foreverButtonSubmit
            // 
            this.foreverButtonSubmit.BackColor = System.Drawing.Color.Transparent;
            this.foreverButtonSubmit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverButtonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverButtonSubmit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverButtonSubmit.Location = new System.Drawing.Point(213, 156);
            this.foreverButtonSubmit.Name = "foreverButtonSubmit";
            this.foreverButtonSubmit.Rounded = false;
            this.foreverButtonSubmit.Size = new System.Drawing.Size(166, 40);
            this.foreverButtonSubmit.TabIndex = 1;
            this.foreverButtonSubmit.Text = "ثبت";
            this.foreverButtonSubmit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverButtonSubmit.Click += new System.EventHandler(this.foreverButtonSubmit_Click);
            // 
            // foreverTextBoxSectionTitle
            // 
            this.foreverTextBoxSectionTitle.BackColor = System.Drawing.Color.Transparent;
            this.foreverTextBoxSectionTitle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverTextBoxSectionTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverTextBoxSectionTitle.FocusOnHover = false;
            this.foreverTextBoxSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.foreverTextBoxSectionTitle.Location = new System.Drawing.Point(12, 106);
            this.foreverTextBoxSectionTitle.MaxLength = 32767;
            this.foreverTextBoxSectionTitle.Multiline = false;
            this.foreverTextBoxSectionTitle.Name = "foreverTextBoxSectionTitle";
            this.foreverTextBoxSectionTitle.ReadOnly = false;
            this.foreverTextBoxSectionTitle.Size = new System.Drawing.Size(407, 34);
            this.foreverTextBoxSectionTitle.TabIndex = 0;
            this.foreverTextBoxSectionTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.foreverTextBoxSectionTitle.UseSystemPasswordChar = false;
            // 
            // FormAddOrEditSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 230);
            this.Controls.Add(this.foreverForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddOrEditSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddOrEditSection";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.foreverForm1.ResumeLayout(false);
            this.foreverForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private ReaLTaiizor.Controls.ForeverTextBox foreverTextBoxSectionTitle;
        private ReaLTaiizor.Controls.ForeverButton foreverButtonSubmit;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.ForeverButton foreverButtonCancel;
    }
}