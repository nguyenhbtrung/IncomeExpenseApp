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

        public int UserId { get => userId; set => userId = value; }

        public DashBoardControl()
        {
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            LoadData();
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
            object result = databaseConnector.ExecuteScalar("select sum(incAmount) from Income");
            if (result != null && result != DBNull.Value)
            {
                int amountIncome = (int)result;
                amountIncomeLabel.Text = amountIncome.ToString("N0") + "VNĐ";
            }

            result = databaseConnector.ExecuteScalar("select count(incAmount) from Income");
            
            if (result != null && result != DBNull.Value)
            {
                int transaction = (int)result;
                transactionIncomeLabel.Text = transaction.ToString();
            }

            result = databaseConnector.ExecuteScalar("select top 1 format(incDate, 'dd/MM/yyyy') from Income order by incDate desc");

            if (result != null && result != DBNull.Value)
            {
                string lastDate = result.ToString();
                lastTransactionIncomeLabel.Text = "Giao dịch cuối: " + lastDate;
            }

            result = databaseConnector.ExecuteScalar("select sum(exAmount) from Expense");
            if (result != null && result != DBNull.Value)
            {
                int amountExpense = (int)result;
                amountExpenselabel.Text = amountExpense.ToString("N0") + "VNĐ";
            }

            result = databaseConnector.ExecuteScalar("select count(exAmount) from Expense");
            if (result != null && result != DBNull.Value)
            {
                int transaction = (int)result;
                transactionExpenseLabel.Text = transaction.ToString();
            }

            result = databaseConnector.ExecuteScalar("select top 1 format(exDate, 'dd/MM/yyyy') from Expense order by exDate desc");

            if (result != null && result != DBNull.Value)
            {
                string lastDate = result.ToString();
                lastTransactionExpenseLabel.Text = "Giao dịch cuối: " + lastDate;
            }
        }
    }
}
