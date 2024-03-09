using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IncomeExpenseApp
{
    public partial class Login : IncomeExpenseApp.SecondaryForm
    {
        string username = "1";
        string pass = "1";

        public Login()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameField.Text == username && passwordField.Text == pass)
            {
                DashBoardForm obj = new DashBoardForm();
                obj.ChangeTheSelectionDisplay(obj.FormIndex, obj.FormIndex);
                obj.Show();
                this.Hide();
            }
            else
            {
                notification.Text = "Tài khoản với pass là 1";
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
