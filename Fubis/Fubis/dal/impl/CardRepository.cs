
using Fubis.model;
using System.Data.SqlClient;

namespace Fubis
{
    public class CardRepository : IRepository
    {
        private Card card;
        private User user;

        public CardRepository(Card card, User user)
        {
            this.card = card;
            this.user = user;
        }

        public void addItem()
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
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

        public void deleteItem()
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM cards WHERE cardId = @cardId";
                    command.Parameters.AddWithValue("@cardId", card.CardId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void getItem()
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM cards WHERE cardId = @cardId";
                    command.Parameters.AddWithValue("@cardId", card.CardId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void updateItem()
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE cards SET cardNumber = @cardNumber, balance = @balance WHERE cardId = @cardId";
                    command.Parameters.AddWithValue("@cardNumber", card.CardNumber);
                    command.Parameters.AddWithValue("@balance", card.Balance);
                    command.Parameters.AddWithValue("@cardId", card.CardId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
