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
        private int userId;

        public int UserId { get => userId; set => userId = value; }
        public PlanControl()
        {
            InitializeComponent();
        }
    }
}
