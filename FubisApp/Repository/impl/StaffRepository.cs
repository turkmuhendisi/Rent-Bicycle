using Fubis.DataAccessLayer.Model;
using Fubis.model.Fubis.DataAccessLayer.Repository;
using MySql.Data.MySqlClient;
using System.Data;

namespace Fubis.DataAccessLayer.Repository.impl
{
    class StaffRepository : IRepository
    {
        private Staff staff;

        public StaffRepository()
        {
        }

        public StaffRepository(Staff staff)
        {
            this.staff = staff;
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
                        "INSERT INTO staff (firstName, lastName, role, staffCardNumber, districtId) " +
                        "VALUES(@firstName, @lastName, @role, @staffCardNumber, @districtId)";

                    command.Parameters.AddWithValue("@firstName", staff.FirstName);
                    command.Parameters.AddWithValue("@lastName", staff.LastName);
                    command.Parameters.AddWithValue("@role", staff.Role);
                    command.Parameters.AddWithValue("@staffCardNumber", staff.StaffCardNumber);
                    command.Parameters.AddWithValue("@districtId", staff.DistrictId);

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
                    command.CommandText = "DELETE FROM staff WHERE staffId = @staffId";
                    command.Parameters.AddWithValue("@staffId", staff.StaffId);

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
                    command.CommandText = "SELECT COUNT(role) FROM staff WHERE districtId = @districtId";
                    command.Parameters.AddWithValue("@districtId", staff.DistrictId);

                    int roleCount = Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public string GetServiceInformation(int districtId)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT CONCAT(firstName, ' ', lastName) AS fullName FROM staff WHERE districtId = @districtId AND role = 'SERVICE'";
                    command.Parameters.AddWithValue("@districtId", districtId);

                    string fullName = command.ExecuteScalar()?.ToString();
                    return fullName;
                }
            }
        }

        public int GetModeratorRoleCount(int districtId)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(role) FROM staff WHERE districtId = @districtId AND role = 'MODERATOR'";
                    command.Parameters.AddWithValue("@districtId", districtId);

                    int roleCount = Convert.ToInt32(command.ExecuteScalar());

                    return roleCount;
                }
            }
        }

        public int GetServiceRoleCount(int districtId)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(role) FROM staff WHERE districtId = @districtId AND role = 'SERVICE'";
                    command.Parameters.AddWithValue("@districtId", districtId);

                    int roleCount = Convert.ToInt32(command.ExecuteScalar());

                    return roleCount;
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
                    command.CommandText = 
                        "UPDATE staff " +
                        "SET firstName = @firstName, " +
                        "lastName = @lastName, " +
                        "role = @role, " +
                        "districtId = @districtId " +
                        "WHERE staffId = @staffId";

                    command.Parameters.AddWithValue("@firstName", staff.FirstName);
                    command.Parameters.AddWithValue("@lastName", staff.LastName);
                    command.Parameters.AddWithValue("@role", staff.Role);
                    command.Parameters.AddWithValue("@districtId", staff.DistrictId);
                    command.Parameters.AddWithValue("@staffId", staff.StaffId);

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
                        "SELECT s.staffId AS STAFF_ID, s.firstName AS FIRST_NAME, s.lastName AS LAST_NAME, s.role AS ROLE, s.staffCardNumber AS CARD_NUMBER, d.districtId AS DISTRICT " +
                        "FROM staff s " +
                        "INNER JOIN districts d " +
                        "ON s.districtId = d.districtId " +
                        "WHERE d.districtName = @districtName";

                    command.Parameters.AddWithValue("@districtName", selectedDistrictName);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        public static bool IsAvailableStaff(string staffCardNumber)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM staff WHERE staffCardNumber = @staffCardNumber";
                    command.Parameters.AddWithValue("@staffCardNumber", staffCardNumber);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }
    }
}
