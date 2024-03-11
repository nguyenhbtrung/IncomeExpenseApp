using IncomeExpenseApp.TestUserControl;
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
        public static Login LoginForm { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm = new Login();
            Application.Run(new MainForm());
        }
    }
}
