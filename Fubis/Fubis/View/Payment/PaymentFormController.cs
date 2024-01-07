using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.View.Payment
{
    class PaymentFormController
    {
        private IPaymentForm _view = PaymentForm.GetInstance();

        public PaymentFormController()
        {
            _view.PaymentButtonClicked += OnPaymentButtonClicked;
        }

        public void OnPaymentButtonClicked(object sener, EventArgs e)
        {
            //CardRepository cardRepository = new CardRepository();
        }
    }
}
