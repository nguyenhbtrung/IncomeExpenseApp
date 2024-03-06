using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IncomeExpenseApp
{
    public partial class DashBoardForm : IncomeExpenseApp.MainForm
    {
        public DashBoardForm()
        {
            InitializeComponent();
            FormIndex = 0;
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
