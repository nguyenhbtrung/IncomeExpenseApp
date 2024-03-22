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
            this.forgotPassButton = new System.Windows.Forms.Button();
            this.notification = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerLabel = new System.Windows.Forms.Label();
            this.hidePassBox = new System.Windows.Forms.PictureBox();
            this.showPassBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hidePassBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            // 
            // forgotPassButton
            // 
            this.forgotPassButton.BackColor = System.Drawing.Color.Transparent;
            this.forgotPassButton.FlatAppearance.BorderSize = 0;
            this.forgotPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotPassButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.forgotPassButton.Location = new System.Drawing.Point(373, 395);
            this.forgotPassButton.Name = "forgotPassButton";
            this.forgotPassButton.Size = new System.Drawing.Size(130, 32);
            this.forgotPassButton.TabIndex = 4;
            this.forgotPassButton.Text = "Quên mật khẩu?";
            this.forgotPassButton.UseVisualStyleBackColor = false;
            this.forgotPassButton.Click += new System.EventHandler(this.forgotPassButton_Click);
            // 
            // notification
            // 
            this.notification.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification.ForeColor = System.Drawing.Color.Red;
            this.notification.Location = new System.Drawing.Point(317, 289);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(242, 43);
            this.notification.TabIndex = 28;
            this.notification.Text = "Thông báo";
            this.notification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notification.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginButton.Location = new System.Drawing.Point(373, 345);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(130, 44);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Đăng nhập";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(324, 246);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(228, 29);
            this.passwordField.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordLabel.Location = new System.Drawing.Point(320, 222);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(83, 21);
            this.passwordLabel.TabIndex = 25;
            this.passwordLabel.Text = "Mật khẩu:";
            // 
            // usernameField
            // 
            this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.Location = new System.Drawing.Point(324, 163);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(228, 29);
            this.usernameField.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usernameLabel.Location = new System.Drawing.Point(320, 139);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(125, 21);
            this.usernameLabel.TabIndex = 21;
            this.usernameLabel.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(320, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 47);
            this.label1.TabIndex = 19;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(79, 410);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(134, 32);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "ĐĂNG KÍ NGAY";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.registerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerLabel.Location = new System.Drawing.Point(55, 370);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(182, 60);
            this.registerLabel.TabIndex = 20;
            this.registerLabel.Text = "Chưa có tài khoản?";
            this.registerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hidePassBox
            // 
            this.hidePassBox.BackColor = System.Drawing.Color.Transparent;
            this.hidePassBox.Image = global::IncomeExpenseApp.Properties.Resources.HidePass;
            this.hidePassBox.Location = new System.Drawing.Point(524, 247);
            this.hidePassBox.Name = "hidePassBox";
            this.hidePassBox.Size = new System.Drawing.Size(27, 27);
            this.hidePassBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidePassBox.TabIndex = 29;
            this.hidePassBox.TabStop = false;
            this.hidePassBox.Click += new System.EventHandler(this.hidePassBox_Click);
            // 
            // showPassBox
            // 
            this.showPassBox.BackColor = System.Drawing.Color.Transparent;
            this.showPassBox.Image = global::IncomeExpenseApp.Properties.Resources.ShowPass;
            this.showPassBox.Location = new System.Drawing.Point(524, 247);
            this.showPassBox.Name = "showPassBox";
            this.showPassBox.Size = new System.Drawing.Size(27, 27);
            this.showPassBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPassBox.TabIndex = 30;
            this.showPassBox.TabStop = false;
            this.showPassBox.Click += new System.EventHandler(this.showPassBox_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.showPassBox);
            this.Controls.Add(this.hidePassBox);
            this.Controls.Add(this.forgotPassButton);
            this.Controls.Add(this.notification);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.registerLabel);
            this.Name = "Login";
            this.Controls.SetChildIndex(this.registerLabel, 0);
            this.Controls.SetChildIndex(this.registerButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.usernameLabel, 0);
            this.Controls.SetChildIndex(this.usernameField, 0);
            this.Controls.SetChildIndex(this.passwordLabel, 0);
            this.Controls.SetChildIndex(this.passwordField, 0);
            this.Controls.SetChildIndex(this.loginButton, 0);
            this.Controls.SetChildIndex(this.notification, 0);
            this.Controls.SetChildIndex(this.forgotPassButton, 0);
            this.Controls.SetChildIndex(this.hidePassBox, 0);
            this.Controls.SetChildIndex(this.showPassBox, 0);
            this.Controls.SetChildIndex(this.CloseButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.hidePassBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forgotPassButton;
        private System.Windows.Forms.Label notification;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.PictureBox hidePassBox;
        private System.Windows.Forms.PictureBox showPassBox;
    }
}
