using Fubis.model.Fubis.DataAccessLayer.Repository;
using MySql.Data.MySqlClient;

namespace Fubis.DataAccessLayer.Repository.impl
{
    public class RentalRepository
    {
        private User user;
        private Bicycle bicycle;

        public RentalRepository(User user, Bicycle bicycle)
        {
            this.user = user;
            this.bicycle = bicycle;
        }

        public void AddItem()
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO rentals (userId, bicycleId) VALUES (@userId, @bicycleId)";
                    command.Parameters.AddWithValue("@userId", user.UserId);
                    command.Parameters.AddWithValue("@bicycleId", bicycle.BicycleId);

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
                    command.CommandText = "UPDATE bicycles b " +
                      "INNER JOIN rentals r " +
                      "ON b.bicycleId = r.bicycleId " +
                      "SET b.isAvailable = @isAvailable " +
                      "WHERE b.bicycleId = @bicycleId";

                    command.Parameters.AddWithValue("@isAvailable", bicycle.IsAvailable);
                    command.Parameters.AddWithValue("@bicycleId", bicycle.BicycleId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static int GetBicycleId(string userId)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT bicycleId FROM rentals WHERE userId = @userId";
                    command.Parameters.AddWithValue("@userId", userId);

                    int bicycleId = Convert.ToInt32(command.ExecuteScalar());

                    return bicycleId;
                }
            }
        }

        public void DeleteRentalReport(string userId)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM rentals WHERE userId = @userId";
                    command.Parameters.AddWithValue("@userId", userId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool Rentalable(string cardNumber)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM rentals r " +
                        "INNER JOIN users u ON u.userId = r.userId " +
                        "INNER JOIN cards c ON u.userId = c.userId " +
                        "INNER JOIN bicycles b ON b.bicycleId = r.bicycleId " +
                        "WHERE c.cardNumber = @cardNumber AND b.isAvailable = 'false'";

                    command.Parameters.AddWithValue("@cardNumber", cardNumber);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }


    }
}
