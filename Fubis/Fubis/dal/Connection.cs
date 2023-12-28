using System.Data.SqlClient;

namespace Fubis.model
{
    public class Connection
    {
        private static readonly string connectionString = "Server=.;Initial Catalog=fubisdb;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
