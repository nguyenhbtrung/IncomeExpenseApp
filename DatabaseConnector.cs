using System.Data;
using System.Data.SqlClient;

namespace IncomeExpenseApp
{
    internal class DatabaseConnector
    {
        private readonly string connectionString;

        public DatabaseConnector(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void ExecuteNonQuery(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataSet ExecuteDataSetQuery(string query)
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataSet);
                }
            }
            return dataSet;
        }

        public DataTable ExecuteDataTableQuery(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
    }
}
