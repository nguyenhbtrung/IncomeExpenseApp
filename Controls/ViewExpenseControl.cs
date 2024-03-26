using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        int delete_id;
        public int UserId { get => userId; set => userId = value; }
        public ViewExpenseControl()
        {
            InitializeComponent();
            //Kết nối với bảng dữ liệu tùy theo id tài khoản của người dùng
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);

            //Duyệt cột danh mục trong cơ sở dữ liệu, nạp vào trong ComboBox, mục nào đã tồn tại thì không nạp
            string query = $"select distinct exCategory from dbo.Expense";
            HashSet<string> uniqueValues = new HashSet<string>();

            using (SqlConnection connection = new SqlConnection(Program.DbConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader.GetString(0);
                            if (!uniqueValues.Contains(value))
                            {
                                viewexpenseCategoryComboBox.Items.Add(value);
                                uniqueValues.Add(value);
                            }
                        }
                    }
                }
            }

            //Căn chỉnh hiển thị bảng
            ViewExpenseTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ViewExpenseTable.RowsDefaultCellStyle.Font = new Font("Time New Roman", 10);

        }
        public void LoadData()
        {
            //Kết nối với bảng dữ liệu tùy theo id tài khoản của người dùng, nạp dữ liệu vào đối tượng bảng để hiển thị trong phần mềm
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            String query = $"select * from dbo.Expense where userId = {UserId} ";
            DataTable dataTable = databaseConnector.ExecuteDataTableQuery(query);
            ViewExpenseTable.DataSource = dataTable;

            //Đặt tên cột thuộc bảng
            dataTable.Columns["exId"].ColumnName = "STT";
            dataTable.Columns["exName"].ColumnName = "Tên khoản chi";
            dataTable.Columns["exCategory"].ColumnName = "Danh mục";
            dataTable.Columns["exAmount"].ColumnName = "Số tiền";
            dataTable.Columns["exDate"].ColumnName = "Thời gian";
            dataTable.Columns["exDesciption"].ColumnName = "Chi tiết";
            ViewExpenseTable.Columns["userId"].Visible = false;

            //Tùy chỉnh hiển thị kích thước cột, kích thước văn bản trong cột
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

            ViewExpenseTable.EnableHeadersVisualStyles = false;
        }

        public void searchData(string valueToSearch)
        {
            //Kết nối với bảng dữ liệu tùy theo id tài khoản của người dùng, nạp dữ liệu vào đối tượng bảng để hiển thị trong phần mềm với điều kiện cho trước
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            String query = $"select * from dbo.Expense where userId = {UserId} AND CONCAT(exName, exCategory, exAmount, exDate, exDesciption) like N'%" + valueToSearch + "%'";
            DataTable dataTable = databaseConnector.ExecuteDataTableQuery(query);
            ViewExpenseTable.DataSource = dataTable;

            //Đặt tên cột thuộc bảng
            dataTable.Columns["exId"].ColumnName = "STT";
            dataTable.Columns["exName"].ColumnName = "Tên khoản thu";
            dataTable.Columns["exCategory"].ColumnName = "Danh mục";
            dataTable.Columns["exAmount"].ColumnName = "Số tiền";
            dataTable.Columns["exDate"].ColumnName = "Thời gian";
            dataTable.Columns["exDesciption"].ColumnName = "Chi tiết";
            ViewExpenseTable.Columns["userId"].Visible = false;

            //Tùy chỉnh hiển thị kích thước cột, kích thước văn bản trong cột
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

        private void viewexpenseCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kết nối với bảng dữ liệu tùy theo id tài khoản của người dùng, nạp dữ liệu vào đối tượng bảng để hiển thị trong phần mềm với điều kiện cho trước
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            String values = viewexpenseCategoryComboBox.Text.ToString();
            String query = $"select * from dbo.Expense where userId = {UserId} AND CONCAT(exName, exCategory, exAmount, exDate, exDesciption) like N'%" + values + "%'";
            DataTable dataTable = databaseConnector.ExecuteDataTableQuery(query);
            ViewExpenseTable.DataSource = dataTable;

            //Đặt tên cột thuộc bảng
            dataTable.Columns["exId"].ColumnName = "STT";
            dataTable.Columns["exName"].ColumnName = "Tên khoản thu";
            dataTable.Columns["exCategory"].ColumnName = "Danh mục";
            dataTable.Columns["exAmount"].ColumnName = "Số tiền";
            dataTable.Columns["exDate"].ColumnName = "Thời gian";
            dataTable.Columns["exDesciption"].ColumnName = "Chi tiết";
            ViewExpenseTable.Columns["userId"].Visible = false;

            //Tùy chỉnh hiển thị kích thước cột, kích thước văn bản trong cột
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

        private void SearchExpenseButton_Click(object sender, EventArgs e)
        {
            string valueToSearch = expenseNameText.Text.ToString();
            searchData(valueToSearch);
        }

        private void RefreshExpense(object sender, EventArgs e)
        {
            viewexpenseCategoryComboBox.Text = "";
            expenseNameText.Text = "";
            LoadData();
        }

        private void ViewExpenseTable_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                delete_id = Convert.ToInt32(ViewExpenseTable.Rows[e.RowIndex].Cells["STT"].Value.ToString());
                this.contextMenuStrip1.Show(this.ViewExpenseTable, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            string query = "delete from dbo.expense where exId =" + delete_id + "";
            databaseConnector.ExecuteNonQuery(query);
            MessageBox.Show("Xóa lịch sử thành công");
            LoadData();
        }
    }
}
