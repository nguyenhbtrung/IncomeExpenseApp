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
    public partial class DashBoardControl : UserControl
    {
        private DatabaseConnector databaseConnector;
        private int userId;
        private int amountIncome;
        private int amountExpense;
        private string currencyUnit = " VNĐ";

        public int UserId { get => userId; set => userId = value; }

        public DashBoardControl()
        {
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.BringToFront();
            panel6.BringToFront();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            incomeExpendChart.BringToFront();
            panel6.BringToFront();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel6.BringToFront();
        }

        public void LoadData()
        {
            LoadIncomeData();
            LoadExpenseData();
            LoadProfitData();
        }

        private void LoadProfitData()
        {
            int profit = amountIncome - amountExpense;
            profitLabel.Text = profit.ToString("N0") + currencyUnit;
        }

        private void LoadExpenseData()
        {
            object result = databaseConnector.ExecuteScalar($"select sum(exAmount) from Expense where userId = {userId}");
            if (result != null && result != DBNull.Value)
            {
                amountExpense = (int)result;
                amountExpenselabel.Text = amountExpense.ToString("N0") + currencyUnit;
            }

            result = databaseConnector.ExecuteScalar($"select count(exAmount) from Expense where userId = {userId}");
            if (result != null && result != DBNull.Value)
            {
                int transaction = (int)result;
                transactionExpenseLabel.Text = transaction.ToString();
            }

            result = databaseConnector.ExecuteScalar($"select top 1 format(exDate, 'dd/MM/yyyy') from Expense where userId = {userId} order by exDate desc");

            if (result != null && result != DBNull.Value)
            {
                string lastDate = result.ToString();
                lastTransactionExpenseLabel.Text = "Giao dịch cuối: " + lastDate;
            }
        }

        private void LoadIncomeData()
        {
            object result = databaseConnector.ExecuteScalar($"select sum(incAmount) from Income where userId = {userId}");
            if (result != null && result != DBNull.Value)
            {
                amountIncome = (int)result;
                amountIncomeLabel.Text = amountIncome.ToString("N0") + currencyUnit;
            }

            result = databaseConnector.ExecuteScalar($"select count(incAmount) from Income where userId = {userId}");

            if (result != null && result != DBNull.Value)
            {
                int transaction = (int)result;
                transactionIncomeLabel.Text = transaction.ToString();
            }

            result = databaseConnector.ExecuteScalar($"select top 1 format(incDate, 'dd/MM/yyyy') from Income where userId = {userId} order by incDate desc");

            if (result != null && result != DBNull.Value)
            {
                string lastDate = result.ToString();
                lastTransactionIncomeLabel.Text = "Giao dịch cuối: " + lastDate;
            }
        }
    }
}
