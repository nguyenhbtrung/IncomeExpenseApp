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
        public static string maXacThuc, username, password, email;
        public static int userId;
        public static bool isLogin = false;
        public Login()
        {
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            passwordField.PasswordChar = '*';
        }
        private void loginButton_Click(object sender, EventArgs e)
        {

            if (usernameField.Text == "")
            {
                showNoti("Chưa điền tài khoản!!");
            }
            else if (passwordField.Text == "")
            {
                showNoti("Chưa điền mật khẩu!!");
            }
            DataTable login = databaseConnector.ExecuteDataTableQuery($"select * from UserInfo");
            foreach(DataRow rows in login.Rows)
            {
                username = rows["userName"].ToString();
                password = rows["userPassword"].ToString();
                if (usernameField.Text == username && passwordField.Text == password)
                {
                    isLogin = true;
                    userId = Convert.ToInt32(rows["userId"]);
                    email = rows["userEmail"].ToString();
                    MainForm obj = new MainForm(userId);
                    this.Hide();
                    usernameField.Clear();
                    passwordField.Clear();
                    notification.Visible = false;
                    obj.Show();
                    return;
                }

            }
            showNoti("Sai tên tài khoản hoặc\nmật khẩu!!");
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            ShowRegister();
        }

        private void forgotPassButton_Click(object sender, EventArgs e)
        {
            if(usernameField.Text == "")
            {
                showNoti("Nhập tài khoản vào ô tên đăng nhập để lấy lại mật khẩu!!");
            }
            else
            {
                DataTable login = databaseConnector.ExecuteDataTableQuery($"select * from UserInfo");
                foreach (DataRow rows in login.Rows)
                {
                    string username = rows["userName"].ToString();
                    if (usernameField.Text == username)
                    {
                        userId = Convert.ToInt32(rows["userId"]);
                        string email = rows["userEmail"].ToString();
                        maXacThuc = EmailSender.SendAuthenticationEmail(email, 1);
                        ShowAuthenticaon(userId);
                        this.Hide();
                    }

                }
            }
        }

        private void hidePassBox_Click(object sender, EventArgs e)
        {
            passwordField.PasswordChar = '*';
            showPassBox.BringToFront();
        }

        private void showPassBox_Click(object sender, EventArgs e)
        {
            passwordField.PasswordChar = '\0';
            hidePassBox.BringToFront();
        }

        private void showNoti(string text)
        {
            notification.Text = text;
            notification.Visible = true;
            return;
        }
    }
}
