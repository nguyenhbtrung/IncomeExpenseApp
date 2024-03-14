using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseApp
{
    public partial class TestDatabase : Form
    {
        private DatabaseConnector databaseConnector;

        public TestDatabase()
        {
            InitializeComponent();
            databaseConnector = new DatabaseConnector(Program.DbConnectionString);
            databaseConnector.ExecuteNonQuery("if not exists (select * from sysobjects where name = 'UserIn4' and xtype = 'U')" +
                                              "create table UserIn4 (" +
                                              "uName nvarchar(50) not null," +
                                              "uAddress nvarchar(50) not null)");
            LoadTable();
        }

        private void LoadTable()
        {
            DataTable dataTable = databaseConnector.ExecuteDataTableQuery("select * from UserIn4");
            dataGridView1.DataSource = dataTable;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            databaseConnector.ExecuteNonQuery($"insert into UserIn4 values (N'{name}', N'{address}')");
            LoadTable();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            databaseConnector.ExecuteNonQuery($"delete from UserIn4 where uName = '{name}' and uAddress = '{address}'");
            LoadTable();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            DataTable dataTable = databaseConnector.ExecuteDataTableQuery($"select * from UserIn4 where uName = '{name}'");
            dataGridView1.DataSource = dataTable;
        }

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            databaseConnector.ExecuteNonQuery("delete from UserIn4");
            LoadTable();
        }
    }
}
