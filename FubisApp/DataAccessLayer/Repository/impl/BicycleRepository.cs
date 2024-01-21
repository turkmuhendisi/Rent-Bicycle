using Fubis.model.Fubis.DataAccessLayer.Repository;
using MySql.Data.MySqlClient;
using System.Data;

namespace Fubis
{
    public class BicycleRepository : IRepository
    {
        private Bicycle bicycle;


        public BicycleRepository()
        {
        }

        public BicycleRepository(Bicycle bicycle)
        {
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
                    command.CommandText = "INSERT INTO bicycles (isAvailable,inMaintenance,districtId) VALUES (@isAvailable, @inMaintenance, @districtId)";
                    command.Parameters.AddWithValue("@isAvailable", bicycle.IsAvailable);
                    command.Parameters.AddWithValue("@inMaintenance", bicycle.InMaintenance);
                    command.Parameters.AddWithValue("@districtId", bicycle.DistrictId);

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
                    command.CommandText = "DELETE FROM bicycles WHERE bicycleId = @bicycleId";
                    command.Parameters.AddWithValue("@bicycleId", bicycle.BicycleId);

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
                    command.CommandText =
                        "SELECT b.bicycleId AS BICYCLE_ID, b.inMaintenance AS IN_MAINTENANCE, d.districtName AS DISTRICT " +
                        "FROM bicycles b " +
                        "INNER JOIN districts d " +
                        "ON b.districtId = d.districtId " +
                        "WHERE d.districtId = @districtId";

                    command.Parameters.AddWithValue("@districtId", bicycle.DistrictId);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                }
            }
        }

        public DataTable GetBicycles(int districtId)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "SELECT b.bicycleId AS BICYCLE_ID, b.inMaintenance AS IN_MAINTENANCE, d.districtName AS DISTRICT " +
                        "FROM bicycles b " +
                        "INNER JOIN districts d " +
                        "ON b.districtId = d.districtId " +
                        "WHERE d.districtId = @districtId";

                    command.Parameters.AddWithValue("@districtId", districtId);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
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
                    command.CommandText = "UPDATE bicycles SET inMaintenance = @inMaintenance, isAvailable = @isAvailable WHERE bicycleId = @bicycleId";
                    command.Parameters.AddWithValue("@inMaintenance", bicycle.InMaintenance);
                    command.Parameters.AddWithValue("@isAvailable", bicycle.IsAvailable);
                    command.Parameters.AddWithValue("@bicycleId", bicycle.BicycleId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable ShowTableInDataGridView(string selectedDistrictName)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "SELECT b.bicycleId AS BICYCLE_ID, b.inMaintenance AS IN_MAINTENANCE, d.districtName AS DISTRICT " +
                        "FROM bicycles b " +
                        "INNER JOIN districts d ON b.districtId = d.districtId " +
                        "WHERE d.districtName = @districtName";

                    command.Parameters.AddWithValue("@districtName", selectedDistrictName);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        public string GetAvailableBicycle()
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    int bicycleCount = 0;
                    string bicycleId = null;

                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(bicycleId) FROM bicycles WHERE isAvailable = 'true' AND districtId = '1'";
                    bicycleCount = Convert.ToInt32(command.ExecuteScalar());

                    if (bicycleCount > 0)
                    {
                        command.CommandText = "SELECT bicycleId FROM bicycles WHERE isAvailable = 'true' AND districtId = '1' LIMIT 1";

                        bicycleId = command.ExecuteScalar().ToString();
                    }

                    return bicycleId;
                }
            }
        }

        public static bool IsAvailableBicycle(string bicycleId, string email)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM bicycles WHERE bicycleId = @bicycleId";
                    command.Parameters.AddWithValue("@bicycleId", bicycleId);
                    command.Parameters.AddWithValue("@email", email);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }
    }
}
