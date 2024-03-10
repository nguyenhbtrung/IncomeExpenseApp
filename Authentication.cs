using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseApp
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(Register.maXacThuc+"    "+textLabel.Text);
            if(codeField.Text.Equals(Register.maXacThuc))
            {
                MessageBox.Show("Tạo tài khoản thành công!!");
                this.Close();
                Login obj = new Login();
                obj.Show();
            }
        }
    }
}
