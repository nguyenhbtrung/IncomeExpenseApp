using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
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
        }

        public void LoadData()
        {
            //Kết nối với bảng dữ liệu tùy theo id tài khoản của người dùng, nạp dữ liệu vào đối tượng bảng để hiển thị trong phần mềm
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            String query = $"select * from dbo.Expense where userId = {UserId} ";
            DataTable dataTable = databaseConnector.ExecuteDataTableQuery(query);
            ViewExpenseTable.DataSource = dataTable;

            FormatDataGridView(ViewExpenseTable);
        }

        public void searchData(string valueToSearch)
        {
            //Kết nối với bảng dữ liệu tùy theo id tài khoản của người dùng, nạp dữ liệu vào đối tượng bảng, hiển thị bất kì những hàng thuộc bảng có dữ liệu trùng với dữ liệu người dùng nhập 
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            String query = $"select * from dbo.Expense where userId = {UserId} AND exName like N'%" + valueToSearch + "%'";
            DataTable dataTable = databaseConnector.ExecuteDataTableQuery(query);
            ViewExpenseTable.DataSource = dataTable;

            FormatDataGridView(ViewExpenseTable);
        }

        private void viewexpenseCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kết nối với bảng dữ liệu tùy theo id tài khoản của người dùng, nạp dữ liệu vào đối tượng bảng, hiển thị bất kì những hàng thuộc bảng có dữ liệu trùng với dữ liệu người dùng nhập 
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            String values = viewexpenseCategoryComboBox.Text.ToString();
            String query = $"select * from dbo.Expense where userId = {UserId} AND exCategory = N'{values}'";
            DataTable dataTable = databaseConnector.ExecuteDataTableQuery(query);
            ViewExpenseTable.DataSource = dataTable;

            FormatDataGridView(ViewExpenseTable);
        }

        private void SearchExpenseButton_Click(object sender, EventArgs e)
        {
            //Chuyển văn bản người dùng nhập thành định dạng String, xử dụng dữ liệu này làm điều kiện để truy xuất câu lệnh SQL trong hàm searchData
            string valueToSearch = expenseNameText.Text.ToString();
            searchData(valueToSearch);
        }

        private void RefreshExpense(object sender, EventArgs e)
        {
            //Làm sạch dữ liệu trong các trường cho phép điền, làm mới bảng hiển thị
            viewexpenseCategoryComboBox.Text = "";
            expenseNameText.Text = "";
            LoadData();
        }

        private void ViewExpenseTable_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Lấy dữ liệu thuộc cột STT tại dòng mà người dùng bấm chuột phải vào, chuyển sang định dạng Int (số nguyên)
            if(e.Button == MouseButtons.Right)
            {
                delete_id = Convert.ToInt32(ViewExpenseTable.Rows[e.RowIndex].Cells["exID"].Value.ToString());
                this.contextMenuStrip1.Show(this.ViewExpenseTable, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            //Sử dụng dữ liệu lấy được từ hành động Click, đối chiếu theo bảng thuộc cơ sở dữ liệu để thực hiện câu lệnh SQL
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            string query = "delete from dbo.expense where exId =" + delete_id + "";
            databaseConnector.ExecuteNonQuery(query);
            MessageBox.Show("Xóa lịch sử thành công");
            LoadData();
        }

        private void FormatDataGridView(DataGridView dataGridView)
        {
            // Đặt tên cột thuộc bảng
            dataGridView.Columns["exId"].HeaderText = "ID";
            dataGridView.Columns["exName"].HeaderText = "Tên khoản chi";
            dataGridView.Columns["exCategory"].HeaderText = "Danh mục";
            dataGridView.Columns["exAmount"].HeaderText = "Số tiền";
            dataGridView.Columns["exDate"].HeaderText = "Thời gian";
            dataGridView.Columns["exDesciption"].HeaderText = "Chi tiết";
            dataGridView.Columns["userId"].Visible = false;

            // Tùy chỉnh hiển thị kích thước cột, kích thước văn bản trong cột
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns[1].Width = 220;
            dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns[2].Width = 220;
            dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns[4].Width = 120;
            dataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns[5].Width = 294;
            dataGridView.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.RowsDefaultCellStyle.Font = new Font("Time New Roman", 10);

            viewexpenseCategoryComboBox.Items.Clear();
            //Kết nối với bảng dữ liệu tùy theo id tài khoản của người dùng
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);

            //Duyệt cột danh mục trong cơ sở dữ liệu, nạp vào trong ComboBox, mục nào đã tồn tại thì không nạp
            string query = $"select distinct exCategory from dbo.Expense";

            //Duyệt cột danh mục trong cơ sở dữ liệu, nạp vào trong ComboBox, mục nào đã tồn tại thì không nạp
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
                            viewexpenseCategoryComboBox.Items.Add(value);
                        }
                    }
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ViewExpenseTable.ReadOnly = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            SqlConnection connection = new SqlConnection(Program.DbConnectionString);
            for (int item = 0; item <= ViewExpenseTable.Rows.Count - 1; item++)
            {
                SqlCommand cmd = new SqlCommand($"update dbo.Expense set exName=@exName, exCategory=@exCategory, exAmount=@exAmount, exDate=@exDate, exDesciption=@exDesciption where exId=@exId", connection);
                cmd.Parameters.AddWithValue("@exName", ViewExpenseTable.Rows[item].Cells[1].Value);
                cmd.Parameters.AddWithValue("@exCategory", ViewExpenseTable.Rows[item].Cells[2].Value);
                cmd.Parameters.AddWithValue("@exAmount", ViewExpenseTable.Rows[item].Cells[3].Value);
                cmd.Parameters.AddWithValue("@exDate", ViewExpenseTable.Rows[item].Cells[4].Value);
                cmd.Parameters.AddWithValue("@exDesciption", ViewExpenseTable.Rows[item].Cells[5].Value);
                cmd.Parameters.AddWithValue("exId", ViewExpenseTable.Rows[item].Cells[0].Value);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                ViewExpenseTable.ReadOnly = true;
            }
        }
    }
}
