using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using WindowsFormsApp1;

namespace IncomeExpenseApp.Controls
{
    public partial class UserInformationControl : UserControl
    {
        private int userId;
        private DatabaseConnector databaseConnector;

        public int UserId { get => userId; set => userId = value; }
        public UserInformationControl()
        {
            InitializeComponent();
            accountEmailText.Text = Login.email;
            accountNamePass.Text = Login.password;
            accountNamePass.PasswordChar = '*';
            accountNameText.Text = Login.username;
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            Login.maXacThuc = EmailSender.SendAuthenticationEmail(Login.email, 1);
            Authentication obj = new Authentication(1);
            obj.ShowDialog();
        }
    }
}
