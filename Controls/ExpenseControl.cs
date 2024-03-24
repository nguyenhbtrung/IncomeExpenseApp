using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseApp.Controls
{
    public partial class ExpenseControl : UserControl
    {
        private DatabaseConnector databaseConnector;

        private int userId;

        public int UserId { get => userId; set => userId = value; }
        public ExpenseControl()
        {
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            expenseCategoryComboBox.Items.Add("Thực phẩm");
            expenseCategoryComboBox.Items.Add("Hóa đơn");
            expenseCategoryComboBox.Items.Add("Giải trí");
            expenseCategoryComboBox.Items.Add("Du lịch");
            expenseCategoryComboBox.Items.Add("Y tế");
        }
        
        private void saveExpenseButton_Click(object sender, EventArgs e)
        {
            if (expenseNameText.Text == "")
            {
                notification.Text = "Chưa điền tên khoản chi!!";
                notification.Visible = true;
                return;
            }
            else if (expenseCategoryComboBox.Text == "")
            {
                notification.Text = "Chưa chọn danh mục!!";
                notification.Visible = true;
                return;
            }
            else if (expenseAmountText.Text == "")
            {
                notification.Text = "Chưa nhập số tiền!!";
                notification.Visible = true;
                return;
            }
            var isNumeric = int.TryParse(expenseAmountText.Text, out int n);
            if (isNumeric)
            {
                int Amount = int.Parse(expenseAmountText.Text);
                string date = expenseDatePicker.Value.ToString("yyyy-MM-dd");
                databaseConnector.ExecuteNonQuery($"insert into Expense values (N'{expenseNameText.Text}', N'{expenseCategoryComboBox.Text}', {Amount}, '{date}', N'{expenseDetailText.Text}', {userId})");
                MessageBox.Show("Lưu thành công!!", "Thông báo");
                expenseNameText.Clear();
                expenseCategoryComboBox.SelectedIndex = -1;
                expenseAmountText.Clear();
                expenseDetailText.Clear();
                notification.Visible = false;
                return;
            }
            else
            {
                notification.Text = "Nhập sai số tiền!!";
                notification.Visible = true;
                return;
            }
        }
        public void LoadData()
        {
            string query =
                "select epId, epName, epCategory, epAmount, format(epDate, 'dd/MM/yyyy') as epDateFormat " +
                $"from ExpensePlan where userId = {UserId} order by epDate desc";
            DataTable dataTable = databaseConnector.ExecuteDataTableQuery(query);
            //dataTable.Columns["epId"].ColumnName = "STT";
            dataTable.Columns["epName"].ColumnName = "Tên khoản chi";
            dataTable.Columns["epCategory"].ColumnName = "Danh mục";
            dataTable.Columns["epAmount"].ColumnName = "Số tiền";
            dataTable.Columns["epDateFormat"].ColumnName = "Ngày chi";

            expensePlanTable.DataSource = dataTable;
            expensePlanTable.Columns[1].Visible = false;
            
        }
        private void expensePlanTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in expensePlanTable.Rows)
            {
                expensePlanTable.Rows[row.Index].Cells[0].Value = (row.Index + 1).ToString();
            }
        }
    }
}
