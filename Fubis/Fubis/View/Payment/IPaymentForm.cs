using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.View.Payment
{
    public interface IPaymentForm
    {
        string GetCardNumber { get; set; }
        event EventHandler PaymentButtonClicked;
    }
}
