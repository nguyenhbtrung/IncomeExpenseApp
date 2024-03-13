using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace IncomeExpenseApp
{
    public partial class Login : IncomeExpenseApp.LoginFrame
    {
        string username = "1";
        string pass = "1";

        public Login()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameField.Text == "")
            {
                notification.Text = "Chưa điền tài khoản!!";
                notification.Visible = true;
                return;
            }
            else if (passwordField.Text == "")
            {
                notification.Text = "Chưa điền mật khẩu!!";
                notification.Visible = true;
                return;
            }
            if (usernameField.Text == username && passwordField.Text == pass)
            {
                MainForm obj = new MainForm();
                //obj.ChangeTheSelectionDisplay(obj.FormIndex, obj.FormIndex);
                obj.Show();
                this.Hide();
            }
            else
            {
                notification.Text = "Sai tên tài khoản hoặc mật khẩu!!";
                notification.Visible = true;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            ShowRegister();
        }

        private void forgotPassButton_Click(object sender, EventArgs e)
        {
        }

    }
}
