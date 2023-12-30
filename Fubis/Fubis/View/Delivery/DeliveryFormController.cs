using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fubis.View.Delivery
{
    class DeliveryFormController
    {
        private IDeliveryForm _view = DeliveryForm.GetInstance();

        public DeliveryFormController()
        {
            _view.ContinueButtonClicked += OnContinueButtonClicked;
        }

        private void OnContinueButtonClicked(object sender, EventArgs e)
        {
            DeliveryForm.GetInstance().Hide();
            if (IsValidCardNumber(_view.GetCardNumber))
            {
                //execute db op.
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Incorrect Input", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private bool IsValidCardNumber(string cardNumber)
        {
            return true;
        }
    }


}
