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
    public partial class DashBoardControl : UserControl
    {
        private DatabaseConnector databaseConnector;
        private DataTable profitChartDataTable;

        private int userId;
        private int amountIncome;
        private int amountExpense;
        private int profitChartMinX;
        private int profitChartMaxX;
        private int profitChartXRange = 10;
        private int profitChartDataMaxIndex;
        private string currencyUnit = " VNĐ";

        public int UserId { get => userId; set => userId = value; }
        private int ProfitChartMinX {
            get 
            {
                return profitChartMinX; 
            }
            set
            {
                profitChartMinX = (value < 0 ? 0 : value);
            }
        }

        public int ProfitChartMaxX
        {
            get
            {
                return profitChartMaxX;
            }
            set
            {
                profitChartMaxX = (value > profitChartDataMaxIndex ? profitChartDataMaxIndex : value);
            }
        }

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
            LoadProfitChartData();
        }

        private void LoadProfitChartData()
        {
            profitChartDataTable = databaseConnector.ExecuteDataTableQuery(
                "with IncomeAndExpense as " +
                $"(select incDate as date, incAmount as amount from Income where userId = {userId}" +
                "union all " +
                $"select exDate as date, -exAmount as amount from Expense where userId = {userId}) " +
                "select format(t1.date, 'dd/MM/yy') as date, sum(t2.amount) as profit from IncomeAndExpense t1 join IncomeAndExpense t2 on t2.date <= t1.date " +
                "group by t1.date order by t1.date");
            profitChart.DataSource = profitChartDataTable;
            profitChart.Series[0].XValueMember = "date";
            profitChart.Series[0].YValueMembers = "profit";

            profitChartDataMaxIndex = profitChartDataTable.Rows.Count - 1;
            ProfitChartMaxX = profitChartDataMaxIndex;
            ProfitChartMinX = ProfitChartMaxX - profitChartXRange;

            ChangeRangeProfitChartData(0, ProfitChartMaxX);
        }

        private void ChangeRangeProfitChartData(int minX, int maxX)
        {
            if (profitChartDataTable == null || profitChartDataTable.Rows.Count <= 0)
                return;
            profitChart.ChartAreas[0].AxisX.Minimum = minX + 1;
            profitChart.ChartAreas[0].AxisX.Maximum = maxX + 1;
            string fromDate = profitChartDataTable.Rows[minX].Field<string>("date");
            string toDate = profitChartDataTable.Rows[maxX].Field<string>("date");
            profitChart.Titles[0].Text = $"Lợi nhuận: {fromDate} - {toDate}";
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

        private void periodButton_Click(object sender, EventArgs e)
        {
            ChangeRangeProfitChartData(ProfitChartMinX, ProfitChartMaxX);
            switchLeftButton.Enabled = true;
            switchRightButton.Enabled = true;
        }

        private void overallButton_Click(object sender, EventArgs e)
        {
            int maxX = profitChartDataTable.Rows.Count - 1;
            ChangeRangeProfitChartData(0, maxX);
            switchLeftButton.Enabled = false;
            switchRightButton.Enabled = false;
        }

        private void switchLeftButton_Click(object sender, EventArgs e)
        {
            if (ProfitChartMaxX < profitChartXRange)
            {
                return;
            }
            ProfitChartMaxX -= profitChartXRange;
            ProfitChartMinX = ProfitChartMaxX - 10;
            ChangeRangeProfitChartData(ProfitChartMinX, ProfitChartMaxX);
        }

        private void switchRightButton_Click(object sender, EventArgs e)
        {
            
            if (ProfitChartMaxX > profitChartDataTable.Rows.Count - profitChartXRange)
            {
                return;
            }
            ProfitChartMaxX += profitChartXRange;
            ProfitChartMinX = ProfitChartMaxX - profitChartXRange;
            ChangeRangeProfitChartData(ProfitChartMinX, ProfitChartMaxX);
        }
    }
}
