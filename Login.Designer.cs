using System.Drawing;
using System.Windows.Forms;

namespace IncomeExpenseApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.CloseLogin = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.registerLabel);
            this.panel1.Controls.Add(this.appNameLabel);
            this.panel1.Controls.Add(this.appLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 461);
            this.panel1.TabIndex = 1;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(51, 410);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(190, 32);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "ĐĂNG KÍ NGAY";
            this.registerButton.UseVisualStyleBackColor = false;
            // 
            // registerLabel
            // 
            this.registerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerLabel.Location = new System.Drawing.Point(55, 370);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(182, 60);
            this.registerLabel.TabIndex = 2;
            this.registerLabel.Text = "Chưa có tài khoản?";
            this.registerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appNameLabel
            // 
            this.appNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.appNameLabel.Location = new System.Drawing.Point(28, 177);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(235, 60);
            this.appNameLabel.TabIndex = 1;
            this.appNameLabel.Text = "PHẦN MỀM QUẢN LÝ TÀI CHÍNH CÁ NHÂN";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appLogo
            // 
            this.appLogo.Image = global::IncomeExpenseApp.Properties.Resources.appLogo;
            this.appLogo.Location = new System.Drawing.Point(96, 59);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(100, 100);
            this.appLogo.TabIndex = 0;
            this.appLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(318, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.username.Location = new System.Drawing.Point(322, 153);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(125, 21);
            this.username.TabIndex = 3;
            this.username.Text = "Tên đăng nhập:";
            // 
            // usernameField
            // 
            this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.Location = new System.Drawing.Point(326, 177);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(228, 29);
            this.usernameField.TabIndex = 4;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(326, 294);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(228, 29);
            this.passwordField.TabIndex = 6;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.Location = new System.Drawing.Point(322, 270);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(83, 21);
            this.password.TabIndex = 5;
            this.password.Text = "Mật khẩu:";
            // 
            // CloseLogin
            // 
            this.CloseLogin.BackColor = System.Drawing.Color.Transparent;
            this.CloseLogin.BackgroundImage = global::IncomeExpenseApp.Properties.Resources.close;
            this.CloseLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.CloseLogin.FlatAppearance.BorderSize = 0;
            this.CloseLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.CloseLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.CloseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseLogin.ForeColor = System.Drawing.Color.Transparent;
            this.CloseLogin.Location = new System.Drawing.Point(543, 12);
            this.CloseLogin.Name = "CloseLogin";
            this.CloseLogin.Size = new System.Drawing.Size(29, 26);
            this.CloseLogin.TabIndex = 0;
            this.CloseLogin.UseVisualStyleBackColor = true;
            this.CloseLogin.Click += new System.EventHandler(this.CloseLogin_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginButton.Location = new System.Drawing.Point(373, 370);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(130, 44);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Đăng nhập";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseLogin);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseLogin;
        private Panel panel1;
        private Label label1;
        private Label username;
        private TextBox usernameField;
        private TextBox passwordField;
        private Label password;
        private PictureBox appLogo;
        private Label appNameLabel;
        private Button loginButton;
        private Label registerLabel;
        private Button registerButton;
    }
}