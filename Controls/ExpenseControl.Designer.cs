namespace IncomeExpenseApp.Controls
{
    partial class ExpenseControl
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
            this.saveExpenseButton = new System.Windows.Forms.Button();
            this.incomeDetailLabel = new System.Windows.Forms.Label();
            this.expenseDetailText = new System.Windows.Forms.TextBox();
            this.expenseCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.expenseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.expenseAmountText = new System.Windows.Forms.TextBox();
            this.expenseNameText = new System.Windows.Forms.TextBox();
            this.incomeDateLabel = new System.Windows.Forms.Label();
            this.incomeAmountLabel = new System.Windows.Forms.Label();
            this.incomeCategoryLabel = new System.Windows.Forms.Label();
            this.incomeNameLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.notification = new System.Windows.Forms.Label();
            this.expensePlanTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.serialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.expensePlanTable)).BeginInit();
            this.SuspendLayout();
            // 
            // saveExpenseButton
            // 
            this.saveExpenseButton.BackColor = System.Drawing.Color.Cyan;
            this.saveExpenseButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveExpenseButton.Location = new System.Drawing.Point(671, 251);
            this.saveExpenseButton.Name = "saveExpenseButton";
            this.saveExpenseButton.Size = new System.Drawing.Size(250, 57);
            this.saveExpenseButton.TabIndex = 72;
            this.saveExpenseButton.Text = "Lưu khoản chi";
            this.saveExpenseButton.UseVisualStyleBackColor = false;
            this.saveExpenseButton.Click += new System.EventHandler(this.saveExpenseButton_Click);
            // 
            // incomeDetailLabel
            // 
            this.incomeDetailLabel.AutoSize = true;
            this.incomeDetailLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeDetailLabel.Location = new System.Drawing.Point(106, 187);
            this.incomeDetailLabel.Name = "incomeDetailLabel";
            this.incomeDetailLabel.Size = new System.Drawing.Size(170, 23);
            this.incomeDetailLabel.TabIndex = 71;
            this.incomeDetailLabel.Text = "Chi tiết khoản tiêu:";
            // 
            // expenseDetailText
            // 
            this.expenseDetailText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseDetailText.Location = new System.Drawing.Point(110, 213);
            this.expenseDetailText.Multiline = true;
            this.expenseDetailText.Name = "expenseDetailText";
            this.expenseDetailText.Size = new System.Drawing.Size(541, 32);
            this.expenseDetailText.TabIndex = 70;
            // 
            // expenseCategoryComboBox
            // 
            this.expenseCategoryComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseCategoryComboBox.FormattingEnabled = true;
            this.expenseCategoryComboBox.Location = new System.Drawing.Point(390, 144);
            this.expenseCategoryComboBox.Name = "expenseCategoryComboBox";
            this.expenseCategoryComboBox.Size = new System.Drawing.Size(250, 31);
            this.expenseCategoryComboBox.TabIndex = 69;
            // 
            // expenseDatePicker
            // 
            this.expenseDatePicker.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseDatePicker.Location = new System.Drawing.Point(671, 213);
            this.expenseDatePicker.Name = "expenseDatePicker";
            this.expenseDatePicker.Size = new System.Drawing.Size(250, 32);
            this.expenseDatePicker.TabIndex = 68;
            // 
            // expenseAmountText
            // 
            this.expenseAmountText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseAmountText.Location = new System.Drawing.Point(671, 144);
            this.expenseAmountText.Name = "expenseAmountText";
            this.expenseAmountText.Size = new System.Drawing.Size(250, 32);
            this.expenseAmountText.TabIndex = 67;
            // 
            // expenseNameText
            // 
            this.expenseNameText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseNameText.Location = new System.Drawing.Point(110, 143);
            this.expenseNameText.Name = "expenseNameText";
            this.expenseNameText.Size = new System.Drawing.Size(250, 32);
            this.expenseNameText.TabIndex = 66;
            // 
            // incomeDateLabel
            // 
            this.incomeDateLabel.AutoSize = true;
            this.incomeDateLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeDateLabel.Location = new System.Drawing.Point(667, 187);
            this.incomeDateLabel.Name = "incomeDateLabel";
            this.incomeDateLabel.Size = new System.Drawing.Size(89, 23);
            this.incomeDateLabel.TabIndex = 65;
            this.incomeDateLabel.Text = "Ngày chi:";
            // 
            // incomeAmountLabel
            // 
            this.incomeAmountLabel.AutoSize = true;
            this.incomeAmountLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeAmountLabel.Location = new System.Drawing.Point(667, 118);
            this.incomeAmountLabel.Name = "incomeAmountLabel";
            this.incomeAmountLabel.Size = new System.Drawing.Size(74, 23);
            this.incomeAmountLabel.TabIndex = 64;
            this.incomeAmountLabel.Text = "Số tiền:";
            // 
            // incomeCategoryLabel
            // 
            this.incomeCategoryLabel.AutoSize = true;
            this.incomeCategoryLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeCategoryLabel.Location = new System.Drawing.Point(386, 118);
            this.incomeCategoryLabel.Name = "incomeCategoryLabel";
            this.incomeCategoryLabel.Size = new System.Drawing.Size(101, 23);
            this.incomeCategoryLabel.TabIndex = 63;
            this.incomeCategoryLabel.Text = "Danh mục:";
            // 
            // incomeNameLabel
            // 
            this.incomeNameLabel.AutoSize = true;
            this.incomeNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeNameLabel.Location = new System.Drawing.Point(106, 117);
            this.incomeNameLabel.Name = "incomeNameLabel";
            this.incomeNameLabel.Size = new System.Drawing.Size(169, 23);
            this.incomeNameLabel.TabIndex = 62;
            this.incomeNameLabel.Text = "Tên khoản chi tiêu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(316, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(335, 50);
            this.label11.TabIndex = 61;
            this.label11.Text = "CHI TIẾT TIÊU PHÍ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(720, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 50);
            this.label10.TabIndex = 60;
            // 
            // notification
            // 
            this.notification.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification.ForeColor = System.Drawing.Color.Red;
            this.notification.Location = new System.Drawing.Point(671, 314);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(250, 43);
            this.notification.TabIndex = 73;
            this.notification.Text = "Thông báo";
            this.notification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notification.Visible = false;
            // 
            // expensePlanTable
            // 
            this.expensePlanTable.AllowUserToAddRows = false;
            this.expensePlanTable.AllowUserToDeleteRows = false;
            this.expensePlanTable.AllowUserToResizeColumns = false;
            this.expensePlanTable.AllowUserToResizeRows = false;
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
            this.expensePlanTable.Location = new System.Drawing.Point(110, 360);
            this.expensePlanTable.MultiSelect = false;
            this.expensePlanTable.Name = "expensePlanTable";
            this.expensePlanTable.ReadOnly = true;
            this.expensePlanTable.RowHeadersVisible = false;
            this.expensePlanTable.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.expensePlanTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.expensePlanTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expensePlanTable.Size = new System.Drawing.Size(811, 225);
            this.expensePlanTable.TabIndex = 74;
            this.expensePlanTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.expensePlanTable_DataBindingComplete);
            this.expensePlanTable.SelectionChanged += new System.EventHandler(this.expensePlanTable_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 50);
            this.label1.TabIndex = 75;
            this.label1.Text = "KẾ HOẠCH CHI TIÊU";
            // 
            // serialNumber
            // 
            this.serialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.serialNumber.Frozen = true;
            this.serialNumber.HeaderText = "STT";
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.ReadOnly = true;
            // 
            // ExpenseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expensePlanTable);
            this.Controls.Add(this.notification);
            this.Controls.Add(this.saveExpenseButton);
            this.Controls.Add(this.incomeDetailLabel);
            this.Controls.Add(this.expenseDetailText);
            this.Controls.Add(this.expenseCategoryComboBox);
            this.Controls.Add(this.expenseDatePicker);
            this.Controls.Add(this.expenseAmountText);
            this.Controls.Add(this.expenseNameText);
            this.Controls.Add(this.incomeDateLabel);
            this.Controls.Add(this.incomeAmountLabel);
            this.Controls.Add(this.incomeCategoryLabel);
            this.Controls.Add(this.incomeNameLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Name = "ExpenseControl";
            this.Size = new System.Drawing.Size(1022, 623);
            ((System.ComponentModel.ISupportInitialize)(this.expensePlanTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveExpenseButton;
        private System.Windows.Forms.Label incomeDetailLabel;
        private System.Windows.Forms.TextBox expenseDetailText;
        private System.Windows.Forms.ComboBox expenseCategoryComboBox;
        private System.Windows.Forms.DateTimePicker expenseDatePicker;
        private System.Windows.Forms.TextBox expenseAmountText;
        private System.Windows.Forms.TextBox expenseNameText;
        private System.Windows.Forms.Label incomeDateLabel;
        private System.Windows.Forms.Label incomeAmountLabel;
        private System.Windows.Forms.Label incomeCategoryLabel;
        private System.Windows.Forms.Label incomeNameLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label notification;
        private System.Windows.Forms.DataGridView expensePlanTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumber;
    }
}
