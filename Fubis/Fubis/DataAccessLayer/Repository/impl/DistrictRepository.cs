using Fubis.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.DataAccessLayer
{
    class DistrictRepository
    {
        public string[] GetDistrictNameForList()
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string query = "SELECT districtName FROM districts";
                using (SqlCommand command = new SqlCommand(query))
                {
                    command.Connection = connection;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var columnDataList = new List<string>();
                        while (reader.Read())
                        {
                            columnDataList.Add(reader["districtName"].ToString());
                        }
                        return columnDataList.ToArray();
                    }
                }
            }
        }

        public string GetDistrictName(int districtId)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT districtName FROM districts WHERE districtId = @districtId";
                    command.Parameters.AddWithValue("@districtId", districtId);

                    string districtName = command.ExecuteScalar().ToString();

                    return districtName;
                }
            }
        }
    }
}
