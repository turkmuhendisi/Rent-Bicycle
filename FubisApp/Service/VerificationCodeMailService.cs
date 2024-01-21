using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.Service
{
    class VerificationCodeMailService : IVerificationService
    {
        public void VerificationMailSender(string email, int verificationCode)
        {
            string senderEmail = "javatester60@gmail.com";
            string senderPassword = "baxg nqgw xqzs mryy";

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(senderEmail);
            mail.To.Add(email);
            mail.Subject = "FÜBİS";
            mail.Body = $"Merhaba," +
                $"\r\n\nÖdeme işlemi için gerekli olan kod aşağıda yer almaktadır." +
                $"\r\nDoğrulama kodu: {verificationCode}" +
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
                Console.WriteLine("Doğrulama kodu e-postanıza iletilmiştir.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
