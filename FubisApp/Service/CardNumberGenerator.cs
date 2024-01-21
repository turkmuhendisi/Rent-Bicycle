using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.Service
{
    public class CardNumberGenerator : ICardNumber
    {
        private string cardDigits;
        private Random random = new Random();
        private DateTime dateTime;

        private string GenerateFourDigit()
        {
            dateTime = DateTime.Now;
            int time = dateTime.Millisecond + 1;
            int randomNumber = random.Next(1111,99999);

            string multiplication = (time * randomNumber).ToString();

            string generatedDigits = multiplication.Substring((multiplication.Length-4));

            return generatedDigits;
        }

        public string GeneratedCardNumberForUser()
        {
            for (int i = 0; i < 4; i++)
            {
                cardDigits += GenerateFourDigit();
            }

            return cardDigits;
        }

        public string GeneratedCardNumberForModerator()
        {
            cardDigits += 9999;
            for (int i = 1; i < 3; i++)
            {
                cardDigits += GenerateFourDigit();
            }
            cardDigits += 9999;

            return cardDigits;
        }

        public string GeneratedCardNumberForService()
        {
            cardDigits += 1111;
            for (int i = 1; i < 3; i++)
            {
                cardDigits += GenerateFourDigit();
            }
            cardDigits += 1111;

            return cardDigits;
        }

        public string GeneratedCardNumberForAdmin()
        {
            cardDigits += 0101;
            for (int i = 1; i < 3; i++)
            {
                cardDigits += GenerateFourDigit();
            }
            cardDigits += 0101;

            return cardDigits;
        }
    }
}
