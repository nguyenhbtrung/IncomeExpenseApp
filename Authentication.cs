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

        public Authentication()
        {
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (codeField.Text.Equals(Register.maXacThuc))
            {
                databaseConnector.ExecuteNonQuery($"insert into UserInfo values (N'{Register.username}', N'{Register.password}', N'{Register.email}')");
                MessageBox.Show("Tạo tài khoản thành công!!", "Thông báo");
                this.Close();
                Login obj = new Login();
                obj.Show();
            }
            else notification.Visible = true;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
