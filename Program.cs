using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseApp
{

    internal static class Program
    {
        private static string dbConnectionString = "Data Source=DESKTOP-AHRDOKI;Initial Catalog=IncomeExpense;Integrated Security=True;Encrypt=True";

        public static string DbConnectionString { get => dbConnectionString; }
        public static Login LoginForm { get; private set; }

        //test xem co pull dc program ve k
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
