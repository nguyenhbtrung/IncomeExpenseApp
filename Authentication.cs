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
        int a;
        public Authentication(int a)
        {
            this.a = a;
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (codeField.Text.Equals(Register.maXacThuc))
                {
                    databaseConnector.ExecuteNonQuery($"insert into UserInfo values (N'{Register.username}', N'{Register.password}', N'{Register.email}')");
                    MessageBox.Show("Tạo tài khoản thành công!!", "Thông báo");
                    this.Close();
                    Program.LoginForm.Show();
                }
                else notification.Visible = true;
            }
            else
            {
                if (codeField.Text.Equals(Login.maXacThuc))
                {
                    this.Close();
                    ChangePassword obj = new ChangePassword();
                    obj.ShowDialog();
                }
                else notification.Visible = true;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
