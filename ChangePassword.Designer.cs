namespace IncomeExpenseApp
{
    partial class ChangePassword
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
            this.passBox2 = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passBox1 = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notification = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.showPassBox2 = new System.Windows.Forms.PictureBox();
            this.hidePassBox2 = new System.Windows.Forms.PictureBox();
            this.showPassBox = new System.Windows.Forms.PictureBox();
            this.hidePassBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.showPassBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePassBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePassBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            // 
            // passBox2
            // 
            this.passBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox2.Location = new System.Drawing.Point(324, 260);
            this.passBox2.Name = "passBox2";
            this.passBox2.Size = new System.Drawing.Size(228, 29);
            this.passBox2.TabIndex = 27;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordLabel.Location = new System.Drawing.Point(320, 236);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(180, 21);
            this.passwordLabel.TabIndex = 30;
            this.passwordLabel.Text = "Nhập lại mật khẩu mới:";
            // 
            // passBox1
            // 
            this.passBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox1.Location = new System.Drawing.Point(324, 177);
            this.passBox1.Name = "passBox1";
            this.passBox1.Size = new System.Drawing.Size(228, 29);
            this.passBox1.TabIndex = 26;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usernameLabel.Location = new System.Drawing.Point(320, 153);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(116, 21);
            this.usernameLabel.TabIndex = 29;
            this.usernameLabel.Text = "Mật khẩu mới:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(322, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 94);
            this.label1.TabIndex = 28;
            this.label1.Text = "THAY ĐỔI MẬT KHẨU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notification
            // 
            this.notification.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification.ForeColor = System.Drawing.Color.Red;
            this.notification.Location = new System.Drawing.Point(317, 315);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(242, 43);
            this.notification.TabIndex = 32;
            this.notification.Text = "Thông báo";
            this.notification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notification.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginButton.Location = new System.Drawing.Point(354, 361);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(160, 44);
            this.loginButton.TabIndex = 31;
            this.loginButton.Text = "Đổi mật khẩu";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // showPassBox2
            // 
            this.showPassBox2.BackColor = System.Drawing.Color.Transparent;
            this.showPassBox2.Image = global::IncomeExpenseApp.Properties.Resources.ShowPass;
            this.showPassBox2.Location = new System.Drawing.Point(524, 261);
            this.showPassBox2.Name = "showPassBox2";
            this.showPassBox2.Size = new System.Drawing.Size(27, 27);
            this.showPassBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPassBox2.TabIndex = 33;
            this.showPassBox2.TabStop = false;
            this.showPassBox2.Click += new System.EventHandler(this.showPassBox2_Click);
            // 
            // hidePassBox2
            // 
            this.hidePassBox2.BackColor = System.Drawing.Color.Transparent;
            this.hidePassBox2.Image = global::IncomeExpenseApp.Properties.Resources.HidePass;
            this.hidePassBox2.Location = new System.Drawing.Point(524, 261);
            this.hidePassBox2.Name = "hidePassBox2";
            this.hidePassBox2.Size = new System.Drawing.Size(27, 27);
            this.hidePassBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidePassBox2.TabIndex = 34;
            this.hidePassBox2.TabStop = false;
            this.hidePassBox2.Click += new System.EventHandler(this.hidePassBox2_Click);
            // 
            // showPassBox
            // 
            this.showPassBox.BackColor = System.Drawing.Color.Transparent;
            this.showPassBox.Image = global::IncomeExpenseApp.Properties.Resources.ShowPass;
            this.showPassBox.Location = new System.Drawing.Point(524, 178);
            this.showPassBox.Name = "showPassBox";
            this.showPassBox.Size = new System.Drawing.Size(27, 27);
            this.showPassBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPassBox.TabIndex = 35;
            this.showPassBox.TabStop = false;
            this.showPassBox.Click += new System.EventHandler(this.showPassBox_Click);
            // 
            // hidePassBox
            // 
            this.hidePassBox.BackColor = System.Drawing.Color.Transparent;
            this.hidePassBox.Image = global::IncomeExpenseApp.Properties.Resources.HidePass;
            this.hidePassBox.Location = new System.Drawing.Point(524, 178);
            this.hidePassBox.Name = "hidePassBox";
            this.hidePassBox.Size = new System.Drawing.Size(27, 27);
            this.hidePassBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidePassBox.TabIndex = 36;
            this.hidePassBox.TabStop = false;
            this.hidePassBox.Click += new System.EventHandler(this.hidePassBox_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.showPassBox);
            this.Controls.Add(this.hidePassBox);
            this.Controls.Add(this.showPassBox2);
            this.Controls.Add(this.hidePassBox2);
            this.Controls.Add(this.notification);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passBox2);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passBox1);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.Controls.SetChildIndex(this.CloseButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.usernameLabel, 0);
            this.Controls.SetChildIndex(this.passBox1, 0);
            this.Controls.SetChildIndex(this.passwordLabel, 0);
            this.Controls.SetChildIndex(this.passBox2, 0);
            this.Controls.SetChildIndex(this.loginButton, 0);
            this.Controls.SetChildIndex(this.notification, 0);
            this.Controls.SetChildIndex(this.hidePassBox2, 0);
            this.Controls.SetChildIndex(this.showPassBox2, 0);
            this.Controls.SetChildIndex(this.hidePassBox, 0);
            this.Controls.SetChildIndex(this.showPassBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.showPassBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePassBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePassBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passBox2;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passBox1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label notification;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox showPassBox2;
        private System.Windows.Forms.PictureBox hidePassBox2;
        private System.Windows.Forms.PictureBox showPassBox;
        private System.Windows.Forms.PictureBox hidePassBox;
    }
}
