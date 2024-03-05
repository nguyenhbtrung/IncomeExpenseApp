using IncomeExpenseApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private List<PictureBox> menuPictureBoxes = new List<PictureBox>();
        private List<Label> menuLabels = new List<Label>();
        private List<Bitmap> purpleImageResources = new List<Bitmap>();
        private List<Bitmap> blackImageResources = new List<Bitmap>();
        public Form1()
        {
            InitializeComponent();
            purpleImageResources.Add(Resources.output_onlinepngtools);
            purpleImageResources.Add(Resources.output_onlinepngtools__7_);
            purpleImageResources.Add(Resources.output_onlinepngtools__3_);
            purpleImageResources.Add(Resources.output_onlinepngtools__8_);
            purpleImageResources.Add(Resources.output_onlinepngtools__6_);

            blackImageResources.Add(Resources.DashBoard);
            blackImageResources.Add(Resources.ThuNhap);
            blackImageResources.Add(Resources.ChiTieu);
            blackImageResources.Add(Resources.XemThuNhap);
            blackImageResources.Add(Resources.XemChiTieu);
            foreach (Control control in panel1.Controls)
            {
                if (control is Label && control.Name.StartsWith("menu"))
                {
                    menuLabels.Add((Label)control);
                }
                if (control is PictureBox && control.Name.StartsWith("menu"))
                {
                    menuPictureBoxes.Add((PictureBox)control);
                }
            }
            menuLabels.Reverse();
            menuPictureBoxes.Reverse();
            //foreach (Label label in menuLabels)
            //{
            //    Debug.WriteLine(label.Text);
            //}
            //for (int i = 0; i < menuLabels.Count; i++)
            //{
            //    Debug.WriteLine(menuLabels[i].Text);
            //}
            //foreach(PictureBox picture in menuPictureBoxes)
            //{
            //    Debug.WriteLine(picture.Name);
            //}
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

        public void ChangeTheSelectionDisplay(int oldIndex, int newIndex)
        {

        }
    }
}
