using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.Service
{
    public interface IMessageService
    {
        void MailSender(string cardNumber, string email);
    }
}
