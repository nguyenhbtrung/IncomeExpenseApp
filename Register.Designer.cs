using System.Drawing;
using System.Windows.Forms;

namespace IncomeExpenseApp
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginNotiLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.registerLabel = new System.Windows.Forms.Label();
            this.registerUsernameLabel = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.registerPasswordLabel = new System.Windows.Forms.Label();
            this.CloseLogin = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.notification = new System.Windows.Forms.Label();
            this.emailField = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.password2Field = new System.Windows.Forms.TextBox();
            this.password2Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.loginNotiLabel);
            this.panel1.Controls.Add(this.appNameLabel);
            this.panel1.Controls.Add(this.appLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 461);
            this.panel1.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Green;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(62, 417);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(167, 32);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "ĐĂNG NHẬP NGAY";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginNotiLabel
            // 
            this.loginNotiLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginNotiLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginNotiLabel.Location = new System.Drawing.Point(55, 370);
            this.loginNotiLabel.Name = "loginNotiLabel";
            this.loginNotiLabel.Size = new System.Drawing.Size(182, 60);
            this.loginNotiLabel.TabIndex = 2;
            this.loginNotiLabel.Text = "Đã có tài khoản?";
            this.loginNotiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registerLabel.Location = new System.Drawing.Point(354, 59);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(168, 47);
            this.registerLabel.TabIndex = 2;
            this.registerLabel.Text = "ĐĂNG KÍ";
            // 
            // registerUsernameLabel
            // 
            this.registerUsernameLabel.AutoSize = true;
            this.registerUsernameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUsernameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registerUsernameLabel.Location = new System.Drawing.Point(322, 170);
            this.registerUsernameLabel.Name = "registerUsernameLabel";
            this.registerUsernameLabel.Size = new System.Drawing.Size(125, 21);
            this.registerUsernameLabel.TabIndex = 3;
            this.registerUsernameLabel.Text = "Tên đăng nhập:";
            // 
            // usernameField
            // 
            this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.Location = new System.Drawing.Point(326, 194);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(228, 29);
            this.usernameField.TabIndex = 4;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(326, 250);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(228, 29);
            this.passwordField.TabIndex = 6;
            // 
            // registerPasswordLabel
            // 
            this.registerPasswordLabel.AutoSize = true;
            this.registerPasswordLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPasswordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registerPasswordLabel.Location = new System.Drawing.Point(322, 226);
            this.registerPasswordLabel.Name = "registerPasswordLabel";
            this.registerPasswordLabel.Size = new System.Drawing.Size(83, 21);
            this.registerPasswordLabel.TabIndex = 5;
            this.registerPasswordLabel.Text = "Mật khẩu:";
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
            this.CloseLogin.Click += new System.EventHandler(this.CloseRegister_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Green;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerButton.Location = new System.Drawing.Point(373, 385);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(130, 44);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Đăng kí";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // notification
            // 
            this.notification.BackColor = System.Drawing.Color.Transparent;
            this.notification.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification.ForeColor = System.Drawing.Color.Red;
            this.notification.Location = new System.Drawing.Point(325, 340);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(230, 43);
            this.notification.TabIndex = 9;
            this.notification.Text = "Thông báo";
            this.notification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notification.Visible = false;
            // 
            // emailField
            // 
            this.emailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailField.Location = new System.Drawing.Point(326, 138);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(228, 29);
            this.emailField.TabIndex = 11;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailLabel.Location = new System.Drawing.Point(322, 114);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(55, 21);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Email:";
            // 
            // password2Field
            // 
            this.password2Field.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2Field.Location = new System.Drawing.Point(326, 306);
            this.password2Field.Name = "password2Field";
            this.password2Field.Size = new System.Drawing.Size(228, 29);
            this.password2Field.TabIndex = 13;
            // 
            // password2Label
            // 
            this.password2Label.AutoSize = true;
            this.password2Label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password2Label.Location = new System.Drawing.Point(322, 282);
            this.password2Label.Name = "password2Label";
            this.password2Label.Size = new System.Drawing.Size(147, 21);
            this.password2Label.TabIndex = 12;
            this.password2Label.Text = "Nhập lại mật khẩu:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.password2Field);
            this.Controls.Add(this.password2Label);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.registerPasswordLabel);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.registerUsernameLabel);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseLogin);
            this.Controls.Add(this.notification);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
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
        private Label registerLabel;
        private Label registerUsernameLabel;
        private TextBox usernameField;
        private TextBox passwordField;
        private Label registerPasswordLabel;
        private PictureBox appLogo;
        private Label appNameLabel;
        private Button registerButton;
        private Label loginNotiLabel;
        private Button loginButton;
        private Label notification;
        private TextBox emailField;
        private Label emailLabel;
        private TextBox password2Field;
        private Label password2Label;
    }
}