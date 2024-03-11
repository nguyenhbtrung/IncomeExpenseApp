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

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams handleParams = base.CreateParams;
        //        handleParams.ExStyle |= 0x02000000;
        //        return handleParams;
        //    }
        //}

        private void AddMenuLabelsAndImageToList()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Label label && control.Name.StartsWith("menu"))
                {
                    menuLabels.Add(label);
                }
                if (control is PictureBox box && control.Name.StartsWith("menu"))
                {
                    menuPictureBoxes.Add(box);
                }
            }
            menuLabels.Reverse();
            menuPictureBoxes.Reverse();
        }

        private void AddMenuImageResourcesToList()
        {
            purpleImageResources.Add(Resources.SelectedDashBoard);
            purpleImageResources.Add(Resources.SelectedThuNhap);
            purpleImageResources.Add(Resources.SelectedChiTieu);
            purpleImageResources.Add(Resources.SelectedXemThuNhap);
            purpleImageResources.Add(Resources.SelectedXemChiTieu);

            blackImageResources.Add(Resources.DashBoard);
            blackImageResources.Add(Resources.ThuNhap);
            blackImageResources.Add(Resources.ChiTieu);
            blackImageResources.Add(Resources.XemThuNhap);
            blackImageResources.Add(Resources.XemChiTieu);
        }

        private void Logout(object sender, EventArgs e)
        {
            Program.LoginForm.Show();
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
            SwitchToForm(form);
        }

        protected void OpenIncome(object sender, EventArgs e)
        {
            Income form = new Income();
            SwitchToForm(form);
        }

        protected void OpenExpense(object sender, EventArgs e)
        {
            Expense form = new Expense();
            SwitchToForm(form);
        }

        protected void OpenViewIncome(object sender, EventArgs e)
        {
            ViewIncome form = new ViewIncome();
            SwitchToForm(form);
        }

        protected void OpenViewExpense(object sender, EventArgs e)
        {
            ViewExpense form = new ViewExpense();
            SwitchToForm(form);
        }

        private void SwitchToForm(MainForm form)
        {
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
            menuLabels[newIndex].ForeColor = Color.LimeGreen;
            blackImageResources = null;
            purpleImageResources = null;
        }
    }
}
