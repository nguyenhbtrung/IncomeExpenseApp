namespace IncomeExpenseApp.Controls
{
    partial class UserInformationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.accountEmailText = new System.Windows.Forms.TextBox();
            this.accountNameText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.accountNamePass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(290, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(441, 50);
            this.label10.TabIndex = 30;
            this.label10.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // accountEmailText
            // 
            this.accountEmailText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountEmailText.Location = new System.Drawing.Point(188, 297);
            this.accountEmailText.Name = "accountEmailText";
            this.accountEmailText.ReadOnly = true;
            this.accountEmailText.Size = new System.Drawing.Size(250, 32);
            this.accountEmailText.TabIndex = 39;
            // 
            // accountNameText
            // 
            this.accountNameText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameText.Location = new System.Drawing.Point(188, 183);
            this.accountNameText.Name = "accountNameText";
            this.accountNameText.ReadOnly = true;
            this.accountNameText.Size = new System.Drawing.Size(250, 32);
            this.accountNameText.TabIndex = 38;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(184, 271);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(66, 23);
            this.emailLabel.TabIndex = 37;
            this.emailLabel.Text = "Email:";
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameLabel.Location = new System.Drawing.Point(184, 157);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(128, 23);
            this.accountNameLabel.TabIndex = 36;
            this.accountNameLabel.Text = "Tên tài khoản:";
            // 
            // accountNamePass
            // 
            this.accountNamePass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNamePass.Location = new System.Drawing.Point(606, 183);
            this.accountNamePass.Name = "accountNamePass";
            this.accountNamePass.ReadOnly = true;
            this.accountNamePass.Size = new System.Drawing.Size(250, 32);
            this.accountNamePass.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mật khẩu:";
            // 
            // ChangePass
            // 
            this.ChangePass.BackColor = System.Drawing.Color.Cyan;
            this.ChangePass.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePass.Location = new System.Drawing.Point(606, 278);
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.Size = new System.Drawing.Size(250, 57);
            this.ChangePass.TabIndex = 42;
            this.ChangePass.Text = "Đổi mật khẩu";
            this.ChangePass.UseVisualStyleBackColor = false;
            this.ChangePass.Click += new System.EventHandler(this.ChangePass_Click);
            // 
            // UserInformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChangePass);
            this.Controls.Add(this.accountNamePass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountEmailText);
            this.Controls.Add(this.accountNameText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.accountNameLabel);
            this.Controls.Add(this.label10);
            this.Name = "UserInformationControl";
            this.Size = new System.Drawing.Size(1022, 623);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox accountEmailText;
        private System.Windows.Forms.TextBox accountNameText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.TextBox accountNamePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangePass;
    }
}
