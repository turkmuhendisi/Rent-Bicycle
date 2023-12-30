
using Fubis.model;
using System.Data.SqlClient;

namespace Fubis
{
    public class BicycleRepository : IRepository
    {
        private Bicycle bicycle;

        public BicycleRepository(Bicycle bicycle)
        {
            this.bicycle = bicycle;
        }

        public void AddItem()
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO bicycles (isAvailable) VALUES (@isAvailable)";
                    command.Parameters.AddWithValue("@isAvailable", bicycle.IsAvailable);

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
                    command.CommandText = "DELETE FROM bicycles WHERE bicycleId = @bicycleId";
                    command.Parameters.AddWithValue("@bicycleId", bicycle.BicycleId);

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
                    command.CommandText = "SELECT * FROM bicycles WHERE bicycleId = @bicycleId";
                    command.Parameters.AddWithValue("@bicycleId", bicycle.BicycleId);

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
                    command.CommandText = "UPDATE bicycles SET isAvailable = @isAvailable WHERE bicycleId = @bicycleId";
                    command.Parameters.AddWithValue("@isAvailable", bicycle.IsAvailable);
                    command.Parameters.AddWithValue("@bicycleId", bicycle.BicycleId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
