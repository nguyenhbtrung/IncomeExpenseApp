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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ViewExpenseTable = new System.Windows.Forms.DataGridView();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewexpenseCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.expenseNameText = new System.Windows.Forms.TextBox();
            this.incomeCategoryLabel = new System.Windows.Forms.Label();
            this.incomeNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SearchExpenseButton = new System.Windows.Forms.Button();
            this.RefreshExpenseButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaLịchSửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ViewExpenseTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewExpenseTable
            // 
            this.ViewExpenseTable.AllowUserToAddRows = false;
            this.ViewExpenseTable.AllowUserToDeleteRows = false;
            this.ViewExpenseTable.AllowUserToResizeColumns = false;
            this.ViewExpenseTable.AllowUserToResizeRows = false;
            this.ViewExpenseTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ViewExpenseTable.BackgroundColor = System.Drawing.Color.White;
            this.ViewExpenseTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewExpenseTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.ViewExpenseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewExpenseTable.DefaultCellStyle = dataGridViewCellStyle11;
            this.ViewExpenseTable.Location = new System.Drawing.Point(9, 179);
            this.ViewExpenseTable.Name = "ViewExpenseTable";
            this.ViewExpenseTable.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewExpenseTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.ViewExpenseTable.RowHeadersVisible = false;
            this.ViewExpenseTable.Size = new System.Drawing.Size(1004, 435);
            this.ViewExpenseTable.TabIndex = 70;
            this.ViewExpenseTable.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ViewExpenseTable_CellMouseUp);
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataMember = "Expense";
            // 
            // viewexpenseCategoryComboBox
            // 
            this.viewexpenseCategoryComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewexpenseCategoryComboBox.FormattingEnabled = true;
            this.viewexpenseCategoryComboBox.Location = new System.Drawing.Point(597, 141);
            this.viewexpenseCategoryComboBox.Name = "viewexpenseCategoryComboBox";
            this.viewexpenseCategoryComboBox.Size = new System.Drawing.Size(250, 31);
            this.viewexpenseCategoryComboBox.TabIndex = 69;
            this.viewexpenseCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.viewexpenseCategoryComboBox_SelectedIndexChanged);
            // 
            // expenseNameText
            // 
            this.expenseNameText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseNameText.Location = new System.Drawing.Point(194, 141);
            this.expenseNameText.Name = "expenseNameText";
            this.expenseNameText.Size = new System.Drawing.Size(250, 32);
            this.expenseNameText.TabIndex = 68;
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
            // SearchExpenseButton
            // 
            this.SearchExpenseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchExpenseButton.Location = new System.Drawing.Point(473, 141);
            this.SearchExpenseButton.Name = "SearchExpenseButton";
            this.SearchExpenseButton.Size = new System.Drawing.Size(98, 32);
            this.SearchExpenseButton.TabIndex = 71;
            this.SearchExpenseButton.Text = "Tìm kiếm";
            this.SearchExpenseButton.UseVisualStyleBackColor = true;
            this.SearchExpenseButton.Click += new System.EventHandler(this.SearchExpenseButton_Click);
            // 
            // RefreshExpenseButton
            // 
            this.RefreshExpenseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshExpenseButton.Location = new System.Drawing.Point(876, 140);
            this.RefreshExpenseButton.Name = "RefreshExpenseButton";
            this.RefreshExpenseButton.Size = new System.Drawing.Size(98, 32);
            this.RefreshExpenseButton.TabIndex = 72;
            this.RefreshExpenseButton.Text = "Làm mới";
            this.RefreshExpenseButton.UseVisualStyleBackColor = true;
            this.RefreshExpenseButton.Click += new System.EventHandler(this.RefreshExpense);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaLịchSửToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 26);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // xóaLịchSửToolStripMenuItem
            // 
            this.xóaLịchSửToolStripMenuItem.Name = "xóaLịchSửToolStripMenuItem";
            this.xóaLịchSửToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.xóaLịchSửToolStripMenuItem.Text = "Xóa lịch sử";
            // 
            // ViewExpenseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RefreshExpenseButton);
            this.Controls.Add(this.SearchExpenseButton);
            this.Controls.Add(this.ViewExpenseTable);
            this.Controls.Add(this.viewexpenseCategoryComboBox);
            this.Controls.Add(this.expenseNameText);
            this.Controls.Add(this.incomeCategoryLabel);
            this.Controls.Add(this.incomeNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "ViewExpenseControl";
            this.Size = new System.Drawing.Size(1022, 623);
            ((System.ComponentModel.ISupportInitialize)(this.ViewExpenseTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewExpenseTable;
        private System.Windows.Forms.ComboBox viewexpenseCategoryComboBox;
        private System.Windows.Forms.TextBox expenseNameText;
        private System.Windows.Forms.Label incomeCategoryLabel;
        private System.Windows.Forms.Label incomeNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private System.Windows.Forms.Button SearchExpenseButton;
        private System.Windows.Forms.Button RefreshExpenseButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaLịchSửToolStripMenuItem;
    }
}
