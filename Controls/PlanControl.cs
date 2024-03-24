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
    public partial class PlanControl : UserControl
    {
        private DatabaseConnector databaseConnector;

        private int userId;

        public int UserId { get => userId; set => userId = value; }
        public PlanControl()
        {
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
        }

        public void LoadData()
        {
            LoadBudgetPanel();
            LoadTable();
        }

        private void LoadTable()
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

        private void LoadBudgetPanel()
        {
            string balanceAmountQuery =
                "select sum(amount) from " +
                $"(select incAmount as amount from Income where userId = {UserId} " +
                "union all " +
                $"select -exAmount as amount from Expense where userId = {UserId}) as IncAndEx";
            object result = databaseConnector.ExecuteScalar(balanceAmountQuery);
            int balanceAmount = 0;
            if (result != null && result != DBNull.Value)
            {
                balanceAmount = (int)result;
            }

            string expectedQuery =
                $"select sum(epAmount) from ExpensePlan where userId = {UserId}";
            result = databaseConnector.ExecuteScalar(expectedQuery);
            int expectedExpense = 0;
            if (result != null && result != DBNull.Value)
            {
                expectedExpense = (int)result;
            }

            int budgetRemain = balanceAmount - expectedExpense;
            SetMoneyLabel(budgetRemain, budgetRemainLabel);
            SetMoneyLabel(expectedExpense, expectedExpenseLabel);
            SetColorBudgetRemainLabel(balanceAmount, budgetRemain);

        }

        private void SetColorBudgetRemainLabel(int balanceAmount, int budgetRemain)
        {
            float ratio = budgetRemain / (float)balanceAmount;
            if (ratio < 0.1f)
            {
                budgetRemainLabel.ForeColor = Color.Red;
            }
            else if (ratio < 0.5f)
            {
                budgetRemainLabel.ForeColor = Color.DarkOrange;
            }
            else
            {
                budgetRemainLabel.ForeColor = Color.LawnGreen;
            }
        }

        private void SetMoneyLabel(int money, Label label)
        {
            if (money < 1000000 && money > -1000000)
            {
                label.Text = money.ToString();
            }
            else
            {
                label.Text = money.ToString("0,,.00") + "M";
            }
        }

        private bool ValidateInput(string name, string category, string amountText, out int amount)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
                amount = 0;
                return false;
            }

            if (!int.TryParse(amountText, out amount))
            {
                MessageBox.Show("Số tiền phải là một số!");
                return false;
            }

            return true;
        }

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá toàn bộ kế hoạch chi tiêu?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                databaseConnector.ExecuteNonQuery($"delete from ExpensePlan where userId = {UserId}");
                LoadData();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string category = categoryTextBox.Text;
            string amountStr = amountTextBox.Text;
            string date = dateTimePicker.Value.Date.ToString("yyyyMMdd");
            int amount;
            if (!ValidateInput(name, category, amountStr, out amount))
                return;

            string query = 
                "insert into ExpensePlan values" +
                $"(N'{name}', N'{category}', {amount}, '{date}', {UserId})";
            databaseConnector.ExecuteNonQuery(query);
    
            LoadData();

            object result = GetLastestEpId();
            if (result != null && result != DBNull.Value)
            {
                int epId = (int)result;
                SetSelectedRowExpensePlanTable(epId);
            }
        }

        private object GetLastestEpId()
        {
            string query = $"select top 1 epId from ExpensePlan where userId = {UserId} order by epId desc";
            return databaseConnector.ExecuteScalar(query);
        }

        private void SetSelectedRowExpensePlanTable(int epId)
        {
            foreach (DataGridViewRow row in expensePlanTable.Rows)
            {
                if (row.Cells[1].Value.ToString() == epId.ToString())
                {
                    row.Selected = true;
                    expensePlanTable.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void expensePlanTable_SelectionChanged(object sender, EventArgs e)
        {
            if (expensePlanTable.SelectedRows.Count > 0)
            {
                string name = expensePlanTable.SelectedRows[0].Cells[2].Value.ToString();
                string category = expensePlanTable.SelectedRows[0].Cells[3].Value.ToString();
                string amount = expensePlanTable.SelectedRows[0].Cells[4].Value.ToString();
                string dateStr = expensePlanTable.SelectedRows[0].Cells[5].Value.ToString();
                nameTextBox.Text = name;
                categoryTextBox.Text = category;
                amountTextBox.Text = amount;
                if (dateStr != "")
                {
                    DateTime date = DateTime.ParseExact(dateStr, "dd/MM/yyyy", null);
                    dateTimePicker.Value = date;
                } 
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        { 
            string epId;
            if (!TryGetSelectedRowIdExpensePlanTable(out epId))
            {
                MessageBox.Show("Hàng cần xoá chưa được chọn!");
                return;
            }
            string query = $"delete from ExpensePlan where epId = {epId}";
            databaseConnector.ExecuteNonQuery(query);
            LoadData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string epId;
            if (!TryGetSelectedRowIdExpensePlanTable(out epId))
            {
                MessageBox.Show("Hàng cần lưu thay đổi chưa được chọn!");
                return;
            }
            string name = nameTextBox.Text;
            string category = categoryTextBox.Text;
            string amountStr = amountTextBox.Text;
            string date = dateTimePicker.Value.Date.ToString("yyyyMMdd");
            int amount;

            if (!ValidateInput(name, category, amountStr, out amount))
                return;

            string query = 
                $"update ExpensePlan " +
                $"set epName = N'{name}', epCategory = N'{category}', epAmount = {amount}, epDate = '{date}'" +
                $"where epId = {epId}";
            databaseConnector.ExecuteNonQuery(query);
            LoadData();
            SetSelectedRowExpensePlanTable(int.Parse(epId));

        }

        private bool TryGetSelectedRowIdExpensePlanTable(out string id)
        {
            if (expensePlanTable.SelectedRows.Count == 0)
            {
                id = "-1";
                return false;
            }
            object selectedRowId = expensePlanTable.SelectedRows[0].Cells[1].Value;
            if (selectedRowId == null)
            {
                id = "-1";
                return false;
            }
            id = selectedRowId.ToString();
            return true;
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
