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
        private int userId;

        public int UserId { get => userId; set => userId = value; }

        public DashBoardControl()
        {
            InitializeComponent();
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
    }
}
