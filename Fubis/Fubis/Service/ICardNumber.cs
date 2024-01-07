using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.Service
{
    public interface ICardNumber
    {
        string GeneratedCardNumberForUser();
        string GeneratedCardNumberForModerator();
        string GeneratedCardNumberForService();
        string GeneratedCardNumberForAdmin();
    }
}
