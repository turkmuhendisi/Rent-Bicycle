using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.Service
{
    public interface IVerificationService
    {
        void VerificationMailSender(string email, int verificationCode);
    }
}
