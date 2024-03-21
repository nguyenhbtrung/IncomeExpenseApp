namespace IncomeExpenseApp.Controls
{
    partial class ViewExpenseControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ViewExpenseTable = new System.Windows.Forms.DataGridView();
            this.incomeCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.incomeNameText = new System.Windows.Forms.TextBox();
            this.incomeCategoryLabel = new System.Windows.Forms.Label();
            this.incomeNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.incomeExpenseDataSet1 = new IncomeExpenseApp.IncomeExpenseDataSet1();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseTableAdapter = new IncomeExpenseApp.IncomeExpenseDataSet1TableAdapters.ExpenseTableAdapter();
            this.exIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exDesciptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ViewExpenseTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeExpenseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewExpenseTable
            // 
            this.ViewExpenseTable.AllowUserToAddRows = false;
            this.ViewExpenseTable.AllowUserToDeleteRows = false;
            this.ViewExpenseTable.AutoGenerateColumns = false;
            this.ViewExpenseTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ViewExpenseTable.BackgroundColor = System.Drawing.Color.White;
            this.ViewExpenseTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewExpenseTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewExpenseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewExpenseTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exIdDataGridViewTextBoxColumn,
            this.exNameDataGridViewTextBoxColumn,
            this.exCategoryDataGridViewTextBoxColumn,
            this.exAmountDataGridViewTextBoxColumn,
            this.exDateDataGridViewTextBoxColumn,
            this.exDesciptionDataGridViewTextBoxColumn});
            this.ViewExpenseTable.DataSource = this.expenseBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewExpenseTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.ViewExpenseTable.Location = new System.Drawing.Point(9, 179);
            this.ViewExpenseTable.Name = "ViewExpenseTable";
            this.ViewExpenseTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewExpenseTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ViewExpenseTable.RowHeadersVisible = false;
            this.ViewExpenseTable.Size = new System.Drawing.Size(1004, 435);
            this.ViewExpenseTable.TabIndex = 70;
            this.ViewExpenseTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewExpenseTable_CellContentClick);
            // 
            // incomeCategoryComboBox
            // 
            this.incomeCategoryComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeCategoryComboBox.FormattingEnabled = true;
            this.incomeCategoryComboBox.Location = new System.Drawing.Point(597, 141);
            this.incomeCategoryComboBox.Name = "incomeCategoryComboBox";
            this.incomeCategoryComboBox.Size = new System.Drawing.Size(250, 31);
            this.incomeCategoryComboBox.TabIndex = 69;
            // 
            // incomeNameText
            // 
            this.incomeNameText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeNameText.Location = new System.Drawing.Point(194, 141);
            this.incomeNameText.Name = "incomeNameText";
            this.incomeNameText.Size = new System.Drawing.Size(250, 32);
            this.incomeNameText.TabIndex = 68;
            // 
            // incomeCategoryLabel
            // 
            this.incomeCategoryLabel.AutoSize = true;
            this.incomeCategoryLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeCategoryLabel.Location = new System.Drawing.Point(593, 115);
            this.incomeCategoryLabel.Name = "incomeCategoryLabel";
            this.incomeCategoryLabel.Size = new System.Drawing.Size(101, 23);
            this.incomeCategoryLabel.TabIndex = 67;
            this.incomeCategoryLabel.Text = "Danh mục:";
            // 
            // incomeNameLabel
            // 
            this.incomeNameLabel.AutoSize = true;
            this.incomeNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeNameLabel.Location = new System.Drawing.Point(190, 115);
            this.incomeNameLabel.Name = "incomeNameLabel";
            this.incomeNameLabel.Size = new System.Drawing.Size(139, 23);
            this.incomeNameLabel.TabIndex = 66;
            this.incomeNameLabel.Text = "Tên khoản tiêu:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(310, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(373, 50);
            this.nameLabel.TabIndex = 65;
            this.nameLabel.Text = "THỐNG KÊ CHI TIÊU";
            // 
            // incomeExpenseDataSet1
            // 
            this.incomeExpenseDataSet1.DataSetName = "IncomeExpenseDataSet1";
            this.incomeExpenseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataMember = "Expense";
            this.expenseBindingSource.DataSource = this.incomeExpenseDataSet1;
            // 
            // expenseTableAdapter
            // 
            this.expenseTableAdapter.ClearBeforeFill = true;
            // 
            // exIdDataGridViewTextBoxColumn
            // 
            this.exIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.exIdDataGridViewTextBoxColumn.DataPropertyName = "exId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.exIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.exIdDataGridViewTextBoxColumn.HeaderText = "STT";
            this.exIdDataGridViewTextBoxColumn.Name = "exIdDataGridViewTextBoxColumn";
            this.exIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.exIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.exIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // exNameDataGridViewTextBoxColumn
            // 
            this.exNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.exNameDataGridViewTextBoxColumn.DataPropertyName = "exName";
            this.exNameDataGridViewTextBoxColumn.HeaderText = "Tên khoản chi";
            this.exNameDataGridViewTextBoxColumn.Name = "exNameDataGridViewTextBoxColumn";
            this.exNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.exNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.exNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.exNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // exCategoryDataGridViewTextBoxColumn
            // 
            this.exCategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.exCategoryDataGridViewTextBoxColumn.DataPropertyName = "exCategory";
            this.exCategoryDataGridViewTextBoxColumn.HeaderText = "Danh mục";
            this.exCategoryDataGridViewTextBoxColumn.Name = "exCategoryDataGridViewTextBoxColumn";
            this.exCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.exCategoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.exCategoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.exCategoryDataGridViewTextBoxColumn.Width = 200;
            // 
            // exAmountDataGridViewTextBoxColumn
            // 
            this.exAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.exAmountDataGridViewTextBoxColumn.DataPropertyName = "exAmount";
            this.exAmountDataGridViewTextBoxColumn.HeaderText = "Số tiền";
            this.exAmountDataGridViewTextBoxColumn.Name = "exAmountDataGridViewTextBoxColumn";
            this.exAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.exAmountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.exAmountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // exDateDataGridViewTextBoxColumn
            // 
            this.exDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.exDateDataGridViewTextBoxColumn.DataPropertyName = "exDate";
            this.exDateDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.exDateDataGridViewTextBoxColumn.Name = "exDateDataGridViewTextBoxColumn";
            this.exDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.exDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.exDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // exDesciptionDataGridViewTextBoxColumn
            // 
            this.exDesciptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.exDesciptionDataGridViewTextBoxColumn.DataPropertyName = "exDesciption";
            this.exDesciptionDataGridViewTextBoxColumn.HeaderText = "Chi tiết";
            this.exDesciptionDataGridViewTextBoxColumn.Name = "exDesciptionDataGridViewTextBoxColumn";
            this.exDesciptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.exDesciptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.exDesciptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.exDesciptionDataGridViewTextBoxColumn.Width = 354;
            // 
            // ViewExpenseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewExpenseTable);
            this.Controls.Add(this.incomeCategoryComboBox);
            this.Controls.Add(this.incomeNameText);
            this.Controls.Add(this.incomeCategoryLabel);
            this.Controls.Add(this.incomeNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "ViewExpenseControl";
            this.Size = new System.Drawing.Size(1022, 623);
            ((System.ComponentModel.ISupportInitialize)(this.ViewExpenseTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeExpenseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewExpenseTable;
        private System.Windows.Forms.ComboBox incomeCategoryComboBox;
        private System.Windows.Forms.TextBox incomeNameText;
        private System.Windows.Forms.Label incomeCategoryLabel;
        private System.Windows.Forms.Label incomeNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private IncomeExpenseDataSet1 incomeExpenseDataSet1;
        private IncomeExpenseDataSet1TableAdapters.ExpenseTableAdapter expenseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn exIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exDesciptionDataGridViewTextBoxColumn;
    }
}
