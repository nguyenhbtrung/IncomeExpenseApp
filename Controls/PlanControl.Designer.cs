namespace IncomeExpenseApp.Controls
{
    partial class PlanControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.expensePlanTable = new System.Windows.Forms.DataGridView();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.budgetPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.expectedExpenseLabel = new System.Windows.Forms.Label();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.serialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.expensePlanTable)).BeginInit();
            this.budgetPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // expensePlanTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.expensePlanTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.expensePlanTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expensePlanTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.expensePlanTable.BackgroundColor = System.Drawing.Color.White;
            this.expensePlanTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expensePlanTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.expensePlanTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expensePlanTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.expensePlanTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expensePlanTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNumber});
            this.expensePlanTable.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expensePlanTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.expensePlanTable.EnableHeadersVisualStyles = false;
            this.expensePlanTable.Location = new System.Drawing.Point(27, 21);
            this.expensePlanTable.MultiSelect = false;
            this.expensePlanTable.Name = "expensePlanTable";
            this.expensePlanTable.ReadOnly = true;
            this.expensePlanTable.RowHeadersVisible = false;
            this.expensePlanTable.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.expensePlanTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.expensePlanTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expensePlanTable.Size = new System.Drawing.Size(908, 295);
            this.expensePlanTable.TabIndex = 0;
            this.expensePlanTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.expensePlanTable_DataBindingComplete);
            this.expensePlanTable.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.expensePlanTable_RowPostPaint);
            this.expensePlanTable.SelectionChanged += new System.EventHandler(this.expensePlanTable_SelectionChanged);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.categoryTextBox.Location = new System.Drawing.Point(376, 56);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(221, 29);
            this.categoryTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nameTextBox.Location = new System.Drawing.Point(134, 56);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(214, 29);
            this.nameTextBox.TabIndex = 3;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.amountTextBox.Location = new System.Drawing.Point(134, 144);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(214, 29);
            this.amountTextBox.TabIndex = 4;
            // 
            // budgetPanel
            // 
            this.budgetPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.budgetPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.budgetPanel.Controls.Add(this.label10);
            this.budgetPanel.Controls.Add(this.expectedExpenseLabel);
            this.budgetPanel.Controls.Add(this.budgetLabel);
            this.budgetPanel.Controls.Add(this.label2);
            this.budgetPanel.Controls.Add(this.label1);
            this.budgetPanel.Location = new System.Drawing.Point(27, 25);
            this.budgetPanel.Name = "budgetPanel";
            this.budgetPanel.Size = new System.Drawing.Size(254, 108);
            this.budgetPanel.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(112, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 39);
            this.label10.TabIndex = 9;
            this.label10.Text = "|";
            // 
            // expectedExpenseLabel
            // 
            this.expectedExpenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expectedExpenseLabel.ForeColor = System.Drawing.Color.Gray;
            this.expectedExpenseLabel.Location = new System.Drawing.Point(136, 44);
            this.expectedExpenseLabel.Name = "expectedExpenseLabel";
            this.expectedExpenseLabel.Size = new System.Drawing.Size(113, 29);
            this.expectedExpenseLabel.TabIndex = 8;
            this.expectedExpenseLabel.Text = "0";
            this.expectedExpenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // budgetLabel
            // 
            this.budgetLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.budgetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetLabel.ForeColor = System.Drawing.Color.Red;
            this.budgetLabel.Location = new System.Drawing.Point(3, 39);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(109, 39);
            this.budgetLabel.TabIndex = 7;
            this.budgetLabel.Text = "0";
            this.budgetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(132, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chi tiêu dự kiến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngân sách";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Control;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addButton.Location = new System.Drawing.Point(26, 25);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 31);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Thêm";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteButton.Location = new System.Drawing.Point(26, 142);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 31);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Xoá";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAllButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteAllButton.Location = new System.Drawing.Point(27, 151);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(254, 31);
            this.deleteAllButton.TabIndex = 9;
            this.deleteAllButton.Text = "Xoá toàn bộ";
            this.deleteAllButton.UseVisualStyleBackColor = false;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(130, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên khoản chi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(373, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Danh mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(130, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(373, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày chi";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "  dd/MM/yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(377, 144);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker.Size = new System.Drawing.Size(220, 29);
            this.dateTimePicker.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.deleteAllButton);
            this.panel2.Controls.Add(this.budgetPanel);
            this.panel2.Location = new System.Drawing.Point(25, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 201);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.expensePlanTable);
            this.panel3.Location = new System.Drawing.Point(25, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(967, 344);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.saveButton);
            this.panel4.Controls.Add(this.deleteButton);
            this.panel4.Controls.Add(this.dateTimePicker);
            this.panel4.Controls.Add(this.amountTextBox);
            this.panel4.Controls.Add(this.addButton);
            this.panel4.Controls.Add(this.categoryTextBox);
            this.panel4.Controls.Add(this.nameTextBox);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(363, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(629, 201);
            this.panel4.TabIndex = 18;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.saveButton.Location = new System.Drawing.Point(26, 84);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 31);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Lưu";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // serialNumber
            // 
            this.serialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.serialNumber.Frozen = true;
            this.serialNumber.HeaderText = "STT";
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.ReadOnly = true;
            // 
            // PlanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "PlanControl";
            this.Size = new System.Drawing.Size(1022, 623);
            ((System.ComponentModel.ISupportInitialize)(this.expensePlanTable)).EndInit();
            this.budgetPanel.ResumeLayout(false);
            this.budgetPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView expensePlanTable;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Panel budgetPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button deleteAllButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.Label expectedExpenseLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumber;
    }
}
