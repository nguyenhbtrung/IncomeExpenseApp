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

            ViewExpenseTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ViewExpenseTable.RowsDefaultCellStyle.Font = new Font("Time New Roman", 10);

        }
        public void LoadData()
        {
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            String query = "select * from dbo.Expense where userId = UserId ";
            DataTable dataTable = databaseConnector.ExecuteDataTableQuery(query);
            ViewExpenseTable.DataSource = dataTable;
            dataTable.Columns["exId"].ColumnName = "STT";
            dataTable.Columns["exName"].ColumnName = "Tên khoản chi";
            dataTable.Columns["exCategory"].ColumnName = "Danh mục";
            dataTable.Columns["exAmount"].ColumnName = "Số tiền";
            dataTable.Columns["exDate"].ColumnName = "Thời gian";
            dataTable.Columns["exDesciption"].ColumnName = "Chi tiết";
            ViewExpenseTable.Columns["userId"].Visible = false;
        }

        private void ViewExpenseTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void incomeCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
