namespace Lens_Management.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            this.poisonLinkLabelForgetPassword = new ReaLTaiizor.Controls.PoisonLinkLabel();
            this.foreverButtonCancel = new ReaLTaiizor.Controls.ForeverButton();
            this.foreverButtonLogin = new ReaLTaiizor.Controls.ForeverButton();
            this.foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverTextBoxPassWord = new ReaLTaiizor.Controls.ForeverTextBox();
            this.foreverTextBoxUserName = new ReaLTaiizor.Controls.ForeverTextBox();
            this.foreverForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // foreverForm1
            // 
            this.foreverForm1.BackColor = System.Drawing.Color.White;
            this.foreverForm1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverForm1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.foreverForm1.Controls.Add(this.poisonLinkLabelForgetPassword);
            this.foreverForm1.Controls.Add(this.foreverButtonCancel);
            this.foreverForm1.Controls.Add(this.foreverButtonLogin);
            this.foreverForm1.Controls.Add(this.foreverLabel2);
            this.foreverForm1.Controls.Add(this.foreverLabel1);
            this.foreverForm1.Controls.Add(this.foreverTextBoxPassWord);
            this.foreverForm1.Controls.Add(this.foreverTextBoxUserName);
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
            this.foreverForm1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.foreverForm1.Sizable = true;
            this.foreverForm1.Size = new System.Drawing.Size(434, 336);
            this.foreverForm1.TabIndex = 2;
            this.foreverForm1.Text = "ورود به سیستم ";
            this.foreverForm1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.foreverForm1.TextLight = System.Drawing.Color.SeaGreen;
            // 
            // poisonLinkLabelForgetPassword
            // 
            this.poisonLinkLabelForgetPassword.Location = new System.Drawing.Point(12, 301);
            this.poisonLinkLabelForgetPassword.Name = "poisonLinkLabelForgetPassword";
            this.poisonLinkLabelForgetPassword.Size = new System.Drawing.Size(406, 23);
            this.poisonLinkLabelForgetPassword.TabIndex = 3;
            this.poisonLinkLabelForgetPassword.Text = "بازیابی رمز عبور ";
            this.poisonLinkLabelForgetPassword.UseSelectable = true;
            this.poisonLinkLabelForgetPassword.Click += new System.EventHandler(this.poisonLinkLabelForgetPassword_Click);
            // 
            // foreverButtonCancel
            // 
            this.foreverButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.foreverButtonCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.foreverButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverButtonCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverButtonCancel.Location = new System.Drawing.Point(12, 246);
            this.foreverButtonCancel.Name = "foreverButtonCancel";
            this.foreverButtonCancel.Rounded = false;
            this.foreverButtonCancel.Size = new System.Drawing.Size(184, 40);
            this.foreverButtonCancel.TabIndex = 2;
            this.foreverButtonCancel.Text = "لغو";
            this.foreverButtonCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverButtonCancel.Click += new System.EventHandler(this.foreverButtonCancel_Click);
            // 
            // foreverButtonLogin
            // 
            this.foreverButtonLogin.BackColor = System.Drawing.Color.Transparent;
            this.foreverButtonLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverButtonLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverButtonLogin.Location = new System.Drawing.Point(234, 246);
            this.foreverButtonLogin.Name = "foreverButtonLogin";
            this.foreverButtonLogin.Rounded = false;
            this.foreverButtonLogin.Size = new System.Drawing.Size(184, 40);
            this.foreverButtonLogin.TabIndex = 2;
            this.foreverButtonLogin.Text = "ورود ";
            this.foreverButtonLogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverButtonLogin.Click += new System.EventHandler(this.foreverButtonLogin_Click);
            // 
            // foreverLabel2
            // 
            this.foreverLabel2.AutoSize = true;
            this.foreverLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.foreverLabel2.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel2.Location = new System.Drawing.Point(370, 157);
            this.foreverLabel2.Name = "foreverLabel2";
            this.foreverLabel2.Size = new System.Drawing.Size(52, 19);
            this.foreverLabel2.TabIndex = 1;
            this.foreverLabel2.Text = "پسورد :";
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.foreverLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel1.Location = new System.Drawing.Point(347, 69);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(75, 19);
            this.foreverLabel1.TabIndex = 1;
            this.foreverLabel1.Text = "نام کاربری :";
            // 
            // foreverTextBoxPassWord
            // 
            this.foreverTextBoxPassWord.BackColor = System.Drawing.Color.Transparent;
            this.foreverTextBoxPassWord.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverTextBoxPassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverTextBoxPassWord.FocusOnHover = false;
            this.foreverTextBoxPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.foreverTextBoxPassWord.Location = new System.Drawing.Point(12, 190);
            this.foreverTextBoxPassWord.MaxLength = 32767;
            this.foreverTextBoxPassWord.Multiline = false;
            this.foreverTextBoxPassWord.Name = "foreverTextBoxPassWord";
            this.foreverTextBoxPassWord.ReadOnly = false;
            this.foreverTextBoxPassWord.Size = new System.Drawing.Size(410, 34);
            this.foreverTextBoxPassWord.TabIndex = 0;
            this.foreverTextBoxPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.foreverTextBoxPassWord.UseSystemPasswordChar = true;
            // 
            // foreverTextBoxUserName
            // 
            this.foreverTextBoxUserName.BackColor = System.Drawing.Color.Transparent;
            this.foreverTextBoxUserName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverTextBoxUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverTextBoxUserName.FocusOnHover = false;
            this.foreverTextBoxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.foreverTextBoxUserName.Location = new System.Drawing.Point(12, 103);
            this.foreverTextBoxUserName.MaxLength = 32767;
            this.foreverTextBoxUserName.Multiline = false;
            this.foreverTextBoxUserName.Name = "foreverTextBoxUserName";
            this.foreverTextBoxUserName.ReadOnly = false;
            this.foreverTextBoxUserName.Size = new System.Drawing.Size(410, 34);
            this.foreverTextBoxUserName.TabIndex = 0;
            this.foreverTextBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.foreverTextBoxUserName.UseSystemPasswordChar = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 336);
            this.Controls.Add(this.foreverForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.foreverForm1.ResumeLayout(false);
            this.foreverForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private ReaLTaiizor.Controls.ForeverButton foreverButtonCancel;
        private ReaLTaiizor.Controls.ForeverButton foreverButtonLogin;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.ForeverTextBox foreverTextBoxPassWord;
        private ReaLTaiizor.Controls.ForeverTextBox foreverTextBoxUserName;
        private ReaLTaiizor.Controls.PoisonLinkLabel poisonLinkLabelForgetPassword;
    }
}