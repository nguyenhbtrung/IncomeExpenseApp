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

            ViewIncomeTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ViewIncomeTable.RowsDefaultCellStyle.Font = new Font("Time New Roman", 10);

            viewincomeCategoryComboBox.Items.Add("Thu nhập thường xuyên");
            viewincomeCategoryComboBox.Items.Add("Thu nhập bổ sung");
            viewincomeCategoryComboBox.Items.Add("Thu nhập phụ");
            viewincomeCategoryComboBox.Items.Add("Đầu tư");
            viewincomeCategoryComboBox.Items.Add("Thu nhập không làm việc");
        }

        public void LoadData()
        {
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            String query = "select * from dbo.Income where userId = UserId";
            DataTable dataTable = databaseConnector.ExecuteDataTableQuery(query);
            ViewIncomeTable.DataSource = dataTable;

            dataTable.Columns["incId"].ColumnName = "STT";
            dataTable.Columns["incName"].ColumnName = "Tên khoản thu";
            dataTable.Columns["incCategory"].ColumnName = "Danh mục";
            dataTable.Columns["incAmount"].ColumnName = "Số tiền";
            dataTable.Columns["incDate"].ColumnName = "Thời gian";
            dataTable.Columns["incDesciption"].ColumnName = "Chi tiết";
            ViewIncomeTable.Columns["userId"].Visible = false;

            ViewIncomeTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ViewIncomeTable.Columns[0].Width = 50;
            ViewIncomeTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ViewIncomeTable.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            ViewIncomeTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ViewIncomeTable.Columns[1].Width = 220;
            ViewIncomeTable.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            ViewIncomeTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ViewIncomeTable.Columns[2].Width = 220;
            ViewIncomeTable.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            ViewIncomeTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ViewIncomeTable.Columns[3].Width = 100;
            ViewIncomeTable.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ViewIncomeTable.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            ViewIncomeTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ViewIncomeTable.Columns[4].Width = 120;
            ViewIncomeTable.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ViewIncomeTable.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            ViewIncomeTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ViewIncomeTable.Columns[5].Width = 294;
            ViewIncomeTable.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        private void viewincomeCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            string category = viewincomeCategoryComboBox.SelectedItem.ToString();

            String query = "select * from dbo.Income where userId = UserId AND incCategory = N'{category}' ";
            DataTable dataTable = databaseConnector.ExecuteDataTableQuery(query);
            ViewIncomeTable.DataSource = dataTable;

            dataTable.Columns["incId"].ColumnName = "STT";
            dataTable.Columns["incName"].ColumnName = "Tên khoản thu";
            dataTable.Columns["incCategory"].ColumnName = "Danh mục";
            dataTable.Columns["incAmount"].ColumnName = "Số tiền";
            dataTable.Columns["incDate"].ColumnName = "Thời gian";
            dataTable.Columns["incDesciption"].ColumnName = "Chi tiết";
            ViewIncomeTable.Columns["userId"].Visible = false;


        }
    }
}
