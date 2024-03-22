using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace IncomeExpenseApp
{
    
    public partial class Register : IncomeExpenseApp.LoginFrame
    {
        public static string maXacThuc;
        private DatabaseConnector databaseConnector;
        public static string username, password, email;

        public Register()
        {
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
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
            DataTable login = databaseConnector.ExecuteDataTableQuery($"select * from UserInfo");
            foreach (DataRow rows in login.Rows)
            {
                username = rows["userName"].ToString();
                email = rows["userEmail"].ToString();
                if (emailField.Text == email)
                {
                    notification.Text = "Email đã được dùng!!";
                    notification.Visible = true;
                    return;
                }
                else if (usernameField.Text == username)
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
                username = usernameField.Text;
                password = passwordField.Text;
                email = emailField.Text;
                maXacThuc = EmailSender.SendAuthenticationEmail(emailField.Text, 0);
                ShowAuthenticaon(0);
                this.Close();
            }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

    }
}
