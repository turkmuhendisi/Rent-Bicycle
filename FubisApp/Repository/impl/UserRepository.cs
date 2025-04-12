
using Fubis.model.Fubis.DataAccessLayer.Repository;
using MySql.Data.MySqlClient;

namespace Fubis
{
    public class UserRepository : IRepository
    {
        private User user;

        public UserRepository(User user)
        {
            this.user = user;
        }

        public void AddItem()
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "INSERT INTO users (nationalId, email) " +
                        "VALUES(@nationalId, @email)";

                    command.Parameters.AddWithValue("@nationalId", user.NationalId);
                    command.Parameters.AddWithValue("@email", user.Email);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteItem()
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM users WHERE userId = @userId";
                    command.Parameters.AddWithValue("@userId", user.UserId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void GetItem()
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM users WHERE nationalId = @nationalId";
                    command.Parameters.AddWithValue("@nationalId", user.NationalId);

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                    }

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateItem()
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE users SET email = @email WHERE userId = @userId";
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@userId", user.UserId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public int UserGetId()
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT userId FROM users WHERE nationalId = @nationalId";
                    command.Parameters.AddWithValue("@nationalId", user.NationalId);

                    object result = command.ExecuteScalar();

                    // Check if the result is DBNull or null
                    if (result == DBNull.Value || result == null)
                    {
                        return -1; // Or any appropriate default value indicating no result
                    }

                    int userId = Convert.ToInt32(result);

                    return userId;
                }
            }
        }

        public static bool IsAvailableUser(string nationalId, string email)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM users WHERE nationalId = @nationalId OR email = @email";
                    command.Parameters.AddWithValue("@nationalId", nationalId);
                    command.Parameters.AddWithValue("@email", email);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public static string GetUserEmail(string cardNumber)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT email FROM users u " +
                        "INNER JOIN cards c " +
                        "ON u.userId = c.userId " +
                        "WHERE cardNumber = @cardNumber";

                    command.Parameters.AddWithValue("@cardNumber", cardNumber);

                    string email = command.ExecuteScalar().ToString();

                    return email;
                }
            }
        }

        public static int GetUserId(string cardNumber)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT u.userId FROM users u " +
                        "INNER JOIN cards c " +
                        "ON u.userId = c.userId " +
                        "WHERE c.cardNumber = @cardNumber";
                    command.Parameters.AddWithValue("@cardNumber", cardNumber);

                    int userId = Convert.ToInt32(command.ExecuteScalar());

                    return userId;
                }
            }
        }
    }
}
