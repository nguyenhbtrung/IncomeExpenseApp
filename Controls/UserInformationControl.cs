using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
