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
        }

        private void LoadBudgetPanel()
        {
            string profitQuery = 
                "select sum(amount) from " +
                $"(select incAmount as amount from Income where userId = {UserId} " +
                "union all " +
                $"select -exAmount as amount from Expense where userId = {UserId}) as IncAndEx";
            object result = databaseConnector.ExecuteScalar(profitQuery);
            int profit = 0;
            if (result != null && result != DBNull.Value)
            {
                profit = (int)result;
            }

            string expectedQuery =
                $"select sum(epAmount) from ExpensePlan where userId = {UserId}";
            result = databaseConnector.ExecuteScalar(expectedQuery);
            int expectedExpense = 0;
            if (result != null && result != DBNull.Value)
            {
                expectedExpense = (int)result;
            }

            int budget = profit - expectedExpense;
            if (budget < 1000000)
            {
                budgetLabel.Text = budget.ToString();
            }
            else
            {
                budgetLabel.Text = budget.ToString("0,,.00") + "M";
            }
            if (expectedExpense < 1000000)
            {
                expectedExpenseLabel.Text = expectedExpense.ToString();
            }
            else
            {
                expectedExpenseLabel.Text = expectedExpense.ToString("0,,.00") + "M";
            }

        }
    }
}
