using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IncomeExpenseApp
{
    public partial class Authentication : Form
    {
        private DatabaseConnector databaseConnector;
        int userId;
        public Authentication(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(codeField.Text.Equals(Register.maXacThuc) || codeField.Text.Equals(Login.maXacThuc))
            {
                if (userId == 0)
                {
                    databaseConnector.ExecuteNonQuery($"insert into UserInfo values (N'{Register.username}', N'{Register.password}', N'{Register.email}')");
                    MessageBox.Show("Tạo tài khoản thành công!!", "Thông báo");
                    this.Close();
                    Program.LoginForm.Show();
                }
                else
                {
                    this.Close();
                    ChangePassword obj = new ChangePassword(userId);
                    obj.ShowDialog();
                }
            }
            else notification.Visible = true;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
