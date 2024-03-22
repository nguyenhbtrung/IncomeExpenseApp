using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseApp
{
    public partial class LoginFrame : Form
    {

        public LoginFrame()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(RoundedCornerGenerator.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SecondaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        public void ShowLogin()
        {
            this.Close();
            Program.LoginForm.Show();
        }

        public void ShowRegister()
        {
            this.Hide();
            Register obj = new Register();
            obj.Show();
        }
        public void ShowAuthenticaon(int a)
        {
            Authentication obj = new Authentication(a);
            obj.ShowDialog();
        }

        public bool IsEmpty(string textBox)
        {
            if (textBox == "")
            {
                return true;
            }
            else return false;
        }
    }
}
