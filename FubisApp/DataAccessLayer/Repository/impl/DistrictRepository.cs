using Fubis.model.Fubis.DataAccessLayer.Repository;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Fubis.DataAccessLayer
{
    class DistrictRepository
    {
        public string[] GetDistrictNameForList()
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string query = "SELECT districtName FROM districts";
                using (MySqlCommand command = new MySqlCommand(query))
                {
                    command.Connection = connection;
                    using (MySqlDataReader reader = command.ExecuteReader())
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
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT districtName FROM districts WHERE districtId = '1'";
                    //command.Parameters.AddWithValue("@districtId", districtId);

                    string districtName = command.ExecuteScalar().ToString();

                    return districtName;
                }
            }
        }
    }
}
