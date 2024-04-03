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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ViewIncomeTable = new System.Windows.Forms.DataGridView();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewincomeCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.incomeNameText = new System.Windows.Forms.TextBox();
            this.incomeCategoryLabel = new System.Windows.Forms.Label();
            this.incomeNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SearchIncomeButton = new System.Windows.Forms.Button();
            this.RefreshIncomeButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewIncomeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewIncomeTable
            // 
            this.ViewIncomeTable.AllowUserToAddRows = false;
            this.ViewIncomeTable.AllowUserToDeleteRows = false;
            this.ViewIncomeTable.AllowUserToResizeColumns = false;
            this.ViewIncomeTable.AllowUserToResizeRows = false;
            this.ViewIncomeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ViewIncomeTable.BackgroundColor = System.Drawing.Color.White;
            this.ViewIncomeTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewIncomeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.ViewIncomeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewIncomeTable.Location = new System.Drawing.Point(9, 179);
            this.ViewIncomeTable.Name = "ViewIncomeTable";
            this.ViewIncomeTable.ReadOnly = true;
            this.ViewIncomeTable.RowHeadersVisible = false;
            this.ViewIncomeTable.Size = new System.Drawing.Size(1004, 435);
            this.ViewIncomeTable.TabIndex = 39;
            this.ViewIncomeTable.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ViewIncomeTable_CellMouseUp);
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataMember = "Income";
            // 
            // viewincomeCategoryComboBox
            // 
            this.viewincomeCategoryComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewincomeCategoryComboBox.FormattingEnabled = true;
            this.viewincomeCategoryComboBox.Location = new System.Drawing.Point(408, 139);
            this.viewincomeCategoryComboBox.Name = "viewincomeCategoryComboBox";
            this.viewincomeCategoryComboBox.Size = new System.Drawing.Size(250, 31);
            this.viewincomeCategoryComboBox.TabIndex = 38;
            this.viewincomeCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.viewincomeCategoryComboBox_SelectedIndexChanged);
            // 
            // incomeNameText
            // 
            this.incomeNameText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeNameText.Location = new System.Drawing.Point(48, 140);
            this.incomeNameText.Name = "incomeNameText";
            this.incomeNameText.Size = new System.Drawing.Size(250, 32);
            this.incomeNameText.TabIndex = 37;
            // 
            // incomeCategoryLabel
            // 
            this.incomeCategoryLabel.AutoSize = true;
            this.incomeCategoryLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeCategoryLabel.Location = new System.Drawing.Point(404, 113);
            this.incomeCategoryLabel.Name = "incomeCategoryLabel";
            this.incomeCategoryLabel.Size = new System.Drawing.Size(101, 23);
            this.incomeCategoryLabel.TabIndex = 36;
            this.incomeCategoryLabel.Text = "Danh mục:";
            // 
            // incomeNameLabel
            // 
            this.incomeNameLabel.AutoSize = true;
            this.incomeNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeNameLabel.Location = new System.Drawing.Point(44, 114);
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
            // SearchIncomeButton
            // 
            this.SearchIncomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchIncomeButton.Location = new System.Drawing.Point(304, 140);
            this.SearchIncomeButton.Name = "SearchIncomeButton";
            this.SearchIncomeButton.Size = new System.Drawing.Size(98, 32);
            this.SearchIncomeButton.TabIndex = 40;
            this.SearchIncomeButton.Text = "Tìm kiếm";
            this.SearchIncomeButton.UseVisualStyleBackColor = true;
            this.SearchIncomeButton.Click += new System.EventHandler(this.SearchIncomeButton_Click);
            // 
            // RefreshIncomeButton
            // 
            this.RefreshIncomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshIncomeButton.Location = new System.Drawing.Point(664, 139);
            this.RefreshIncomeButton.Name = "RefreshIncomeButton";
            this.RefreshIncomeButton.Size = new System.Drawing.Size(98, 32);
            this.RefreshIncomeButton.TabIndex = 41;
            this.RefreshIncomeButton.Text = "Làm mới";
            this.RefreshIncomeButton.UseVisualStyleBackColor = true;
            this.RefreshIncomeButton.Click += new System.EventHandler(this.RefreshIncome_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaDữLiệuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 26);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click_1);
            // 
            // xóaDữLiệuToolStripMenuItem
            // 
            this.xóaDữLiệuToolStripMenuItem.Name = "xóaDữLiệuToolStripMenuItem";
            this.xóaDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.xóaDữLiệuToolStripMenuItem.Text = "Xóa lịch sử";
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(768, 138);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(98, 32);
            this.editButton.TabIndex = 42;
            this.editButton.Text = "Sửa";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(872, 138);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 32);
            this.saveButton.TabIndex = 43;
            this.saveButton.Text = "Lưu";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ViewIncomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.RefreshIncomeButton);
            this.Controls.Add(this.SearchIncomeButton);
            this.Controls.Add(this.ViewIncomeTable);
            this.Controls.Add(this.viewincomeCategoryComboBox);
            this.Controls.Add(this.incomeNameText);
            this.Controls.Add(this.incomeCategoryLabel);
            this.Controls.Add(this.incomeNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "ViewIncomeControl";
            this.Size = new System.Drawing.Size(1022, 623);
            ((System.ComponentModel.ISupportInitialize)(this.ViewIncomeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewIncomeTable;
        private System.Windows.Forms.ComboBox viewincomeCategoryComboBox;
        private System.Windows.Forms.TextBox incomeNameText;
        private System.Windows.Forms.Label incomeCategoryLabel;
        private System.Windows.Forms.Label incomeNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private System.Windows.Forms.Button SearchIncomeButton;
        private System.Windows.Forms.Button RefreshIncomeButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaDữLiệuToolStripMenuItem;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button saveButton;
    }
}
