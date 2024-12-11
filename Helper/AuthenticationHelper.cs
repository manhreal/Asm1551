using Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Helper
{
    public class AuthenticationHelper
    {
        public class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public int Role { get; set; } // 1: Admin, 0: User
            public bool HasPlayed { get; set; }
        }

        public bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpper = false, hasLower = false, hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (char.IsDigit(c)) hasDigit = true;

                if (hasUpper && hasLower && hasDigit)
                    return true; // OK
            }

            return false;
        }

        public bool Register(string username, string password, string displayName)
        {

            string checkUserQuery = "SELECT COUNT(*) FROM User WHERE username = @username";
            MySqlParameter[] checkUserParams = new MySqlParameter[]
            {
                new MySqlParameter("@username", username)
            };

            int userCount = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkUserQuery, checkUserParams));
            if (userCount > 0)
            {
                return false; 
            }

            string query = "INSERT INTO User (username, password, name, role, has_played) VALUES (@username, @password, @name, 0, FALSE)";
            MySqlParameter[] insertParams = new MySqlParameter[]
            {
                new MySqlParameter("@username", username),
                new MySqlParameter("@password", password), 
                new MySqlParameter("@name", displayName)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, insertParams);
                return true; 
            }
            catch (Exception)
            {
                return false; 
            }
        }

        public User Login(string username, string password)
        {
            string query = "SELECT * FROM User WHERE username = @username AND password = @password";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@username", username),
                new MySqlParameter("@password", password) 
            };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new User
                {
                    Id = Convert.ToInt32(row["id"]),
                    Username = row["username"].ToString(),
                    Name = row["name"].ToString(),
                    Role = Convert.ToInt32(row["role"]),
                    HasPlayed = Convert.ToBoolean(row["has_played"])
                };
            }

            return null;
        }
    }
}
