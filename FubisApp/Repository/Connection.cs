
namespace Fubis.model
{
    using MySql.Data.MySqlClient;

    namespace Fubis.DataAccessLayer.Repository
    {
        public static class Connection
        {
            public const string SERVER = "92.113.22.53";
            public const string PORT = "3306";
            public const string DATABASE_NAME = "u824624299_fubisdb";
            public const string USERNAME = "u824624299_fubis";
            public const string PASSWORD = "Fubis23!.";
            private static string CONNECTION_STRING = $"Server={SERVER};Port={PORT};Database={DATABASE_NAME};Uid={USERNAME};Pwd={PASSWORD};";

            public static MySqlConnection GetConnection()
            {
                MySqlConnection connection = new MySqlConnection(CONNECTION_STRING);
                return connection;
            }
        }
    }

}
