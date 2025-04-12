using Fubis.model.Fubis.DataAccessLayer.Repository;
using MySql.Data.MySqlClient;

namespace Fubis
{
    public class CardRepository : IRepository
    {
        private Card card;
        private User user;

        public CardRepository()
        {
        }

        public CardRepository(Card card, User user)
        {
            this.card = card;
            this.user = user;
        }

        private static CardRepository instance;
        public static CardRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new CardRepository();
            }
            return instance;
        }

        public void AddItem()
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO cards (cardNumber, balance, userId) VALUES (@cardNumber, @balance, @userId)";
                    command.Parameters.AddWithValue("@cardNumber", card.CardNumber);
                    command.Parameters.AddWithValue("@balance", card.Balance);
                    command.Parameters.AddWithValue("@userId", user.UserId);

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
                    command.CommandText = "DELETE FROM cards WHERE cardId = @cardId";
                    command.Parameters.AddWithValue("@cardId", card.CardId);

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
                    command.CommandText = "SELECT * FROM cards WHERE cardId = @cardId";
                    command.Parameters.AddWithValue("@cardId", card.CardId);

                    command.ExecuteNonQuery();
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
                    command.CommandText = "UPDATE cards SET balance = @balance WHERE cardNumber = @cardNumber";
                    command.Parameters.AddWithValue("@balance", card.Balance);
                    command.Parameters.AddWithValue("@cardNumber", card.CardNumber);

                    command.ExecuteNonQuery();
                }
            }
        }

        public bool CardBalanceControl(double price, string cardNumber)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT balance FROM cards WHERE cardNumber = @cardNumber";
                    command.Parameters.AddWithValue("@cardNumber", cardNumber);

                    object balanceResult = command.ExecuteScalar();

                    if (balanceResult != null && double.TryParse(balanceResult.ToString(), out double balance))
                    {
                        if (balance >= price) return true;
                    }
                }
            }

            return false;
        }

        public static bool IsAvailableCard(string cardNumber)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM cards c " +
                        "INNER JOIN users u " +
                        "ON c.userId = u.userId " +
                        "WHERE cardNumber = @cardNumber";

                    command.Parameters.AddWithValue("@cardNumber", cardNumber);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public double GetCardBalance(string cardNumber)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT balance FROM cards WHERE cardNumber = @cardNumber";
                    command.Parameters.AddWithValue("@cardNumber", cardNumber);

                    object balanceResult = command.ExecuteScalar();

                    if (balanceResult != null && double.TryParse(balanceResult.ToString(), out double balance))
                    {
                        return balance;
                    }
                }
            }
            return 0;
        }
    }
}
