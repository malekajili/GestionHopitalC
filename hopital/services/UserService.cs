using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hopital.utils;

namespace hopital.services
{
    public class UserService
    {
        private DatabaseHelper databaseHelper;

        public bool Authenticate(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = SHA2(@password, 256)";
            var parameters = new Dictionary<string, object>
            {
                { "@username", username },
                { "@password", password }
            };
            DataTable result = databaseHelper.ExecuteQuery(query, parameters);
            return result.Rows[0][0].ToString() == "1";
        }

        public void CreateUser(string username, string password, string role)
        {
            string query = "INSERT INTO users (username, password, role) VALUES (@username, SHA2(@password, 256), @role)";
            var parameters = new Dictionary<string, object>
            {
                { "@username", username },
                { "@password", password },
                { "@role", role }
            };
            databaseHelper.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetUsers()
        {
            string query = "SELECT id, username, role, created_at FROM users";
            return databaseHelper.ExecuteQuery(query);
        }

        public void DeleteUser(int id)
        {
            string query = "DELETE FROM users WHERE id = @id";
            var parameters = new Dictionary<string, object>
            {
                { "@id", id }
            };
            databaseHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
