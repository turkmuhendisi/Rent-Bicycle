using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fubis.View.Payment
{
    public interface IBalancePaymentForm
    {
        string GetCardNumber { get; set; }
        string GetVerificationCode { get; set; }
        event EventHandler ConfirmButtonClicked;
        event EventHandler SendCodeButtonClicked;
        event KeyPressEventHandler CardNumberFieldKeyPress;
        event EventHandler BalancePaymentTimerTicked;
        event EventHandler VerificationCodeTimerTicked;
    }
}
