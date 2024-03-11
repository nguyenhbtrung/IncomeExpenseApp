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
            this.saveIncomeButton = new System.Windows.Forms.Button();
            this.incomeDetailLabel = new System.Windows.Forms.Label();
            this.incomeDetailText = new System.Windows.Forms.TextBox();
            this.incomeCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.incomeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.incomeAmountText = new System.Windows.Forms.TextBox();
            this.incomeNameText = new System.Windows.Forms.TextBox();
            this.incomeDateLabel = new System.Windows.Forms.Label();
            this.incomeAmountLabel = new System.Windows.Forms.Label();
            this.incomeCategoryLabel = new System.Windows.Forms.Label();
            this.incomeNameLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveIncomeButton
            // 
            this.saveIncomeButton.BackColor = System.Drawing.Color.Cyan;
            this.saveIncomeButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveIncomeButton.Location = new System.Drawing.Point(590, 442);
            this.saveIncomeButton.Name = "saveIncomeButton";
            this.saveIncomeButton.Size = new System.Drawing.Size(250, 57);
            this.saveIncomeButton.TabIndex = 72;
            this.saveIncomeButton.Text = "Lưu khoản chi";
            this.saveIncomeButton.UseVisualStyleBackColor = false;
            // 
            // incomeDetailLabel
            // 
            this.incomeDetailLabel.AutoSize = true;
            this.incomeDetailLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeDetailLabel.Location = new System.Drawing.Point(183, 381);
            this.incomeDetailLabel.Name = "incomeDetailLabel";
            this.incomeDetailLabel.Size = new System.Drawing.Size(170, 23);
            this.incomeDetailLabel.TabIndex = 71;
            this.incomeDetailLabel.Text = "Chi tiết khoản tiêu:";
            // 
            // incomeDetailText
            // 
            this.incomeDetailText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeDetailText.Location = new System.Drawing.Point(187, 407);
            this.incomeDetailText.Multiline = true;
            this.incomeDetailText.Name = "incomeDetailText";
            this.incomeDetailText.Size = new System.Drawing.Size(250, 141);
            this.incomeDetailText.TabIndex = 70;
            // 
            // incomeCategoryComboBox
            // 
            this.incomeCategoryComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeCategoryComboBox.FormattingEnabled = true;
            this.incomeCategoryComboBox.Location = new System.Drawing.Point(590, 189);
            this.incomeCategoryComboBox.Name = "incomeCategoryComboBox";
            this.incomeCategoryComboBox.Size = new System.Drawing.Size(250, 31);
            this.incomeCategoryComboBox.TabIndex = 69;
            // 
            // incomeDatePicker
            // 
            this.incomeDatePicker.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeDatePicker.Location = new System.Drawing.Point(590, 302);
            this.incomeDatePicker.Name = "incomeDatePicker";
            this.incomeDatePicker.Size = new System.Drawing.Size(250, 32);
            this.incomeDatePicker.TabIndex = 68;
            // 
            // incomeAmountText
            // 
            this.incomeAmountText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeAmountText.Location = new System.Drawing.Point(187, 302);
            this.incomeAmountText.Name = "incomeAmountText";
            this.incomeAmountText.Size = new System.Drawing.Size(250, 32);
            this.incomeAmountText.TabIndex = 67;
            // 
            // incomeNameText
            // 
            this.incomeNameText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeNameText.Location = new System.Drawing.Point(187, 188);
            this.incomeNameText.Name = "incomeNameText";
            this.incomeNameText.Size = new System.Drawing.Size(250, 32);
            this.incomeNameText.TabIndex = 66;
            // 
            // incomeDateLabel
            // 
            this.incomeDateLabel.AutoSize = true;
            this.incomeDateLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeDateLabel.Location = new System.Drawing.Point(586, 276);
            this.incomeDateLabel.Name = "incomeDateLabel";
            this.incomeDateLabel.Size = new System.Drawing.Size(89, 23);
            this.incomeDateLabel.TabIndex = 65;
            this.incomeDateLabel.Text = "Ngày chi:";
            // 
            // incomeAmountLabel
            // 
            this.incomeAmountLabel.AutoSize = true;
            this.incomeAmountLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeAmountLabel.Location = new System.Drawing.Point(183, 276);
            this.incomeAmountLabel.Name = "incomeAmountLabel";
            this.incomeAmountLabel.Size = new System.Drawing.Size(74, 23);
            this.incomeAmountLabel.TabIndex = 64;
            this.incomeAmountLabel.Text = "Số tiền:";
            // 
            // incomeCategoryLabel
            // 
            this.incomeCategoryLabel.AutoSize = true;
            this.incomeCategoryLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeCategoryLabel.Location = new System.Drawing.Point(586, 162);
            this.incomeCategoryLabel.Name = "incomeCategoryLabel";
            this.incomeCategoryLabel.Size = new System.Drawing.Size(101, 23);
            this.incomeCategoryLabel.TabIndex = 63;
            this.incomeCategoryLabel.Text = "Danh mục:";
            // 
            // incomeNameLabel
            // 
            this.incomeNameLabel.AutoSize = true;
            this.incomeNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeNameLabel.Location = new System.Drawing.Point(183, 162);
            this.incomeNameLabel.Name = "incomeNameLabel";
            this.incomeNameLabel.Size = new System.Drawing.Size(169, 23);
            this.incomeNameLabel.TabIndex = 62;
            this.incomeNameLabel.Text = "Tên khoản chi tiêu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(315, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(335, 50);
            this.label11.TabIndex = 61;
            this.label11.Text = "CHI TIẾT TIÊU PHÍ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(236, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 50);
            this.label10.TabIndex = 60;
            // 
            // ExpenseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveIncomeButton);
            this.Controls.Add(this.incomeDetailLabel);
            this.Controls.Add(this.incomeDetailText);
            this.Controls.Add(this.incomeCategoryComboBox);
            this.Controls.Add(this.incomeDatePicker);
            this.Controls.Add(this.incomeAmountText);
            this.Controls.Add(this.incomeNameText);
            this.Controls.Add(this.incomeDateLabel);
            this.Controls.Add(this.incomeAmountLabel);
            this.Controls.Add(this.incomeCategoryLabel);
            this.Controls.Add(this.incomeNameLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Name = "ExpenseControl";
            this.Size = new System.Drawing.Size(1022, 623);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveIncomeButton;
        private System.Windows.Forms.Label incomeDetailLabel;
        private System.Windows.Forms.TextBox incomeDetailText;
        private System.Windows.Forms.ComboBox incomeCategoryComboBox;
        private System.Windows.Forms.DateTimePicker incomeDatePicker;
        private System.Windows.Forms.TextBox incomeAmountText;
        private System.Windows.Forms.TextBox incomeNameText;
        private System.Windows.Forms.Label incomeDateLabel;
        private System.Windows.Forms.Label incomeAmountLabel;
        private System.Windows.Forms.Label incomeCategoryLabel;
        private System.Windows.Forms.Label incomeNameLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}
