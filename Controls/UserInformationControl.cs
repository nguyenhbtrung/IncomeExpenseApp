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
        public int UserId { get => userId; set => userId = value; }
        string email;
        private DatabaseConnector databaseConnector;
        public UserInformationControl()
        {
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            LoadData();
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            Login.maXacThuc = EmailSender.SendAuthenticationEmail(email, 1);
            Authentication obj = new Authentication(UserId);
            obj.ShowDialog();
        }
        private void LoadData()
        {
            DataTable data = databaseConnector.ExecuteDataTableQuery($"select userName, userPassword, userEmail from UserInfo WHERE userId = {UserId}");
            DataRow row = data.Rows[0];
            email = row["userEmail"].ToString();
            accountEmailText.Text = email;
            accountNamePass.Text = row["userPassword"].ToString();
            accountNameText.Text = row["userName"].ToString();
            accountNamePass.PasswordChar = '*';
        }
    }
}
