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
    public partial class MainForm : Form
    {
        private List<PictureBox> menuPictureBoxes = new List<PictureBox>();
        private List<Label> menuLabels = new List<Label>();
        private List<Bitmap> purpleImageResources = new List<Bitmap>();
        private List<Bitmap> blackImageResources = new List<Bitmap>();

        private int formIndex = 0;

        public int FormIndex { get => formIndex; set => formIndex = value; }

        public MainForm()
        {
            InitializeComponent();
            AddMenuImageResourcesToList();
            AddMenuLabelsAndImageToList();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(RoundedCornerGenerator.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        //int originalExStyle = -1;
        //bool enableFormLevelDoubleBuffering = true;

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        if (originalExStyle == -1)
        //            originalExStyle = base.CreateParams.ExStyle;
        //        CreateParams handleParams = base.CreateParams;
        //        if (enableFormLevelDoubleBuffering)
        //            handleParams.ExStyle |= 0x02000000;
        //        else
        //            handleParams.ExStyle = originalExStyle;
        //        return handleParams;
        //    }
        //}

        //private void TurnOffFormLevelDoubleBuffering()
        //{
        //    enableFormLevelDoubleBuffering = false;
        //    this.MaximizeBox = true;
        //}

        private void AddMenuLabelsAndImageToList()
        {
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
        }

        private void AddMenuImageResourcesToList()
        {
            purpleImageResources.Add(Resources.PurpleDashBoard);
            purpleImageResources.Add(Resources.PurpleThuNhap);
            purpleImageResources.Add(Resources.PurpleChiTieu);
            purpleImageResources.Add(Resources.XemThuNhap);
            purpleImageResources.Add(Resources.XemChiTieu);

            blackImageResources.Add(Resources.DashBoard);
            blackImageResources.Add(Resources.ThuNhap);
            blackImageResources.Add(Resources.ChiTieu);
            blackImageResources.Add(Resources.XemThuNhap);
            blackImageResources.Add(Resources.XemChiTieu);
        }

        private void Logout(object sender, EventArgs e)
        {
            Program.loginForm.Show();
            this.Close();
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
            form.ChangeTheSelectionDisplay(this.FormIndex, form.FormIndex);
            this.Close();
        }

        protected void OpenIncome(object sender, EventArgs e)
        {
            Income form = new Income();
            form.Show();
            form.ChangeTheSelectionDisplay(this.FormIndex, form.FormIndex);
            this.Close();
        }

        protected void OpenExpense(object sender, EventArgs e)
        {
            Expense form = new Expense();
            form.Show();
            form.ChangeTheSelectionDisplay(this.FormIndex, form.FormIndex);
            this.Close();
        }

        protected void OpenViewIncome(object sender, EventArgs e)
        {
            ViewIncome form = new ViewIncome();
            form.Show();
            form.ChangeTheSelectionDisplay(this.FormIndex, form.FormIndex);
            this.Close();
        }

        protected void OpenViewExpense(object sender, EventArgs e)
        {
            ViewExpense form = new ViewExpense();
            form.Show();
            form.ChangeTheSelectionDisplay(this.FormIndex, form.FormIndex);
            this.Close();
        }

        public void ChangeTheSelectionDisplay(int oldIndex, int newIndex)
        {
            if (blackImageResources == null || purpleImageResources == null)
                return;
            menuPictureBoxes[oldIndex].Image = blackImageResources[oldIndex];
            menuPictureBoxes[newIndex].Image = purpleImageResources[newIndex];

            menuLabels[oldIndex].ForeColor = SystemColors.Desktop;
            menuLabels[newIndex].ForeColor = Color.Indigo;
            blackImageResources = null;
            purpleImageResources = null;
        }
    }
}
