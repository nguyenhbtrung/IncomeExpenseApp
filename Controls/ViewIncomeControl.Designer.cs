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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ViewIncomeTable = new System.Windows.Forms.DataGridView();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewincomeCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.incomeNameText = new System.Windows.Forms.TextBox();
            this.incomeCategoryLabel = new System.Windows.Forms.Label();
            this.incomeNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewIncomeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewIncomeTable
            // 
            this.ViewIncomeTable.AllowUserToAddRows = false;
            this.ViewIncomeTable.AllowUserToDeleteRows = false;
            this.ViewIncomeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ViewIncomeTable.BackgroundColor = System.Drawing.Color.White;
            this.ViewIncomeTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewIncomeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ViewIncomeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewIncomeTable.Location = new System.Drawing.Point(9, 179);
            this.ViewIncomeTable.Name = "ViewIncomeTable";
            this.ViewIncomeTable.ReadOnly = true;
            this.ViewIncomeTable.RowHeadersVisible = false;
            this.ViewIncomeTable.Size = new System.Drawing.Size(1004, 435);
            this.ViewIncomeTable.TabIndex = 39;
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataMember = "Income";
            // 
            // viewincomeCategoryComboBox
            // 
            this.viewincomeCategoryComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewincomeCategoryComboBox.FormattingEnabled = true;
            this.viewincomeCategoryComboBox.Location = new System.Drawing.Point(597, 141);
            this.viewincomeCategoryComboBox.Name = "viewincomeCategoryComboBox";
            this.viewincomeCategoryComboBox.Size = new System.Drawing.Size(250, 31);
            this.viewincomeCategoryComboBox.TabIndex = 38;
            this.viewincomeCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.viewincomeCategoryComboBox_SelectedIndexChanged);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 40;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewIncomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}
