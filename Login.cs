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
        public static string maXacThuc,id, username, password, email;
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
                username = rows["userName"].ToString();
                password = rows["userPassword"].ToString();
                if (usernameField.Text == username && passwordField.Text == password)
                {
                    isLogin = true;
                    int userId = Convert.ToInt32(rows["userId"]);
                    id = Convert.ToString(rows["userId"]);
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
            notification.Text = "Sai tên tài khoản hoặc mật khẩu!!";
            notification.Visible = true;
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            ShowRegister();
        }

        private void forgotPassButton_Click(object sender, EventArgs e)
        {
            if(usernameField.Text == "")
            {
                notification.Text = "Nhập tài khoản vào ô tên đăng nhập để lấy lại mật khẩu!!";
                notification.Visible = true;
            }else
            {
                DataTable login = databaseConnector.ExecuteDataTableQuery($"select * from UserInfo");
                foreach (DataRow rows in login.Rows)
                {
                    string username = rows["userName"].ToString();
                    if (usernameField.Text == username)
                    {
                        id = rows["userId"].ToString();
                        string email = rows["userEmail"].ToString();
                        maXacThuc = EmailSender.SendAuthenticationEmail(email, 1);
                        ShowAuthenticaon(1);
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
    }
}
