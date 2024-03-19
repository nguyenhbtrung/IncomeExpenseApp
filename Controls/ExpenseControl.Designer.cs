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
            this.SuspendLayout();
            // 
            // saveExpenseButton
            // 
            this.saveExpenseButton.BackColor = System.Drawing.Color.Cyan;
            this.saveExpenseButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveExpenseButton.Location = new System.Drawing.Point(590, 442);
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
            this.incomeDetailLabel.Location = new System.Drawing.Point(183, 381);
            this.incomeDetailLabel.Name = "incomeDetailLabel";
            this.incomeDetailLabel.Size = new System.Drawing.Size(170, 23);
            this.incomeDetailLabel.TabIndex = 71;
            this.incomeDetailLabel.Text = "Chi tiết khoản tiêu:";
            // 
            // expenseDetailText
            // 
            this.expenseDetailText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseDetailText.Location = new System.Drawing.Point(187, 407);
            this.expenseDetailText.Multiline = true;
            this.expenseDetailText.Name = "expenseDetailText";
            this.expenseDetailText.Size = new System.Drawing.Size(250, 141);
            this.expenseDetailText.TabIndex = 70;
            // 
            // expenseCategoryComboBox
            // 
            this.expenseCategoryComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseCategoryComboBox.FormattingEnabled = true;
            this.expenseCategoryComboBox.Location = new System.Drawing.Point(590, 189);
            this.expenseCategoryComboBox.Name = "expenseCategoryComboBox";
            this.expenseCategoryComboBox.Size = new System.Drawing.Size(250, 31);
            this.expenseCategoryComboBox.TabIndex = 69;
            // 
            // expenseDatePicker
            // 
            this.expenseDatePicker.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseDatePicker.Location = new System.Drawing.Point(590, 302);
            this.expenseDatePicker.Name = "expenseDatePicker";
            this.expenseDatePicker.Size = new System.Drawing.Size(250, 32);
            this.expenseDatePicker.TabIndex = 68;
            // 
            // expenseAmountText
            // 
            this.expenseAmountText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseAmountText.Location = new System.Drawing.Point(187, 302);
            this.expenseAmountText.Name = "expenseAmountText";
            this.expenseAmountText.Size = new System.Drawing.Size(250, 32);
            this.expenseAmountText.TabIndex = 67;
            // 
            // expenseNameText
            // 
            this.expenseNameText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseNameText.Location = new System.Drawing.Point(187, 189);
            this.expenseNameText.Name = "expenseNameText";
            this.expenseNameText.Size = new System.Drawing.Size(250, 32);
            this.expenseNameText.TabIndex = 66;
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
            this.incomeCategoryLabel.Location = new System.Drawing.Point(586, 163);
            this.incomeCategoryLabel.Name = "incomeCategoryLabel";
            this.incomeCategoryLabel.Size = new System.Drawing.Size(101, 23);
            this.incomeCategoryLabel.TabIndex = 63;
            this.incomeCategoryLabel.Text = "Danh mục:";
            // 
            // incomeNameLabel
            // 
            this.incomeNameLabel.AutoSize = true;
            this.incomeNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeNameLabel.Location = new System.Drawing.Point(183, 163);
            this.incomeNameLabel.Name = "incomeNameLabel";
            this.incomeNameLabel.Size = new System.Drawing.Size(169, 23);
            this.incomeNameLabel.TabIndex = 62;
            this.incomeNameLabel.Text = "Tên khoản chi tiêu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(315, 73);
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
            // notification
            // 
            this.notification.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification.ForeColor = System.Drawing.Color.Red;
            this.notification.Location = new System.Drawing.Point(590, 505);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(250, 43);
            this.notification.TabIndex = 73;
            this.notification.Text = "Thông báo";
            this.notification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notification.Visible = false;
            // 
            // ExpenseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
