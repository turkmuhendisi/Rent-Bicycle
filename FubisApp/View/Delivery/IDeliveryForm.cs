using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.View.Delivery
{
    public interface IDeliveryForm
    {
        string GetCardNumber { get; set; }
        event EventHandler DeliveryButtonClicked;
    }
}
