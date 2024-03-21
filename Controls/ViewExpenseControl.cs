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
    public partial class ViewExpenseControl : UserControl
    {
        private int userId;
        private DatabaseConnector databaseConnector;

        public int UserId { get => userId; set => userId = value; }
        public ViewExpenseControl()
        {
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            String query = "select * from Expense";
            DataSet dataSet = databaseConnector.ExecuteDataSetQuery(query);
            ViewExpenseTable.DataSource = dataSet.Tables[0];

            ViewExpenseTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ViewExpenseTable.RowsDefaultCellStyle.Font = new Font("Time New Roman", 10);
        }

        private void ViewExpenseTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
