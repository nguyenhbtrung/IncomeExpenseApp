using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseApp
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(RoundedCornerGenerator.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void OpenDashBoard(object sender, EventArgs e)
        {
            DashBoardForm form = new DashBoardForm();
            form.Show();
            this.Close();
        }

        protected void OpenIncome(object sender, EventArgs e)
        {
            Income form = new Income();
            form.Show();
            this.Close();
        }

        protected void OpenExpense(object sender, EventArgs e)
        {
            Expense form = new Expense();
            form.Show();
            this.Close();
        }

        protected void OpenViewIncome(object sender, EventArgs e)
        {
            ViewIncome form = new ViewIncome();
            form.Show();
            this.Close();
        }

        protected void OpenViewExpense(object sender, EventArgs e)
        {
            ViewExpense form = new ViewExpense();
            form.Show();
            this.Close();
        }

        public void ChangeTheSelectionDisPlay(int oldIndex, int newIndex)
        {
            
        }
    }
}
