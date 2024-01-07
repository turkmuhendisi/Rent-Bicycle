using Fubis.model;
using System.Data;
using System.Data.SqlClient;

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
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
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
                    command.CommandText =
                        "SELECT b.bicycleId AS BICYCLE_ID, b.inMaintenance AS IN_MAINTENANCE, d.districtName AS DISTRICT " +
                        "FROM bicycles b " +
                        "INNER JOIN districts d " +
                        "ON b.districtId = d.districtId " +
                        "WHERE d.districtId = @districtId";

                    command.Parameters.AddWithValue("@districtId", bicycle.DistrictId);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                }
            }
        }

        public DataTable GetBicycles(int districtId)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "SELECT b.bicycleId AS BICYCLE_ID, b.inMaintenance AS IN_MAINTENANCE, d.districtName AS DISTRICT " +
                        "FROM bicycles b " +
                        "INNER JOIN districts d " +
                        "ON b.districtId = d.districtId " +
                        "WHERE d.districtId = @districtId";

                    command.Parameters.AddWithValue("@districtId", districtId);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
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
                    command.CommandText = "UPDATE bicycles SET inMaintenance = @inMaintenance WHERE bicycleId = @bicycleId";
                    command.Parameters.AddWithValue("@inMaintenance", bicycle.InMaintenance);
                    command.Parameters.AddWithValue("@bicycleId", bicycle.BicycleId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable ShowTableInDataGridView(string selectedDistrictName)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "SELECT b.bicycleId AS BICYCLE_ID, b.inMaintenance AS IN_MAINTENANCE, d.districtName AS DISTRICT " +
                        "FROM bicycles b " +
                        "INNER JOIN districts d " +
                        "ON b.districtId = d.districtId " +
                        "WHERE d.districtName = @districtName";

                    command.Parameters.AddWithValue("@districtName", selectedDistrictName);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }
    }
}
