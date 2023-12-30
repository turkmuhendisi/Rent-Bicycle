using Fubis.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.View.Register
{
    public class UserValid
    {
        public static bool IsAvailableUser(string nationalId, string email)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM users WHERE nationalId = @nationalId OR email = @email";
                    command.Parameters.AddWithValue("@nationalId", nationalId);
                    command.Parameters.AddWithValue("@email", email);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
    }
}
