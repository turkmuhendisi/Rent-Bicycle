
namespace Fubis.model
{
    using MySql.Data.MySqlClient;

    namespace Fubis.DataAccessLayer.Repository
    {
        public static class Connection
        {
            public const string SERVER = "92.205.5.205";
            public const string DATABASE_NAME = "fubisdb";
            public const string USERNAME = "turkmuhendisi";
            public const string PASSWORD = "tJu|=L5eY{<$ez2Q";
            private static string CONNECTION_STRING =
                $"Server={Connection.SERVER};" +
                $"Database={Connection.DATABASE_NAME};" +
                $"Uid={Connection.USERNAME};" +
                $"Pwd={Connection.PASSWORD};";

            public static MySqlConnection GetConnection()
            {
                MySqlConnection connection = new MySqlConnection(CONNECTION_STRING);
                return connection;
            }
        }
    }

}
