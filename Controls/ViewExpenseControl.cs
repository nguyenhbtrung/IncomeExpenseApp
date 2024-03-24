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

            ViewExpenseTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ViewExpenseTable.Columns[0].Width = 50;
            ViewExpenseTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ViewExpenseTable.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            ViewExpenseTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ViewExpenseTable.Columns[1].Width = 220;
            ViewExpenseTable.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            ViewExpenseTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ViewExpenseTable.Columns[2].Width = 220;
            ViewExpenseTable.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            ViewExpenseTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ViewExpenseTable.Columns[3].Width = 100;
            ViewExpenseTable.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ViewExpenseTable.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            ViewExpenseTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ViewExpenseTable.Columns[4].Width = 120;
            ViewExpenseTable.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ViewExpenseTable.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            ViewExpenseTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ViewExpenseTable.Columns[5].Width = 294;
            ViewExpenseTable.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void ViewExpenseTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void incomeCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
