namespace IncomeExpenseApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuPlanPanel = new System.Windows.Forms.Panel();
            this.menuPlanLabel = new System.Windows.Forms.Label();
            this.menuPlanImage = new System.Windows.Forms.PictureBox();
            this.menuViewIncomePanel = new System.Windows.Forms.Panel();
            this.menuViewIncomeImage = new System.Windows.Forms.PictureBox();
            this.menuViewIncomeLabel = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.menuViewExpensePanel = new System.Windows.Forms.Panel();
            this.menuViewExpenseLabel = new System.Windows.Forms.Label();
            this.menuViewExpenseImage = new System.Windows.Forms.PictureBox();
            this.logoutImage = new System.Windows.Forms.PictureBox();
            this.menuDashBoardPanel = new System.Windows.Forms.Panel();
            this.menuDashBoardLabel = new System.Windows.Forms.Label();
            this.menuDashBoardImage = new System.Windows.Forms.PictureBox();
            this.menuIncomePanel = new System.Windows.Forms.Panel();
            this.menuIncomeImage = new System.Windows.Forms.PictureBox();
            this.menuIncomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuExpensePanel = new System.Windows.Forms.Panel();
            this.menuExpenseImage = new System.Windows.Forms.PictureBox();
            this.menuExpenseLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.planControl1 = new IncomeExpenseApp.Controls.PlanControl();
            this.dashBoardControl1 = new IncomeExpenseApp.Controls.DashBoardControl();
            this.viewExpenseControl1 = new IncomeExpenseApp.Controls.ViewExpenseControl();
            this.viewIncomeControl1 = new IncomeExpenseApp.Controls.ViewIncomeControl();
            this.expenseControl1 = new IncomeExpenseApp.Controls.ExpenseControl();
            this.incomeControl1 = new IncomeExpenseApp.Controls.IncomeControl();
            this.panel1.SuspendLayout();
            this.menuPlanPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuPlanImage)).BeginInit();
            this.menuViewIncomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuViewIncomeImage)).BeginInit();
            this.menuViewExpensePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuViewExpenseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutImage)).BeginInit();
            this.menuDashBoardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuDashBoardImage)).BeginInit();
            this.menuIncomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuIncomeImage)).BeginInit();
            this.menuExpensePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuExpenseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.menuPlanPanel);
            this.panel1.Controls.Add(this.menuViewIncomePanel);
            this.panel1.Controls.Add(this.logoutLabel);
            this.panel1.Controls.Add(this.menuViewExpensePanel);
            this.panel1.Controls.Add(this.logoutImage);
            this.panel1.Controls.Add(this.menuDashBoardPanel);
            this.panel1.Controls.Add(this.menuIncomePanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuExpensePanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 720);
            this.panel1.TabIndex = 0;
            // 
            // menuPlanPanel
            // 
            this.menuPlanPanel.BackColor = System.Drawing.Color.White;
            this.menuPlanPanel.Controls.Add(this.menuPlanLabel);
            this.menuPlanPanel.Controls.Add(this.menuPlanImage);
            this.menuPlanPanel.Location = new System.Drawing.Point(0, 431);
            this.menuPlanPanel.Name = "menuPlanPanel";
            this.menuPlanPanel.Size = new System.Drawing.Size(193, 50);
            this.menuPlanPanel.TabIndex = 38;
            this.menuPlanPanel.Click += new System.EventHandler(this.OpenPlan);
            // 
            // menuPlanLabel
            // 
            this.menuPlanLabel.AutoSize = true;
            this.menuPlanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPlanLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.menuPlanLabel.Location = new System.Drawing.Point(53, 18);
            this.menuPlanLabel.Name = "menuPlanLabel";
            this.menuPlanLabel.Size = new System.Drawing.Size(84, 20);
            this.menuPlanLabel.TabIndex = 11;
            this.menuPlanLabel.Text = "Kế hoạch";
            this.menuPlanLabel.Click += new System.EventHandler(this.OpenPlan);
            // 
            // menuPlanImage
            // 
            this.menuPlanImage.Image = global::IncomeExpenseApp.Properties.Resources.KeHoach;
            this.menuPlanImage.Location = new System.Drawing.Point(11, 0);
            this.menuPlanImage.Name = "menuPlanImage";
            this.menuPlanImage.Size = new System.Drawing.Size(35, 50);
            this.menuPlanImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuPlanImage.TabIndex = 10;
            this.menuPlanImage.TabStop = false;
            this.menuPlanImage.Click += new System.EventHandler(this.OpenPlan);
            // 
            // menuViewIncomePanel
            // 
            this.menuViewIncomePanel.BackColor = System.Drawing.Color.White;
            this.menuViewIncomePanel.Controls.Add(this.menuViewIncomeImage);
            this.menuViewIncomePanel.Controls.Add(this.menuViewIncomeLabel);
            this.menuViewIncomePanel.Location = new System.Drawing.Point(0, 319);
            this.menuViewIncomePanel.Name = "menuViewIncomePanel";
            this.menuViewIncomePanel.Size = new System.Drawing.Size(193, 50);
            this.menuViewIncomePanel.TabIndex = 36;
            this.menuViewIncomePanel.Click += new System.EventHandler(this.OpenViewIncome);
            // 
            // menuViewIncomeImage
            // 
            this.menuViewIncomeImage.Image = global::IncomeExpenseApp.Properties.Resources.XemThuNhap;
            this.menuViewIncomeImage.Location = new System.Drawing.Point(12, 0);
            this.menuViewIncomeImage.Name = "menuViewIncomeImage";
            this.menuViewIncomeImage.Size = new System.Drawing.Size(35, 50);
            this.menuViewIncomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuViewIncomeImage.TabIndex = 8;
            this.menuViewIncomeImage.TabStop = false;
            this.menuViewIncomeImage.Click += new System.EventHandler(this.OpenViewIncome);
            // 
            // menuViewIncomeLabel
            // 
            this.menuViewIncomeLabel.AutoSize = true;
            this.menuViewIncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuViewIncomeLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.menuViewIncomeLabel.Location = new System.Drawing.Point(51, 19);
            this.menuViewIncomeLabel.Name = "menuViewIncomeLabel";
            this.menuViewIncomeLabel.Size = new System.Drawing.Size(121, 20);
            this.menuViewIncomeLabel.TabIndex = 9;
            this.menuViewIncomeLabel.Text = "Xem thu nhập";
            this.menuViewIncomeLabel.Click += new System.EventHandler(this.OpenViewIncome);
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.logoutLabel.Location = new System.Drawing.Point(51, 678);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(91, 20);
            this.logoutLabel.TabIndex = 13;
            this.logoutLabel.Text = "Đăng xuất";
            this.logoutLabel.Click += new System.EventHandler(this.Logout);
            // 
            // menuViewExpensePanel
            // 
            this.menuViewExpensePanel.BackColor = System.Drawing.Color.White;
            this.menuViewExpensePanel.Controls.Add(this.menuViewExpenseLabel);
            this.menuViewExpensePanel.Controls.Add(this.menuViewExpenseImage);
            this.menuViewExpensePanel.Location = new System.Drawing.Point(0, 375);
            this.menuViewExpensePanel.Name = "menuViewExpensePanel";
            this.menuViewExpensePanel.Size = new System.Drawing.Size(193, 50);
            this.menuViewExpensePanel.TabIndex = 37;
            this.menuViewExpensePanel.Click += new System.EventHandler(this.OpenViewExpense);
            // 
            // menuViewExpenseLabel
            // 
            this.menuViewExpenseLabel.AutoSize = true;
            this.menuViewExpenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuViewExpenseLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.menuViewExpenseLabel.Location = new System.Drawing.Point(53, 18);
            this.menuViewExpenseLabel.Name = "menuViewExpenseLabel";
            this.menuViewExpenseLabel.Size = new System.Drawing.Size(108, 20);
            this.menuViewExpenseLabel.TabIndex = 11;
            this.menuViewExpenseLabel.Text = "Xem chi tiêu";
            this.menuViewExpenseLabel.Click += new System.EventHandler(this.OpenViewExpense);
            // 
            // menuViewExpenseImage
            // 
            this.menuViewExpenseImage.Image = global::IncomeExpenseApp.Properties.Resources.XemChiTieu;
            this.menuViewExpenseImage.Location = new System.Drawing.Point(11, 0);
            this.menuViewExpenseImage.Name = "menuViewExpenseImage";
            this.menuViewExpenseImage.Size = new System.Drawing.Size(35, 50);
            this.menuViewExpenseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuViewExpenseImage.TabIndex = 10;
            this.menuViewExpenseImage.TabStop = false;
            this.menuViewExpenseImage.Click += new System.EventHandler(this.OpenViewExpense);
            // 
            // logoutImage
            // 
            this.logoutImage.Image = global::IncomeExpenseApp.Properties.Resources.Logout;
            this.logoutImage.Location = new System.Drawing.Point(12, 659);
            this.logoutImage.Name = "logoutImage";
            this.logoutImage.Size = new System.Drawing.Size(35, 50);
            this.logoutImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutImage.TabIndex = 12;
            this.logoutImage.TabStop = false;
            this.logoutImage.Click += new System.EventHandler(this.Logout);
            // 
            // menuDashBoardPanel
            // 
            this.menuDashBoardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.menuDashBoardPanel.Controls.Add(this.menuDashBoardLabel);
            this.menuDashBoardPanel.Controls.Add(this.menuDashBoardImage);
            this.menuDashBoardPanel.Location = new System.Drawing.Point(0, 151);
            this.menuDashBoardPanel.Name = "menuDashBoardPanel";
            this.menuDashBoardPanel.Size = new System.Drawing.Size(193, 50);
            this.menuDashBoardPanel.TabIndex = 33;
            this.menuDashBoardPanel.Click += new System.EventHandler(this.OpenDashBoard);
            // 
            // menuDashBoardLabel
            // 
            this.menuDashBoardLabel.AutoSize = true;
            this.menuDashBoardLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuDashBoardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDashBoardLabel.ForeColor = System.Drawing.Color.White;
            this.menuDashBoardLabel.Location = new System.Drawing.Point(53, 19);
            this.menuDashBoardLabel.Name = "menuDashBoardLabel";
            this.menuDashBoardLabel.Size = new System.Drawing.Size(83, 20);
            this.menuDashBoardLabel.TabIndex = 3;
            this.menuDashBoardLabel.Text = "Thống kê";
            this.menuDashBoardLabel.Click += new System.EventHandler(this.OpenDashBoard);
            // 
            // menuDashBoardImage
            // 
            this.menuDashBoardImage.BackColor = System.Drawing.Color.Transparent;
            this.menuDashBoardImage.Image = global::IncomeExpenseApp.Properties.Resources.SelectedDashBoard;
            this.menuDashBoardImage.Location = new System.Drawing.Point(12, 0);
            this.menuDashBoardImage.Name = "menuDashBoardImage";
            this.menuDashBoardImage.Size = new System.Drawing.Size(35, 50);
            this.menuDashBoardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuDashBoardImage.TabIndex = 2;
            this.menuDashBoardImage.TabStop = false;
            this.menuDashBoardImage.Click += new System.EventHandler(this.OpenDashBoard);
            // 
            // menuIncomePanel
            // 
            this.menuIncomePanel.BackColor = System.Drawing.Color.White;
            this.menuIncomePanel.Controls.Add(this.menuIncomeImage);
            this.menuIncomePanel.Controls.Add(this.menuIncomeLabel);
            this.menuIncomePanel.Location = new System.Drawing.Point(0, 207);
            this.menuIncomePanel.Name = "menuIncomePanel";
            this.menuIncomePanel.Size = new System.Drawing.Size(193, 50);
            this.menuIncomePanel.TabIndex = 34;
            this.menuIncomePanel.Click += new System.EventHandler(this.OpenIncome);
            // 
            // menuIncomeImage
            // 
            this.menuIncomeImage.Image = global::IncomeExpenseApp.Properties.Resources.ThuNhap;
            this.menuIncomeImage.Location = new System.Drawing.Point(12, 0);
            this.menuIncomeImage.Name = "menuIncomeImage";
            this.menuIncomeImage.Size = new System.Drawing.Size(35, 50);
            this.menuIncomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuIncomeImage.TabIndex = 4;
            this.menuIncomeImage.TabStop = false;
            this.menuIncomeImage.Click += new System.EventHandler(this.OpenIncome);
            // 
            // menuIncomeLabel
            // 
            this.menuIncomeLabel.AutoSize = true;
            this.menuIncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuIncomeLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.menuIncomeLabel.Location = new System.Drawing.Point(51, 19);
            this.menuIncomeLabel.Name = "menuIncomeLabel";
            this.menuIncomeLabel.Size = new System.Drawing.Size(84, 20);
            this.menuIncomeLabel.TabIndex = 5;
            this.menuIncomeLabel.Text = "Thu nhập";
            this.menuIncomeLabel.Click += new System.EventHandler(this.OpenIncome);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(73)))), ((int)(((byte)(119)))));
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "QLTaiChinh 1.0";
            // 
            // menuExpensePanel
            // 
            this.menuExpensePanel.BackColor = System.Drawing.Color.White;
            this.menuExpensePanel.Controls.Add(this.menuExpenseImage);
            this.menuExpensePanel.Controls.Add(this.menuExpenseLabel);
            this.menuExpensePanel.Location = new System.Drawing.Point(0, 263);
            this.menuExpensePanel.Name = "menuExpensePanel";
            this.menuExpensePanel.Size = new System.Drawing.Size(193, 50);
            this.menuExpensePanel.TabIndex = 35;
            this.menuExpensePanel.Click += new System.EventHandler(this.OpenExpense);
            // 
            // menuExpenseImage
            // 
            this.menuExpenseImage.Image = global::IncomeExpenseApp.Properties.Resources.ChiTieu;
            this.menuExpenseImage.Location = new System.Drawing.Point(12, 0);
            this.menuExpenseImage.Name = "menuExpenseImage";
            this.menuExpenseImage.Size = new System.Drawing.Size(35, 50);
            this.menuExpenseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuExpenseImage.TabIndex = 6;
            this.menuExpenseImage.TabStop = false;
            this.menuExpenseImage.Click += new System.EventHandler(this.OpenExpense);
            // 
            // menuExpenseLabel
            // 
            this.menuExpenseLabel.AutoSize = true;
            this.menuExpenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuExpenseLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.menuExpenseLabel.Location = new System.Drawing.Point(51, 19);
            this.menuExpenseLabel.Name = "menuExpenseLabel";
            this.menuExpenseLabel.Size = new System.Drawing.Size(70, 20);
            this.menuExpenseLabel.TabIndex = 7;
            this.menuExpenseLabel.Text = "Chi tiêu";
            this.menuExpenseLabel.Click += new System.EventHandler(this.OpenExpense);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IncomeExpenseApp.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(111)))), ((int)(((byte)(141)))));
            this.label8.Location = new System.Drawing.Point(553, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Đại học Kiến trúc Hà Nội";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(111)))), ((int)(((byte)(141)))));
            this.label9.Location = new System.Drawing.Point(896, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Khoa Công nghệ thông tin";
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Image = global::IncomeExpenseApp.Properties.Resources.close1;
            this.exitPictureBox.Location = new System.Drawing.Point(1178, 12);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(25, 25);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 27;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::IncomeExpenseApp.Properties.Resources.logo;
            this.pictureBox9.Location = new System.Drawing.Point(832, 30);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(34, 36);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::IncomeExpenseApp.Properties.Resources.Logo_HAU;
            this.pictureBox8.Location = new System.Drawing.Point(513, 30);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(34, 36);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // planControl1
            // 
            this.planControl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.planControl1.Location = new System.Drawing.Point(193, 97);
            this.planControl1.Margin = new System.Windows.Forms.Padding(4);
            this.planControl1.Name = "planControl1";
            this.planControl1.Size = new System.Drawing.Size(1022, 623);
            this.planControl1.TabIndex = 33;
            this.planControl1.UserId = 0;
            // 
            // dashBoardControl1
            // 
            this.dashBoardControl1.Location = new System.Drawing.Point(193, 97);
            this.dashBoardControl1.Margin = new System.Windows.Forms.Padding(4);
            this.dashBoardControl1.Name = "dashBoardControl1";
            this.dashBoardControl1.Size = new System.Drawing.Size(1022, 623);
            this.dashBoardControl1.TabIndex = 28;
            this.dashBoardControl1.UserId = 0;
            // 
            // viewExpenseControl1
            // 
            this.viewExpenseControl1.Location = new System.Drawing.Point(193, 97);
            this.viewExpenseControl1.Margin = new System.Windows.Forms.Padding(4);
            this.viewExpenseControl1.Name = "viewExpenseControl1";
            this.viewExpenseControl1.Size = new System.Drawing.Size(1022, 623);
            this.viewExpenseControl1.TabIndex = 32;
            this.viewExpenseControl1.UserId = 0;
            // 
            // viewIncomeControl1
            // 
            this.viewIncomeControl1.Location = new System.Drawing.Point(193, 97);
            this.viewIncomeControl1.Margin = new System.Windows.Forms.Padding(4);
            this.viewIncomeControl1.Name = "viewIncomeControl1";
            this.viewIncomeControl1.Size = new System.Drawing.Size(1022, 623);
            this.viewIncomeControl1.TabIndex = 31;
            this.viewIncomeControl1.UserId = 0;
            // 
            // expenseControl1
            // 
            this.expenseControl1.Location = new System.Drawing.Point(193, 97);
            this.expenseControl1.Margin = new System.Windows.Forms.Padding(4);
            this.expenseControl1.Name = "expenseControl1";
            this.expenseControl1.Size = new System.Drawing.Size(1022, 623);
            this.expenseControl1.TabIndex = 30;
            this.expenseControl1.UserId = 0;
            // 
            // incomeControl1
            // 
            this.incomeControl1.Location = new System.Drawing.Point(193, 97);
            this.incomeControl1.Margin = new System.Windows.Forms.Padding(4);
            this.incomeControl1.Name = "incomeControl1";
            this.incomeControl1.Size = new System.Drawing.Size(1022, 623);
            this.incomeControl1.TabIndex = 29;
            this.incomeControl1.UserId = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1215, 720);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dashBoardControl1);
            this.Controls.Add(this.viewExpenseControl1);
            this.Controls.Add(this.viewIncomeControl1);
            this.Controls.Add(this.expenseControl1);
            this.Controls.Add(this.incomeControl1);
            this.Controls.Add(this.planControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài chính";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuPlanPanel.ResumeLayout(false);
            this.menuPlanPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuPlanImage)).EndInit();
            this.menuViewIncomePanel.ResumeLayout(false);
            this.menuViewIncomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuViewIncomeImage)).EndInit();
            this.menuViewExpensePanel.ResumeLayout(false);
            this.menuViewExpensePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuViewExpenseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutImage)).EndInit();
            this.menuDashBoardPanel.ResumeLayout(false);
            this.menuDashBoardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuDashBoardImage)).EndInit();
            this.menuIncomePanel.ResumeLayout(false);
            this.menuIncomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuIncomeImage)).EndInit();
            this.menuExpensePanel.ResumeLayout(false);
            this.menuExpensePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuExpenseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuDashBoardImage;
        private System.Windows.Forms.Label menuDashBoardLabel;
        private System.Windows.Forms.Label menuIncomeLabel;
        private System.Windows.Forms.PictureBox menuIncomeImage;
        private System.Windows.Forms.Label menuExpenseLabel;
        private System.Windows.Forms.PictureBox menuExpenseImage;
        private System.Windows.Forms.Label menuViewIncomeLabel;
        private System.Windows.Forms.PictureBox menuViewIncomeImage;
        private System.Windows.Forms.Label menuViewExpenseLabel;
        private System.Windows.Forms.PictureBox menuViewExpenseImage;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.PictureBox logoutImage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private Controls.DashBoardControl dashBoardControl1;
        private Controls.IncomeControl incomeControl1;
        private Controls.ExpenseControl expenseControl1;
        private Controls.ViewIncomeControl viewIncomeControl1;
        private Controls.ViewExpenseControl viewExpenseControl1;
        private System.Windows.Forms.Panel menuDashBoardPanel;
        private System.Windows.Forms.Panel menuIncomePanel;
        private System.Windows.Forms.Panel menuExpensePanel;
        private System.Windows.Forms.Panel menuViewExpensePanel;
        private System.Windows.Forms.Panel menuViewIncomePanel;
        private Controls.PlanControl planControl1;
        private System.Windows.Forms.Panel menuPlanPanel;
        private System.Windows.Forms.Label menuPlanLabel;
        private System.Windows.Forms.PictureBox menuPlanImage;
    }
}

