using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace hopital.utils
{
    internal class DatabaseHelper
    {
        private readonly string connectionString = "Server=localhost;Database=hopital;User ID=root;Password=;";
        private MySqlConnection connection;

        public DatabaseHelper()
        {
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection() => connection;

        public void ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            using (var cmd = new MySqlCommand(query, connection))
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            var dataTable = new DataTable();
            using (var cmd = new MySqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
    }
}
