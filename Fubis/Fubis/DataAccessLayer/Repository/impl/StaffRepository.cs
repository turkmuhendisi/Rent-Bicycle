using Fubis.DataAccessLayer.Model;
using Fubis.model;
using Fubis.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
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
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
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
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(role) FROM staff WHERE districtId = @districtId";
                    command.Parameters.AddWithValue("@districtId", staff.DistrictId);

                    int roleCount = (int)command.ExecuteScalar();
                }
            }
        }

        public string GetServiceInformation(int districtId)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT firstName + ' ' + lastName FROM staff WHERE districtId = @districtId AND role = 'SERVICE'";
                    command.Parameters.AddWithValue("@districtId", districtId);

                    string fullName = command.ExecuteScalar()?.ToString();
                    return fullName;
                }
            }
        }

        public int GetModeratorRoleCount(int districtId)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(role) FROM staff WHERE districtId = @districtId AND role = 'MODERATOR'";
                    command.Parameters.AddWithValue("@districtId", districtId);

                    int roleCount = (int)command.ExecuteScalar();

                    return roleCount;
                }
            }
        }

        public int GetServiceRoleCount(int districtId)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(role) FROM staff WHERE districtId = @districtId AND role = 'SERVICE'";
                    command.Parameters.AddWithValue("@districtId", districtId);

                    int roleCount = (int)command.ExecuteScalar();

                    return roleCount;
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
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "SELECT s.staffId AS STAFF_ID, s.firstName AS FIRST_NAME, s.lastName AS LAST_NAME, s.role AS ROLE, s.staffCardNumber AS CARD_NUMBER, d.districtId AS DISTRICT " +
                        "FROM staff s " +
                        "INNER JOIN districts d " +
                        "ON s.districtId = d.districtId " +
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
