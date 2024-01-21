
namespace Fubis
{
    public class Card
    {
        private int cardId;
        private string cardNumber;
        private double balance;

        public int CardId { get => cardId; set => cardId = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public double Balance { get => balance; set => balance = value; }

        public Card()
        {
        }

        public Card(int cardId, string cardNumber, double balance)
        {
            this.cardId = cardId;
            this.cardNumber = cardNumber;
            this.balance = balance;
        }
    }
}
