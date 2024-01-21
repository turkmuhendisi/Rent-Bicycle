using Fubis.Service;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Fubis.View.Payment
{
    class BalancePaymentFormController
    {
        private IBalancePaymentForm _view = BalancePaymentForm.GetInstance();
        private User user = new User();
        private Card card = new Card();

        private TimeSpan currentTime = TimeSpan.FromMinutes(2);

        public BalancePaymentFormController()
        {
            _view.ConfirmButtonClicked += OnConfirmButtonClicked;
            _view.SendCodeButtonClicked += OnSendCodeButtonClicked;
            _view.CardNumberFieldKeyPress += OnCardNumberFieldKeyPress;
            _view.BalancePaymentTimerTicked += OnBalancePaymentTimerTicked;
            _view.VerificationCodeTimerTicked += OnVerificationCodeTimerTicked;
        }

        public void OnBalancePaymentTimerTicked(object sender, EventArgs e)
        {
            if (BalancePaymentForm.GetInstance().balancePaymentProgressBar.Value < 100)
            {
                BalancePaymentForm.GetInstance().balancePaymentProgressBar.Value += 10;
            }
            else
            {
                BalancePaymentForm.GetInstance().progressBarTimer.Stop();
                BalancePaymentForm.GetInstance().BalancePaymentTimerTicked -= OnBalancePaymentTimerTicked;
            }
        }

        public void OnVerificationCodeTimerTicked(object sender, EventArgs e)
        {
            if (currentTime.TotalSeconds > 0)
            {
                currentTime = currentTime.Subtract(TimeSpan.FromSeconds(0.5));
                BalancePaymentForm.GetInstance().verificationCodeTimerLabel.Text = currentTime.ToString(@"m\:ss");
            }
            else
            {
                BalancePaymentForm.GetInstance().verificationCodeTimer.Stop();
                BalancePaymentForm.GetInstance().VerificationCodeTimerTicked -= OnVerificationCodeTimerTicked;
                DialogResult dialog = MessageBox.Show("Doğrulama kodunu belirtilen süre içerisinde girmediniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Thread.Sleep(1000);
                BalancePaymentForm.GetInstance().verificationCodeTimerLabel.Visible = false;
                HomeForm.GetInstance().Show();
                BalancePaymentForm.GetInstance().Close();
                BalanceForm.GetInstance().Close();
            }
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
                if (_view.GetVerificationCode == BalancePaymentForm.GetInstance().verificationCode.ToString())
                {
                    card.CardNumber = _view.GetCardNumber;
                    card.Balance = Convert.ToDouble(BalanceForm.GetInstance().GetBalance);
                    card.Balance += CardRepository.GetInstance().GetCardBalance(card.CardNumber);
                    CardRepository cardRepository = new CardRepository(card, user);
                    cardRepository.UpdateItem();

                    BalancePaymentForm.GetInstance().balancePaymentProgressBar.Visible = true;
                    BalancePaymentForm.GetInstance().progressBarTimer.Start();
                    BalancePaymentForm.GetInstance().BalancePaymentTimerTicked += OnBalancePaymentTimerTicked;

                    DialogResult dialog = MessageBox.Show("Ödeme işlemi başarılı", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(1000);

                    HomeForm.GetInstance().Show();
                    BalancePaymentForm.GetInstance().Close();
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
                    verificationCode.VerificationMailSender(UserRepository.GetUserEmail(_view.GetCardNumber), BalancePaymentForm.GetInstance().verificationCode);

                    BalancePaymentForm.GetInstance().verificationCodeTimer.Start();
                    BalancePaymentForm.GetInstance().verificationCodeTimer.Interval = 1000;
                    BalancePaymentForm.GetInstance().VerificationCodeTimerTicked += OnVerificationCodeTimerTicked;
                    BalancePaymentForm.GetInstance().verificationCodeTimerLabel.Visible = true;

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
