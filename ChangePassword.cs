using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IncomeExpenseApp
{
    public partial class ChangePassword : IncomeExpenseApp.LoginFrame
    {
        private DatabaseConnector databaseConnector;

        public ChangePassword()
        {
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            passBox1.PasswordChar = '*';
            passBox2.PasswordChar = '*';
        }

        private void hidePassBox_Click(object sender, EventArgs e)
        {
            passBox1.PasswordChar = '*';
            showPassBox.BringToFront();
        }

        private void showPassBox_Click(object sender, EventArgs e)
        {
            passBox1.PasswordChar = '\0';
            hidePassBox.BringToFront();
        }

        private void hidePassBox2_Click(object sender, EventArgs e)
        {
            passBox2.PasswordChar = '*';
            showPassBox2.BringToFront();
        }

        private void showPassBox2_Click(object sender, EventArgs e)
        {
            passBox2.PasswordChar = '\0';
            hidePassBox2.BringToFront();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(passBox1.Text == "")
            {
                notification.Text = "Mật khẩu không được để trống!!";
                notification.Visible = true;
                return;
            }
            else if(passBox2.Text == "")
            {
                notification.Text = "Mật khẩu không được để trống!!";
                notification.Visible = true;
                return;
            }
            if(passBox1.Text == passBox2.Text)
            {
                string id = Login.id;
                databaseConnector.ExecuteDataTableQuery($"UPDATE UserInfo SET userPassword = {passBox1.Text} WHERE userId = {id};");
                MessageBox.Show("Đổi mật khẩu thành công!!", "Thông báo");
                if (Login.isLogin)
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                    Program.LoginForm.Show();
                }
            }
            else
            {
                notification.Text = "Mật khẩu nhập lại không trùng khớp!!";
                notification.Visible = true;
            }
        }
    }
}
