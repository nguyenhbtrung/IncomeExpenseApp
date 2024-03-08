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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(RoundedCornerGenerator.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void CloseRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(emailField.Text == "")
            {
                notification.Text = "Không được để trống Email!!";
                notification.Visible = true;
                return;
            }
            else if(usernameField.Text == "")
            {
                notification.Text = "Không được để trống\ntên đăng nhập!!";
                notification.Visible = true;
                return;
            }
            else if (passwordField.Text == "")
            {
                notification.Text = "Không được để trống\nmật khẩu!!";
                notification.Visible = true;
                return;
            }
            else if (password2Field.Text == "")
            {
                notification.Text = "Chưa nhập lại mật khẩu!!";
                notification.Visible = true;
                return;
            }
            if (emailField.Text == "huydangdo2003@gmail.com")
            {
                notification.Text = "Email đã được dùng!!";
                notification.Visible = true;
                return;
            }
            else if (usernameField.Text == "abc")
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
            else
            {
                notification.Text = "Tài khoản được tạo\nthành công!!";
                notification.Visible = true;
                return;
            } 
                
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new Login();
            obj.Show();
        }

        
    }
}
