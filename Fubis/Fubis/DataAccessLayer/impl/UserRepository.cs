
using Fubis.model;
using System.Data.SqlClient;

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
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
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
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
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
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM users WHERE nationalId = @nationalId";
                    command.Parameters.AddWithValue("@nationalId", user.NationalId);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                    }

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateItem()
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
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
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT userId FROM users WHERE nationalId = @nationalId";
                    command.Parameters.AddWithValue("@nationalId", user.NationalId);

                    int userId = (int)command.ExecuteScalar();

                    return userId;
                }
            }
        }
    }
}
