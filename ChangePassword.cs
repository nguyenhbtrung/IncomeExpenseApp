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
        public ChangePassword()
        {
            InitializeComponent();
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
    }
}
