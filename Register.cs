using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IncomeExpenseApp
{
    public partial class Register : IncomeExpenseApp.SecondaryForm
    {
        public Register()
        {
            InitializeComponent();
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (IsEmpty(emailField.Text))
            {
                notification.Text = "Không được để trống Email!!";
                notification.Visible = true;
                return;
            }
            else if (IsEmpty(usernameField.Text))
            {
                notification.Text = "Không được để trống\ntên đăng nhập!!";
                notification.Visible = true;
                return;
            }
            else if (IsEmpty(passwordField.Text))
            {
                notification.Text = "Không được để trống\nmật khẩu!!";
                notification.Visible = true;
                return;
            }
            else if (IsEmpty(password2Field.Text))
            {
                notification.Text = "Chưa nhập lại mật khẩu!!";
                notification.Visible = true;
                return;
            }
            if (emailField.Text == "huydangdo2003@gmail.com")
            {
                notification.Text = "Email đã được dùng!!";
                notification.Visible = true;
                return;
            }
            else if (usernameField.Text == "abc")
            {
                notification.Text = "Tên đăng nhập được dùng!!";
                notification.Visible = true;
                return;
            }
            else if (passwordField.Text != password2Field.Text)
            {
                notification.Text = "Mật khẩu nhập lại\nkhông giống!!";
                notification.Visible = true;
                return;
            }
            else
            {
                ShowAuthenticaon();
            }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

    }
}
