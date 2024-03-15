using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1;

namespace IncomeExpenseApp
{
    public partial class Login : IncomeExpenseApp.LoginFrame
    {
        private DatabaseConnector databaseConnector;

        public Login()
        {
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
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
            DataTable login = databaseConnector.ExecuteDataTableQuery($"select * from UserInfo");
            foreach(DataRow rows in login.Rows)
            {
                string username = rows["userName"].ToString();
                string password = rows["userPassword"].ToString();
                if (usernameField.Text == username && passwordField.Text == password)
                {
                    MainForm obj = new MainForm();
                    obj.Show();
                    this.Hide();
                    return;
                }

            }
            notification.Text = "Sai tên tài khoản hoặc mật khẩu!!";
            notification.Visible = true;
            
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
