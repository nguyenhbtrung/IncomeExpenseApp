using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseApp.Controls
{
    public partial class IncomeControl : UserControl
    {
        private int userId;
        private DatabaseConnector databaseConnector;
        public int UserId { get => userId; set => userId = value; }
        public IncomeControl()
        {
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            incomeCategoryComboBox.Items.Add("Thu nhập thường xuyên");
            incomeCategoryComboBox.Items.Add("Thu nhập bổ sung");
            incomeCategoryComboBox.Items.Add("Thu nhập phụ");
            incomeCategoryComboBox.Items.Add("Đầu tư");
            incomeCategoryComboBox.Items.Add("Thu nhập không làm việc");
        }

        private void saveIncomeButton_Click(object sender, EventArgs e)
        {
            if(incomeNameText.Text == "")
            {
                showNoti("Chưa điền tên khoản thu!!");
            }
            else if(incomeCategoryComboBox.Text == "")
            {
                showNoti("Chưa chọn danh mục!!");
            }
            else if(incomeAmountText.Text == "")
            {
                showNoti("Chưa nhập số tiền!!");
            }
            var isNumeric = int.TryParse(incomeAmountText.Text, out int n);
            if (isNumeric)
            {
                int Amount = int.Parse(incomeAmountText.Text);
                string date = incomeDatePicker.Value.ToString("yyyy-MM-dd");
                databaseConnector.ExecuteNonQuery($"insert into Income values (N'{incomeNameText.Text}', N'{incomeCategoryComboBox.Text}', {Amount}, '{date}', N'{incomeDetailText.Text}', {userId})");
                MessageBox.Show("Lưu thành công!!", "Thông báo");
                incomeNameText.Clear();
                incomeCategoryComboBox.SelectedIndex = -1;
                incomeAmountText.Clear();
                incomeDetailText.Clear();
                notification.Visible = false;
                return;
            }
            else
            {
                showNoti("Nhập sai số tiền!!");
            }
        }
        private void showNoti(string text)
        {
            notification.Text = text;
            notification.Visible = true;
            return;
        }
    }
}