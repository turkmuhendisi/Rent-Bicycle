using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fubis.View.Balance
{
    public class BalanceFormController
    {
        private IBalanceForm _view = BalanceForm.GetInstance();

        public BalanceFormController()
        {
            _view.ContinueButtonClicked += OnContinueButtonClicked;
        }

        public void OnContinueButtonClicked(object sender, EventArgs e)
        {
            if (_view.GetBalance.Length > 0 && Convert.ToDouble(_view.GetBalance) >= 10 && Convert.ToDouble(_view.GetBalance) <= 300)
            {
                DialogResult dialog = MessageBox.Show("Ödeme sayfasına aktarılıyorsunuz.", "Payment Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BalancePaymentForm paymentForm = new BalancePaymentForm();
                paymentForm.Show();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bakiye yüklemi en az 10TL, en fazla 300TL olabilir!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
