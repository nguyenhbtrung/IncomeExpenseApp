using System;
using System.Data;
using System.Diagnostics;
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

        private int ProfitChartMaxX
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
            topChart.BringToFront();
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
            LoadBest();
            LoadIncomeExpenseChart();
            LoadTopChart();
        }

        private void LoadTopChart()
        {
            string incomeQuery = 
                "with Top3 as " +
                $"(select top 3 incId, incName, incAmount from Income where month(incDate) = month(getdate()) and year(incDate) = year(getdate()) and userId = {UserId}) " +
                "select incName, incAmount from Top3 " +
                "union all " +
                $"select N'Còn lại' as incName, sum(incAmount) from Income where month(incDate) = month(getdate()) and year(incDate) = year(getdate()) and userId = {UserId} and incId not in (select incId from Top3)";
            string expenseQuery = 
                "with Top3 as " +
                $"(select top 3 exId, exName, exAmount from Expense where month(exDate) = month(getdate()) and year(exDate) = year(getdate()) and userId = {UserId}) " +
                "select exName, exAmount from Top3 " +
                "union all " +
                $"select N'Còn lại' as exName, sum(exAmount) from Expense where month(exDate) = month(getdate()) and year(exDate) = year(getdate()) and userId = {UserId} and exId not in (select exId from Top3)";
            DataSet dataSet = databaseConnector.ExecuteDataSetQuery(incomeQuery);
            DataSet expenseData = databaseConnector.ExecuteDataSetQuery(expenseQuery);
            dataSet.Merge(expenseData);
            topChart.DataSource = dataSet;
            topChart.Series[0].XValueMember = "incName";
            topChart.Series[0].YValueMembers = "incAmount";
 
            topChart.Series[1].XValueMember = "exName";
            topChart.Series[1].YValueMembers = "exAmount";
            topChart.DataBind();
        }

        private void LoadIncomeExpenseChart()
        {
            string query =
                "select TMonth.month, isnull(IncomeMonth.amount, 0) as incAmount, isnull(ExpenseMonth.amount, 0) as exAmount from " +
                $"(select format(incDate, 'MM/yyyy') as month, year(incDate) as year from Income where userId = {UserId} " +
                "union " +
                $"select format(exDate, 'MM/yyyy') as month, year(exDate) as year from Expense where userId = {UserId}) as TMonth " +
                $"left join (select format(incDate, 'MM/yyyy') as date, sum(incAmount) as amount from Income where userId = {UserId} " +
                "group by year(incDate), format(incDate, 'MM/yyyy')) as IncomeMonth " +
                "on IncomeMonth.date = TMonth.month " +
                $"left join (select format(exDate, 'MM/yyyy') as date, sum(exAmount) as amount from Expense where userId = {UserId} " +
                "group by year(exDate), format(exDate, 'MM/yyyy')) as ExpenseMonth " +
                "on ExpenseMonth.date = TMonth.month " +
                "order by TMonth.year, TMonth.month";
            DataTable dataTable = databaseConnector.ExecuteDataTableQuery(query);
            incomeExpendChart.DataSource = dataTable;
            incomeExpendChart.Series[0].XValueMember = "month";
            incomeExpendChart.Series[0].YValueMembers = "incAmount";
            incomeExpendChart.Series[1].XValueMember = "month";
            incomeExpendChart.Series[1].YValueMembers = "exAmount";

            if (dataTable.Rows.Count > 10)
            {
                incomeExpendChart.ChartAreas[0].AxisX.ScaleView.Zoom(1, 11);
            }
        }

        private void LoadBest()
        {
            object result = databaseConnector.ExecuteScalar($"select top 1 incAmount from Income where userId = {UserId} order by incAmount desc");
            if (result != null && result != DBNull.Value)
            {
                int best = (int)result;
                bestIncomeLabel.Text = best.ToString("N0") + currencyUnit;
            }

            result = databaseConnector.ExecuteScalar($"select top 1 incAmount from Income where month(incDate) = month(getdate()) and year(incDate) = year(getdate()) and userId = {UserId} order by incAmount desc");
            if (result != null && result != DBNull.Value)
            {
                int best = (int)result;
                bestIncomeMonthLabel.Text = best.ToString("N0") + currencyUnit;
            }

            result = databaseConnector.ExecuteScalar($"select top 1 exAmount from Expense where userId = {UserId} order by exAmount desc");
            if (result != null && result != DBNull.Value)
            {
                int best = (int)result;
                bestExpenseLabel.Text = best.ToString("N0") + currencyUnit;
            }

            result = databaseConnector.ExecuteScalar($"select top 1 exAmount from Expense where month(exDate) = month(getdate()) and year(exDate) = year(getdate()) and userId = {UserId} order by exAmount desc");
            if (result != null && result != DBNull.Value)
            {
                int best = (int)result;
                bestExpenseMonthLabel.Text = best.ToString("N0") + currencyUnit;
            }
        }

        private void LoadProfitChartData()
        {
            string query = 
                "with IncomeAndExpense as " +
                $"(select incDate as date, incAmount as amount from Income where userId = {UserId}" +
                "union all " +
                $"select exDate as date, -exAmount as amount from Expense where userId = {UserId}) " +
                "select format(t1.date, 'dd/MM/yy') as date, sum(t2.amount) as profit from IncomeAndExpense t1 join IncomeAndExpense t2 on t2.date <= t1.date " +
                "group by t1.date order by t1.date";
            profitChartDataTable = databaseConnector.ExecuteDataTableQuery(query);
            profitChart.DataSource = profitChartDataTable;
            profitChart.Series[0].XValueMember = "date";
            profitChart.Series[0].YValueMembers = "profit";

            profitChartDataMaxIndex = profitChartDataTable.Rows.Count - 1;
            ProfitChartMaxX = profitChartDataMaxIndex;
            ProfitChartMinX = ProfitChartMaxX - profitChartXRange;

            ChangeProfitChartDataRange(0, ProfitChartMaxX);
        }

        private void ChangeProfitChartDataRange(int minX, int maxX)
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
            object result = databaseConnector.ExecuteScalar($"select sum(exAmount) from Expense where userId = {UserId}");
            if (result != null && result != DBNull.Value)
            {
                amountExpense = (int)result;
                amountExpenselabel.Text = amountExpense.ToString("N0") + currencyUnit;
            }

            result = databaseConnector.ExecuteScalar($"select count(exAmount) from Expense where userId = {UserId}");
            if (result != null && result != DBNull.Value)
            {
                int transaction = (int)result;
                transactionExpenseLabel.Text = transaction.ToString();
            }

            result = databaseConnector.ExecuteScalar($"select top 1 format(exDate, 'dd/MM/yyyy') from Expense where userId = {UserId} order by exDate desc");

            if (result != null && result != DBNull.Value)
            {
                string lastDate = result.ToString();
                lastExpenseLabel.Text = "Giao dịch cuối: " + lastDate;
            }
        }

        private void LoadIncomeData()
        {
            object result = databaseConnector.ExecuteScalar($"select sum(incAmount) from Income where userId = {UserId}");
            if (result != null && result != DBNull.Value)
            {
                amountIncome = (int)result;
                amountIncomeLabel.Text = amountIncome.ToString("N0") + currencyUnit;
            }

            result = databaseConnector.ExecuteScalar($"select count(incAmount) from Income where userId = {UserId}");

            if (result != null && result != DBNull.Value)
            {
                int transaction = (int)result;
                transactionIncomeLabel.Text = transaction.ToString();
            }

            result = databaseConnector.ExecuteScalar($"select top 1 format(incDate, 'dd/MM/yyyy') from Income where userId = {UserId} order by incDate desc");

            if (result != null && result != DBNull.Value)
            {
                string lastDate = result.ToString();
                lastIncomeLabel.Text = "Giao dịch cuối: " + lastDate;
            }
        }

        private void periodButton_Click(object sender, EventArgs e)
        {
            ChangeProfitChartDataRange(ProfitChartMinX, ProfitChartMaxX);
            switchLeftButton.Enabled = true;
            switchRightButton.Enabled = true;
        }

        private void overallButton_Click(object sender, EventArgs e)
        {
            int maxX = profitChartDataTable.Rows.Count - 1;
            ChangeProfitChartDataRange(0, maxX);
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
            ChangeProfitChartDataRange(ProfitChartMinX, ProfitChartMaxX);
        }

        private void switchRightButton_Click(object sender, EventArgs e)
        {
            
            if (ProfitChartMaxX > profitChartDataTable.Rows.Count - profitChartXRange)
            {
                return;
            }
            ProfitChartMaxX += profitChartXRange;
            ProfitChartMinX = ProfitChartMaxX - profitChartXRange;
            ChangeProfitChartDataRange(ProfitChartMinX, ProfitChartMaxX);
        }
    }
}
