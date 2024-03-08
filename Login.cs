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
    public partial class Login : Form
    {
        string username = "1";
        string pass = "1";

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(RoundedCornerGenerator.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void CloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameField.Text == username && passwordField.Text==pass)
            {
                DashBoardForm obj = new DashBoardForm();
                obj.ChangeTheSelectionDisplay(obj.FormIndex, obj.FormIndex);
                obj.Show();
                this.Hide();
            }
            else
            {
                notification.Text = "Tài khoản với pass là 1";
                notification.Visible = true;
            } 
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register obj = new Register();
            obj.Show();
        }

        private void forgotPassButton_Click(object sender, EventArgs e)
        {

        }
    }
}
