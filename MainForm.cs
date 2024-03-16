﻿using IncomeExpenseApp.Controls;
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
        private List<Bitmap> selectedImageResources = new List<Bitmap>();
        private List<Bitmap> blackImageResources = new List<Bitmap>();
        private Panel menuSelectedPanel;
        private int userId;

        public int UserId { get => userId; private set => userId = value; }

        public MainForm(int userId)
        {
            
            InitializeComponent();
            AddMenuImageResourcesToList();

            this.UserId = userId;
            dashBoardControl1.UserId = userId;
            incomeControl1.UserId = userId;
            expenseControl1.UserId = userId;
            viewIncomeControl1.UserId = userId;
            viewExpenseControl1.UserId = userId;
            planControl1.UserId = userId;

            dashBoardControl1.LoadData();

            panel1.Controls.SetChildIndex(menuDashBoardPanel, 0);
            panel1.Controls.SetChildIndex(menuIncomePanel, 1);
            panel1.Controls.SetChildIndex(menuExpensePanel, 2);
            panel1.Controls.SetChildIndex(menuViewIncomePanel, 3);
            panel1.Controls.SetChildIndex(menuViewExpensePanel, 4);

            menuSelectedPanel = menuDashBoardPanel;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(RoundedCornerGenerator.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public MainForm()
        {
            InitializeComponent();
            AddMenuImageResourcesToList();

            this.UserId = 1;
            dashBoardControl1.UserId = userId;
            incomeControl1.UserId = userId;
            expenseControl1.UserId = userId;
            viewIncomeControl1.UserId = userId;
            viewExpenseControl1.UserId = userId;
            planControl1.UserId = userId;

            dashBoardControl1.LoadData();

            panel1.Controls.SetChildIndex(menuDashBoardPanel, 0);
            panel1.Controls.SetChildIndex(menuIncomePanel, 1);
            panel1.Controls.SetChildIndex(menuExpensePanel, 2);
            panel1.Controls.SetChildIndex(menuViewIncomePanel, 3);
            panel1.Controls.SetChildIndex(menuViewExpensePanel, 4);
            panel1.Controls.SetChildIndex(menuPlanPanel, 5);

            menuSelectedPanel = menuDashBoardPanel;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(RoundedCornerGenerator.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void AddMenuImageResourcesToList()
        {
            selectedImageResources.Add(Resources.SelectedDashBoard);
            selectedImageResources.Add(Resources.SelectedThuNhap);
            selectedImageResources.Add(Resources.SelectedChiTieu);
            selectedImageResources.Add(Resources.SelectedXemThuNhap);
            selectedImageResources.Add(Resources.SelectedXemChiTieu);
            selectedImageResources.Add(Resources.SelectedKeHoach);

            blackImageResources.Add(Resources.DashBoard);
            blackImageResources.Add(Resources.ThuNhap);
            blackImageResources.Add(Resources.ChiTieu);
            blackImageResources.Add(Resources.XemThuNhap);
            blackImageResources.Add(Resources.XemChiTieu);
            blackImageResources.Add(Resources.KeHoach);
        }

        private void Logout(object sender, EventArgs e)
        {
            Program.LoginForm.Show();
            this.Close();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        protected void OpenDashBoard(object sender, EventArgs e)
        {
            dashBoardControl1.BringToFront();
            Panel newSelectedPanel = menuDashBoardPanel;
            ChangeTheSelectionDisplay(menuSelectedPanel, newSelectedPanel);
        }

        protected void OpenIncome(object sender, EventArgs e)
        {
            incomeControl1.BringToFront();
            Panel newSelectedPanel = menuIncomePanel;
            ChangeTheSelectionDisplay(menuSelectedPanel, newSelectedPanel);
        }

        protected void OpenExpense(object sender, EventArgs e)
        {
            expenseControl1.BringToFront();
            Panel newSelectedPanel = menuExpensePanel;
            ChangeTheSelectionDisplay(menuSelectedPanel, newSelectedPanel);
        }

        protected void OpenViewIncome(object sender, EventArgs e)
        {
            viewIncomeControl1.BringToFront();
            Panel newSelectedPanel = menuViewIncomePanel;
            ChangeTheSelectionDisplay(menuSelectedPanel, newSelectedPanel);
        }

        protected void OpenViewExpense(object sender, EventArgs e)
        {
            viewExpenseControl1.BringToFront();
            Panel newSelectedPanel = menuViewExpensePanel;
            ChangeTheSelectionDisplay(menuSelectedPanel, newSelectedPanel);
        }

        private void OpenPlan(object sender, EventArgs e)
        {
            planControl1.BringToFront();
            Panel newSelectedPanel = menuPlanPanel;
            ChangeTheSelectionDisplay(menuSelectedPanel, newSelectedPanel);
        }

        public void ChangeTheSelectionDisplay(Panel oldMenuPanel, Panel newMenuPanel)
        {
            if (blackImageResources == null || selectedImageResources == null)
                return;

            oldMenuPanel.BackColor = Color.White;
            newMenuPanel.BackColor = Color.FromArgb(34, 57, 94);

            foreach (Control control in oldMenuPanel.Controls)
            {
                if (control is Label label)
                {
                    label.ForeColor = SystemColors.Desktop;
                }
                if (control is PictureBox pictureBox)
                {
                    int index = panel1.Controls.IndexOf(oldMenuPanel);
                    pictureBox.Image = blackImageResources[index];
                }
            }

            foreach (Control control in newMenuPanel.Controls)
            {
                if (control is Label label)
                {
                    label.ForeColor = Color.White;
                }
                if (control is PictureBox pictureBox)
                {
                    int index = panel1.Controls.IndexOf(newMenuPanel);
                    pictureBox.Image = selectedImageResources[index];
                }
            }

            menuSelectedPanel = newMenuPanel;
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
    }
}
