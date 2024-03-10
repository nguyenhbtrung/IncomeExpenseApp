using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace IncomeExpenseApp
{
    public partial class TestSendEmail : Form
    {
        private string code;
        public TestSendEmail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string toAddress = textBox1.Text;
            code = EmailSender.SendAuthenticationEmail(toAddress, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == code)
            {
                MessageBox.Show("Xác thực thành công");
            }
            else
            {
                MessageBox.Show("Sai mã xác thực");
            }
        }
    }
}
