# IncomeExpenseApp
## Program.cs:
Add this class to your Repo
```C#
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
        private static string dbConnectionString = "YourDatabaseConnectionString";

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
```
 
