namespace IncomeExpenseApp.Controls
{
    partial class ViewIncomeControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ViewIncomeTable = new System.Windows.Forms.DataGridView();
            this.incomeCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.incomeNameText = new System.Windows.Forms.TextBox();
            this.incomeCategoryLabel = new System.Windows.Forms.Label();
            this.incomeNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.incomeExpenseDataSet = new IncomeExpenseApp.IncomeExpenseDataSet();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomeTableAdapter = new IncomeExpenseApp.IncomeExpenseDataSetTableAdapters.IncomeTableAdapter();
            this.incIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incDesciptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ViewIncomeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeExpenseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewIncomeTable
            // 
            this.ViewIncomeTable.AllowUserToAddRows = false;
            this.ViewIncomeTable.AllowUserToDeleteRows = false;
            this.ViewIncomeTable.AutoGenerateColumns = false;
            this.ViewIncomeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ViewIncomeTable.BackgroundColor = System.Drawing.Color.White;
            this.ViewIncomeTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewIncomeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewIncomeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewIncomeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incIdDataGridViewTextBoxColumn,
            this.incNameDataGridViewTextBoxColumn,
            this.incCategoryDataGridViewTextBoxColumn,
            this.incAmountDataGridViewTextBoxColumn,
            this.incDateDataGridViewTextBoxColumn,
            this.incDesciptionDataGridViewTextBoxColumn});
            this.ViewIncomeTable.DataSource = this.incomeBindingSource;
            this.ViewIncomeTable.Location = new System.Drawing.Point(9, 179);
            this.ViewIncomeTable.Name = "ViewIncomeTable";
            this.ViewIncomeTable.ReadOnly = true;
            this.ViewIncomeTable.RowHeadersVisible = false;
            this.ViewIncomeTable.Size = new System.Drawing.Size(1004, 435);
            this.ViewIncomeTable.TabIndex = 39;
            // 
            // incomeCategoryComboBox
            // 
            this.incomeCategoryComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeCategoryComboBox.FormattingEnabled = true;
            this.incomeCategoryComboBox.Location = new System.Drawing.Point(597, 141);
            this.incomeCategoryComboBox.Name = "incomeCategoryComboBox";
            this.incomeCategoryComboBox.Size = new System.Drawing.Size(250, 31);
            this.incomeCategoryComboBox.TabIndex = 38;
            // 
            // incomeNameText
            // 
            this.incomeNameText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeNameText.Location = new System.Drawing.Point(194, 141);
            this.incomeNameText.Name = "incomeNameText";
            this.incomeNameText.Size = new System.Drawing.Size(250, 32);
            this.incomeNameText.TabIndex = 37;
            // 
            // incomeCategoryLabel
            // 
            this.incomeCategoryLabel.AutoSize = true;
            this.incomeCategoryLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeCategoryLabel.Location = new System.Drawing.Point(593, 115);
            this.incomeCategoryLabel.Name = "incomeCategoryLabel";
            this.incomeCategoryLabel.Size = new System.Drawing.Size(101, 23);
            this.incomeCategoryLabel.TabIndex = 36;
            this.incomeCategoryLabel.Text = "Danh mục:";
            // 
            // incomeNameLabel
            // 
            this.incomeNameLabel.AutoSize = true;
            this.incomeNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeNameLabel.Location = new System.Drawing.Point(190, 115);
            this.incomeNameLabel.Name = "incomeNameLabel";
            this.incomeNameLabel.Size = new System.Drawing.Size(134, 23);
            this.incomeNameLabel.TabIndex = 35;
            this.incomeNameLabel.Text = "Tên khoản thu:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(310, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(412, 50);
            this.nameLabel.TabIndex = 34;
            this.nameLabel.Text = "THỐNG KÊ THU NHẬP";
            // 
            // incomeExpenseDataSet
            // 
            this.incomeExpenseDataSet.DataSetName = "IncomeExpenseDataSet";
            this.incomeExpenseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataMember = "Income";
            this.incomeBindingSource.DataSource = this.incomeExpenseDataSet;
            // 
            // incomeTableAdapter
            // 
            this.incomeTableAdapter.ClearBeforeFill = true;
            // 
            // incIdDataGridViewTextBoxColumn
            // 
            this.incIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.incIdDataGridViewTextBoxColumn.DataPropertyName = "incId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.incIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.incIdDataGridViewTextBoxColumn.Frozen = true;
            this.incIdDataGridViewTextBoxColumn.HeaderText = "STT";
            this.incIdDataGridViewTextBoxColumn.Name = "incIdDataGridViewTextBoxColumn";
            this.incIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.incIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.incIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // incNameDataGridViewTextBoxColumn
            // 
            this.incNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.incNameDataGridViewTextBoxColumn.DataPropertyName = "incName";
            this.incNameDataGridViewTextBoxColumn.Frozen = true;
            this.incNameDataGridViewTextBoxColumn.HeaderText = "Tên khoản thu";
            this.incNameDataGridViewTextBoxColumn.Name = "incNameDataGridViewTextBoxColumn";
            this.incNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.incNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.incNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.incNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // incCategoryDataGridViewTextBoxColumn
            // 
            this.incCategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.incCategoryDataGridViewTextBoxColumn.DataPropertyName = "incCategory";
            this.incCategoryDataGridViewTextBoxColumn.Frozen = true;
            this.incCategoryDataGridViewTextBoxColumn.HeaderText = "Danh mục";
            this.incCategoryDataGridViewTextBoxColumn.Name = "incCategoryDataGridViewTextBoxColumn";
            this.incCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.incCategoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.incCategoryDataGridViewTextBoxColumn.Width = 200;
            // 
            // incAmountDataGridViewTextBoxColumn
            // 
            this.incAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.incAmountDataGridViewTextBoxColumn.DataPropertyName = "incAmount";
            this.incAmountDataGridViewTextBoxColumn.Frozen = true;
            this.incAmountDataGridViewTextBoxColumn.HeaderText = "Số tiền";
            this.incAmountDataGridViewTextBoxColumn.Name = "incAmountDataGridViewTextBoxColumn";
            this.incAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.incAmountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.incAmountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // incDateDataGridViewTextBoxColumn
            // 
            this.incDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.incDateDataGridViewTextBoxColumn.DataPropertyName = "incDate";
            this.incDateDataGridViewTextBoxColumn.Frozen = true;
            this.incDateDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.incDateDataGridViewTextBoxColumn.Name = "incDateDataGridViewTextBoxColumn";
            this.incDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.incDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.incDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // incDesciptionDataGridViewTextBoxColumn
            // 
            this.incDesciptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.incDesciptionDataGridViewTextBoxColumn.DataPropertyName = "incDesciption";
            this.incDesciptionDataGridViewTextBoxColumn.Frozen = true;
            this.incDesciptionDataGridViewTextBoxColumn.HeaderText = "Chi tiết";
            this.incDesciptionDataGridViewTextBoxColumn.Name = "incDesciptionDataGridViewTextBoxColumn";
            this.incDesciptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.incDesciptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.incDesciptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.incDesciptionDataGridViewTextBoxColumn.Width = 354;
            // 
            // ViewIncomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewIncomeTable);
            this.Controls.Add(this.incomeCategoryComboBox);
            this.Controls.Add(this.incomeNameText);
            this.Controls.Add(this.incomeCategoryLabel);
            this.Controls.Add(this.incomeNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "ViewIncomeControl";
            this.Size = new System.Drawing.Size(1022, 623);
            ((System.ComponentModel.ISupportInitialize)(this.ViewIncomeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeExpenseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewIncomeTable;
        private System.Windows.Forms.ComboBox incomeCategoryComboBox;
        private System.Windows.Forms.TextBox incomeNameText;
        private System.Windows.Forms.Label incomeCategoryLabel;
        private System.Windows.Forms.Label incomeNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private IncomeExpenseDataSet incomeExpenseDataSet;
        private IncomeExpenseDataSetTableAdapters.IncomeTableAdapter incomeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn incIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incDesciptionDataGridViewTextBoxColumn;
    }
}
