using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseApp
{

    internal static class Program
    {
        private static string dbConnectionString = "Data Source=DESKTOP-69AE7RJ\\PC;Initial Catalog = IncomeExpense; Integrated Security = True; Encrypt=True;TrustServerCertificate=True";

        public static string DbConnectionString { get => dbConnectionString; }
        public static Login LoginForm { get; private set; }

        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm = new Login();
            Application.Run(LoginForm);
        }
    }
}
