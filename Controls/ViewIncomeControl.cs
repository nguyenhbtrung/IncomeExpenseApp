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
    public partial class ViewIncomeControl : UserControl
    {
        private int userId;
        private DatabaseConnector databaseConnector;

        public int UserId { get => userId; set => userId = value; }
        public ViewIncomeControl()
        {
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            String query = "select * from Income";
            DataSet dataSet = databaseConnector.ExecuteDataSetQuery(query);
            ViewIncomeTable.DataSource = dataSet.Tables[0];
            ViewIncomeTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ViewIncomeTable.RowsDefaultCellStyle.Font = new Font("Time New Roman", 10);
        }
    }
}
