using System;
using System.Net;
using System.Net.Mail;

namespace Fubis.Service
{
    public class UserMailService : IMessageService
    {
        public void MailSender(string cardNumber, string email)
        {
            string senderEmail = "javatester60@gmail.com";
            string senderPassword = "baxg nqgw xqzs mryy";

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(senderEmail);
            mail.To.Add(email);
            mail.Subject = "FÜBİS";
            mail.Body = $"Merhaba," +
                $"\r\nKaydolduğunuz için teşekkür ederiz!" +
                $"\r\n\nHesabınız oluşturuldu ve aşağıdaki kart numarasını kullanarak hizmetlerimizden faydalanabilirsiniz." +
                $"\r\nKart Numarası: {cardNumber}" +
                $"\r\n\nHerhangi bir sorunuz olduğunda bizimle iletişime geçmekten çekinmeyin." +
                $"\r\n\nİyi günler dileriz," +
                $"\r\nFÜBİS Yönetimi";


            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587; // Gmail SMTP portu
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(mail);
                Console.WriteLine("Kart numaranız e-postanıza iletilmiştir.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
