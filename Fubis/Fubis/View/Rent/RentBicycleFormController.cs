using Fubis.View.Payment.RentalPayment;
using System;

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
            RentBicycleForm.GetInstance().exPictureBox.Image = Properties.Resources.Clock_1;
            RentBicycleForm.GetInstance().selection1Button.Visible = false;
            RentBicycleForm.GetInstance().selection2Button.Visible = true;
            RentBicycleForm.GetInstance().selection3Button.Visible = true;
            RentBicycleForm.GetInstance().selection4Button.Visible = true;
            RentBicycleForm.GetInstance().selection5Button.Visible = true;
        }
        public void OnSelection2ButtonClicked(object sender, EventArgs e)
        {
            RentBicycleForm.GetInstance().exPictureBox.Image = Properties.Resources.Clock_2;
            RentBicycleForm.GetInstance().selection1Button.Visible = true;
            RentBicycleForm.GetInstance().selection2Button.Visible = false;
            RentBicycleForm.GetInstance().selection3Button.Visible = true;
            RentBicycleForm.GetInstance().selection4Button.Visible = true;
            RentBicycleForm.GetInstance().selection5Button.Visible = true;
        }
        public void OnSelection3ButtonClicked(object sender, EventArgs e)
        {
            RentBicycleForm.GetInstance().exPictureBox.Image = Properties.Resources.Clock_3;
            RentBicycleForm.GetInstance().selection1Button.Visible = true;
            RentBicycleForm.GetInstance().selection2Button.Visible = true;
            RentBicycleForm.GetInstance().selection3Button.Visible = false;
            RentBicycleForm.GetInstance().selection4Button.Visible = true;
            RentBicycleForm.GetInstance().selection5Button.Visible = true;
        }
        public void OnSelection4ButtonClicked(object sender, EventArgs e)
        {
            RentBicycleForm.GetInstance().exPictureBox.Image = Properties.Resources.Clock_4;
            RentBicycleForm.GetInstance().selection1Button.Visible = true;
            RentBicycleForm.GetInstance().selection2Button.Visible = true;
            RentBicycleForm.GetInstance().selection3Button.Visible = true;
            RentBicycleForm.GetInstance().selection4Button.Visible = false;
            RentBicycleForm.GetInstance().selection5Button.Visible = true;
        }
        public void OnSelection5ButtonClicked(object sender, EventArgs e)
        {
            RentBicycleForm.GetInstance().exPictureBox.Image = Properties.Resources.Clock_5;
            RentBicycleForm.GetInstance().selection1Button.Visible = true;
            RentBicycleForm.GetInstance().selection2Button.Visible = true;
            RentBicycleForm.GetInstance().selection3Button.Visible = true;
            RentBicycleForm.GetInstance().selection4Button.Visible = true;
            RentBicycleForm.GetInstance().selection5Button.Visible = false;
        }
        public void OnContinueButtonClicked(object sender, EventArgs e)
        {
            RentalPaymentForm.GetInstance().Show();
        }
    }
}
