using Fubis.DataAccessLayer.Repository.impl;
using Fubis.View.Payment.RentalPayment;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Fubis.View.Rent
{
    public class RentBicycleFormController
    {
        private IRentBicycleForm _view = RentBicycleForm.GetInstance();

        public RentBicycleFormController()
        {
            _view.Selection1ButtonClicked += OnSelection1ButtonClicked;
            _view.Selection2ButtonClicked += OnSelection2ButtonClicked;
            _view.Selection3ButtonClicked += OnSelection3ButtonClicked;
            _view.Selection4ButtonClicked += OnSelection4ButtonClicked;
            _view.Selection5ButtonClicked += OnSelection5ButtonClicked;
            _view.ContinueButtonClicked += OnContinueButtonClicked;
        }

        public void OnSelection1ButtonClicked(object sender, EventArgs e)
        {
            RentBicycleForm.GetInstance().exPictureBox.Image = FubisApp.Properties.Resources.Clock_1;
            RentBicycleForm.GetInstance().selection1Button.Visible = false;
            RentBicycleForm.GetInstance().selection2Button.Visible = true;
            RentBicycleForm.GetInstance().selection3Button.Visible = true;
            RentBicycleForm.GetInstance().selection4Button.Visible = true;
            RentBicycleForm.GetInstance().selection5Button.Visible = true;
            RentBicycleForm.GetInstance().rentalTimeLabel.Text = "1 saat";
            RentBicycleForm.GetInstance().rentalPriceLabel.Text = "20TL";
            _view.GetPrice = 20;
        }
        public void OnSelection2ButtonClicked(object sender, EventArgs e)
        {
            RentBicycleForm.GetInstance().exPictureBox.Image = FubisApp.Properties.Resources.Clock_2;
            RentBicycleForm.GetInstance().selection1Button.Visible = true;
            RentBicycleForm.GetInstance().selection2Button.Visible = false;
            RentBicycleForm.GetInstance().selection3Button.Visible = true;
            RentBicycleForm.GetInstance().selection4Button.Visible = true;
            RentBicycleForm.GetInstance().selection5Button.Visible = true;
            RentBicycleForm.GetInstance().rentalTimeLabel.Text = "2 saat";
            RentBicycleForm.GetInstance().rentalPriceLabel.Text = "40TL";
            _view.GetPrice = 40;
        }
        public void OnSelection3ButtonClicked(object sender, EventArgs e)
        {
            RentBicycleForm.GetInstance().exPictureBox.Image = FubisApp.Properties.Resources.Clock_3;
            RentBicycleForm.GetInstance().selection1Button.Visible = true;
            RentBicycleForm.GetInstance().selection2Button.Visible = true;
            RentBicycleForm.GetInstance().selection3Button.Visible = false;
            RentBicycleForm.GetInstance().selection4Button.Visible = true;
            RentBicycleForm.GetInstance().selection5Button.Visible = true;
            RentBicycleForm.GetInstance().rentalTimeLabel.Text = "3 saat";
            RentBicycleForm.GetInstance().rentalPriceLabel.Text = "60TL";
            _view.GetPrice = 60;
        }
        public void OnSelection4ButtonClicked(object sender, EventArgs e)
        {
            RentBicycleForm.GetInstance().exPictureBox.Image = FubisApp.Properties.Resources.Clock_4;
            RentBicycleForm.GetInstance().selection1Button.Visible = true;
            RentBicycleForm.GetInstance().selection2Button.Visible = true;
            RentBicycleForm.GetInstance().selection3Button.Visible = true;
            RentBicycleForm.GetInstance().selection4Button.Visible = false;
            RentBicycleForm.GetInstance().selection5Button.Visible = true;
            RentBicycleForm.GetInstance().rentalTimeLabel.Text = "4 saat";
            RentBicycleForm.GetInstance().rentalPriceLabel.Text = "80TL";
            _view.GetPrice = 80;
        }
        public void OnSelection5ButtonClicked(object sender, EventArgs e)
        {
            RentBicycleForm.GetInstance().exPictureBox.Image = FubisApp.Properties.Resources.Clock_5;
            RentBicycleForm.GetInstance().selection1Button.Visible = true;
            RentBicycleForm.GetInstance().selection2Button.Visible = true;
            RentBicycleForm.GetInstance().selection3Button.Visible = true;
            RentBicycleForm.GetInstance().selection4Button.Visible = true;
            RentBicycleForm.GetInstance().selection5Button.Visible = false;
            RentBicycleForm.GetInstance().rentalTimeLabel.Text = "5 saat";
            RentBicycleForm.GetInstance().rentalPriceLabel.Text = "100TL";
            _view.GetPrice = 100;
        }
        public void OnContinueButtonClicked(object sender, EventArgs e)
        {
            BicycleRepository bicycleRepository = new BicycleRepository();
            if (bicycleRepository.GetAvailableBicycle() != null)
            {
                DialogResult dialog = MessageBox.Show("Ödeme sayfasına aktarılıyorsunuz.", "Payment Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RentalPaymentForm.GetInstance().Show();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Mevcutta bisiklet bulunmamaktadır!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Thread.Sleep(3000);
                HomeForm.GetInstance().Show();
                RentBicycleForm.GetInstance().Close();
            }
        }
    }
}
