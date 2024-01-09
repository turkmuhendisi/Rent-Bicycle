using Fubis.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fubis.View.Payment.RentalPayment
{
    class RentalPaymentFormController
    {
        private IRentalPaymentForm _view = RentalPaymentForm.GetInstance();
        private User user = new User();
        private Card card = new Card();

        public RentalPaymentFormController()
        {
            _view.ConfirmButtonClicked += OnConfirmButtonClicked;
            _view.SendCodeButtonClicked += OnSendCodeButtonClicked;
            _view.CardNumberFieldKeyPress += OnCardNumberFieldKeyPress;
        }

        public object VerificationMailService { get; private set; }

        private void OnCardNumberFieldKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void OnConfirmButtonClicked(object sener, EventArgs e)
        {
            if (_view.GetVerificationCode.Length > 0 && _view.GetCardNumber.Length > 0)
            {
                if (_view.GetVerificationCode == RentalPaymentForm.GetInstance().verificationCode.ToString())
                {
                    card.CardNumber = _view.GetCardNumber;
                    card.Balance = Convert.ToDouble(BalanceForm.GetInstance().GetBalance);
                    card.Balance += CardRepository.GetInstance().GetCardBalance(card.CardNumber);
                    CardRepository cardRepository = new CardRepository(card, user);
                    cardRepository.UpdateItem();
                    DialogResult dialog = MessageBox.Show("Ödeme işlemi başarılı", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomeForm homeForm = new HomeForm();
                    homeForm.Show();
                    RentalPaymentForm.GetInstance().Close();
                    BalanceForm.GetInstance().Close();
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Ödeme yapılamadı!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Lütfen geçerli bir değer giriniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OnSendCodeButtonClicked(object sener, EventArgs e)
        {
            if (_view.GetCardNumber.Length == 16)
            {
                if (CardRepository.IsAvailableCard(_view.GetCardNumber))
                {
                    VerificationCodeMailService verificationCode = new VerificationCodeMailService();
                    verificationCode.VerificationMailSender(UserRepository.GetUserEmail(_view.GetCardNumber), RentalPaymentForm.GetInstance().verificationCode);
                    DialogResult dialog = MessageBox.Show("Kod e-posta adresinize gönderildi", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Böyle bir kart mevcut değil!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Lütfen geçerli bir değer giriniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
