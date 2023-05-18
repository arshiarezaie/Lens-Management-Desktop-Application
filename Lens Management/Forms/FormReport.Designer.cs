namespace Lens_Management.Forms
{
    partial class FormReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            this.foreverCheckBoxFullReport = new ReaLTaiizor.Controls.ForeverCheckBox();
            this.foreverCheckBoxShowWord = new ReaLTaiizor.Controls.ForeverCheckBox();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverComboBoxSections = new ReaLTaiizor.Controls.ForeverComboBox();
            this.foreverButtonClose = new ReaLTaiizor.Controls.ForeverButton();
            this.foreverButtonReport = new ReaLTaiizor.Controls.ForeverButton();
            this.foreverForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // foreverForm1
            // 
            this.foreverForm1.BackColor = System.Drawing.Color.White;
            this.foreverForm1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverForm1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.foreverForm1.Controls.Add(this.foreverCheckBoxFullReport);
            this.foreverForm1.Controls.Add(this.foreverCheckBoxShowWord);
            this.foreverForm1.Controls.Add(this.foreverLabel1);
            this.foreverForm1.Controls.Add(this.foreverComboBoxSections);
            this.foreverForm1.Controls.Add(this.foreverButtonClose);
            this.foreverForm1.Controls.Add(this.foreverButtonReport);
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
            this.foreverForm1.Size = new System.Drawing.Size(445, 275);
            this.foreverForm1.TabIndex = 1;
            this.foreverForm1.Text = "گزارش گیری";
            this.foreverForm1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.foreverForm1.TextLight = System.Drawing.Color.SeaGreen;
            // 
            // foreverCheckBoxFullReport
            // 
            this.foreverCheckBoxFullReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverCheckBoxFullReport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverCheckBoxFullReport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverCheckBoxFullReport.Checked = false;
            this.foreverCheckBoxFullReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverCheckBoxFullReport.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverCheckBoxFullReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverCheckBoxFullReport.Location = new System.Drawing.Point(12, 127);
            this.foreverCheckBoxFullReport.Name = "foreverCheckBoxFullReport";
            this.foreverCheckBoxFullReport.Options = ReaLTaiizor.Controls.ForeverCheckBox._Options.Style1;
            this.foreverCheckBoxFullReport.Size = new System.Drawing.Size(97, 22);
            this.foreverCheckBoxFullReport.TabIndex = 10;
            this.foreverCheckBoxFullReport.Text = "گزارش کامل ";
            // 
            // foreverCheckBoxShowWord
            // 
            this.foreverCheckBoxShowWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverCheckBoxShowWord.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverCheckBoxShowWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverCheckBoxShowWord.Checked = false;
            this.foreverCheckBoxShowWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverCheckBoxShowWord.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverCheckBoxShowWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverCheckBoxShowWord.Location = new System.Drawing.Point(335, 127);
            this.foreverCheckBoxShowWord.Name = "foreverCheckBoxShowWord";
            this.foreverCheckBoxShowWord.Options = ReaLTaiizor.Controls.ForeverCheckBox._Options.Style1;
            this.foreverCheckBoxShowWord.Size = new System.Drawing.Size(82, 22);
            this.foreverCheckBoxShowWord.TabIndex = 10;
            this.foreverCheckBoxShowWord.Text = "نمایش ورد ";
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.foreverLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel1.Location = new System.Drawing.Point(366, 62);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(67, 19);
            this.foreverLabel1.TabIndex = 9;
            this.foreverLabel1.Text = "گزارش از :";
            // 
            // foreverComboBoxSections
            // 
            this.foreverComboBoxSections.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.foreverComboBoxSections.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverComboBoxSections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverComboBoxSections.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.foreverComboBoxSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foreverComboBoxSections.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.foreverComboBoxSections.ForeColor = System.Drawing.Color.White;
            this.foreverComboBoxSections.FormattingEnabled = true;
            this.foreverComboBoxSections.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverComboBoxSections.HoverFontColor = System.Drawing.Color.White;
            this.foreverComboBoxSections.ItemHeight = 18;
            this.foreverComboBoxSections.Items.AddRange(new object[] {
            "همه"});
            this.foreverComboBoxSections.Location = new System.Drawing.Point(12, 97);
            this.foreverComboBoxSections.Name = "foreverComboBoxSections";
            this.foreverComboBoxSections.Size = new System.Drawing.Size(421, 24);
            this.foreverComboBoxSections.TabIndex = 8;
            // 
            // foreverButtonClose
            // 
            this.foreverButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.foreverButtonClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.foreverButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverButtonClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverButtonClose.Location = new System.Drawing.Point(12, 204);
            this.foreverButtonClose.Name = "foreverButtonClose";
            this.foreverButtonClose.Rounded = false;
            this.foreverButtonClose.Size = new System.Drawing.Size(421, 43);
            this.foreverButtonClose.TabIndex = 7;
            this.foreverButtonClose.Text = "لغو";
            this.foreverButtonClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverButtonClose.Click += new System.EventHandler(this.foreverButtonClose_Click);
            // 
            // foreverButtonReport
            // 
            this.foreverButtonReport.BackColor = System.Drawing.Color.Transparent;
            this.foreverButtonReport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverButtonReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverButtonReport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverButtonReport.Location = new System.Drawing.Point(12, 155);
            this.foreverButtonReport.Name = "foreverButtonReport";
            this.foreverButtonReport.Rounded = false;
            this.foreverButtonReport.Size = new System.Drawing.Size(421, 43);
            this.foreverButtonReport.TabIndex = 7;
            this.foreverButtonReport.Text = "دریافت گزارش";
            this.foreverButtonReport.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverButtonReport.Click += new System.EventHandler(this.foreverButtonReport_Click);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 275);
            this.Controls.Add(this.foreverForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReport";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.foreverForm1.ResumeLayout(false);
            this.foreverForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private ReaLTaiizor.Controls.ForeverCheckBox foreverCheckBoxShowWord;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.ForeverComboBox foreverComboBoxSections;
        private ReaLTaiizor.Controls.ForeverButton foreverButtonReport;
        private ReaLTaiizor.Controls.ForeverButton foreverButtonClose;
        private ReaLTaiizor.Controls.ForeverCheckBox foreverCheckBoxFullReport;
    }
}