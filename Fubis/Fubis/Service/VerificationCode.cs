

using System;

namespace Fubis.Service
{
    public class VerificationCode
    {
        private int verificationCode;

        public VerificationCode()
        {
        }

        private static VerificationCode instance;
        public static VerificationCode GetInstance()
        {
            if (instance == null)
            {
                instance = new VerificationCode();
            }
            return instance;
        }

        public int digitGenerator()
        {
            Random random = new Random();
            int min = 100000;
            int max = 999999;
            verificationCode = random.Next(max - min + 1) + min;
            // Output Test
            Console.WriteLine(verificationCode);
            return verificationCode;
        }
    }
}
