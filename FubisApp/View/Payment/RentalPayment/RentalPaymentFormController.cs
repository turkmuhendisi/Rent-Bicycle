using Fubis.DataAccessLayer.Repository.impl;
using Fubis.Service;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Fubis.View.Payment.RentalPayment
{
    class RentalPaymentFormController
    {
        private IRentalPaymentForm _view = RentalPaymentForm.GetInstance();
        private User user = new User();
        private Card card = new Card();

        private TimeSpan currentTime = TimeSpan.FromMinutes(2);

        public RentalPaymentFormController()
        {
            _view.ConfirmButtonClicked += OnConfirmButtonClicked;
            _view.SendCodeButtonClicked += OnSendCodeButtonClicked;
            _view.CardNumberFieldKeyPress += OnCardNumberFieldKeyPress;
            _view.RentalPaymentTimerTicked += OnRentalPaymentTimerTicked;
            _view.VerificationCodeTimerTicked += OnVerificationCodeTimerTicked;
        }

        public void OnRentalPaymentTimerTicked(object sender, EventArgs e)
        {
            if (RentalPaymentForm.GetInstance().rentalPaymentProgressBar.Value < 100)
            {
                RentalPaymentForm.GetInstance().rentalPaymentProgressBar.Value += 10;
            }
            else
            {
                RentalPaymentForm.GetInstance().progressBarTimer.Stop();
                RentalPaymentForm.GetInstance().RentalPaymentTimerTicked -= OnRentalPaymentTimerTicked;
            }
        }

        public void OnVerificationCodeTimerTicked(object sender, EventArgs e)
        {
            if (currentTime.TotalSeconds > 0)
            {
                currentTime = currentTime.Subtract(TimeSpan.FromSeconds(0.5));
                RentalPaymentForm.GetInstance().verificationCodeTimerLabel.Text = currentTime.ToString(@"m\:ss");
            }
            else
            {
                RentalPaymentForm.GetInstance().verificationCodeTimer.Stop();
                RentalPaymentForm.GetInstance().VerificationCodeTimerTicked -= OnVerificationCodeTimerTicked;
                DialogResult dialog = MessageBox.Show("Doğrulama kodunu belirtilen süre içerisinde girmediniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Thread.Sleep(1000);
                RentalPaymentForm.GetInstance().verificationCodeTimerLabel.Visible = false;
                HomeForm.GetInstance().Show();
                RentalPaymentForm.GetInstance().Close();
                RentBicycleForm.GetInstance().Close();
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
            if (CardRepository.GetInstance().CardBalanceControl(RentBicycleForm.GetInstance().GetPrice, _view.GetCardNumber))
            {
                if (_view.GetVerificationCode.Length > 0 && _view.GetCardNumber.Length > 0)
                {
                    if (_view.GetVerificationCode == RentalPaymentForm.GetInstance().verificationCode.ToString())
                    {
                        card.CardNumber = _view.GetCardNumber;
                        card.Balance = CardRepository.GetInstance().GetCardBalance(card.CardNumber);
                        card.Balance -= Convert.ToDouble(RentBicycleForm.GetInstance().GetPrice);
                        CardRepository cardRepository = new CardRepository(card, user);
                        cardRepository.UpdateItem();

                        RentalPaymentForm.GetInstance().rentalPaymentProgressBar.Visible = true;
                        RentalPaymentForm.GetInstance().progressBarTimer.Start();
                        RentalPaymentForm.GetInstance().RentalPaymentTimerTicked += OnRentalPaymentTimerTicked;

                        DialogResult dialog1 = MessageBox.Show("Ödeme işlemi başarılı", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Thread.Sleep(1000);

                        RentalService rentalService = new RentalService();
                        user.UserId = UserRepository.GetUserId(_view.GetCardNumber);
                        rentalService.RentBicycle(user.UserId.ToString());

                        DialogResult dialog2 = MessageBox.Show($"{rentalService.ShowBicycleNumber()} numaralı bisikleti alabilirsiniz.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        HomeForm.GetInstance().Show();
                        RentalPaymentForm.GetInstance().Close();
                        RentBicycleForm.GetInstance().Close();
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
            else
            {
                DialogResult dialog = MessageBox.Show("Bakiye yetersiz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Thread.Sleep(3000);
                HomeForm.GetInstance().Show();
                RentalPaymentForm.GetInstance().Close();
                RentBicycleForm.GetInstance().Close();
            }
        }

        public void OnSendCodeButtonClicked(object sener, EventArgs e)
        {
            if (_view.GetCardNumber.Length == 16)
            {
                if (CardRepository.IsAvailableCard(_view.GetCardNumber))
                {
                    if (!RentalRepository.Rentalable(_view.GetCardNumber))
                    {
                        VerificationCodeMailService verificationCode = new VerificationCodeMailService();
                        verificationCode.VerificationMailSender(UserRepository.GetUserEmail(_view.GetCardNumber), RentalPaymentForm.GetInstance().verificationCode);

                        RentalPaymentForm.GetInstance().verificationCodeTimer.Start();
                        RentalPaymentForm.GetInstance().verificationCodeTimer.Interval = 1000;
                        RentalPaymentForm.GetInstance().VerificationCodeTimerTicked += OnVerificationCodeTimerTicked;
                        RentalPaymentForm.GetInstance().verificationCodeTimerLabel.Visible = true;

                        DialogResult dialog = MessageBox.Show("Kod e-posta adresinize gönderildi", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Aynı anda 2 bisiklet kiralanamaz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Thread.Sleep(3000);
                        HomeForm.GetInstance().Show();
                        RentalPaymentForm.GetInstance().Close();
                        RentBicycleForm.GetInstance().Close();
                    }
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
