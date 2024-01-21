using Fubis.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fubis.View.Payment.RentalPayment
{
    public partial class RentalPaymentForm : Form, IRentalPaymentForm
    {
        public int verificationCode = VerificationCode.GetInstance().digitGenerator();
        private static RentalPaymentForm instance;

        public static RentalPaymentForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RentalPaymentForm();
            }
            return instance;
        }

        public event EventHandler ConfirmButtonClicked;
        public event EventHandler SendCodeButtonClicked;
        public event KeyPressEventHandler CardNumberFieldKeyPress;
        public event EventHandler RentalPaymentTimerTicked;
        public event EventHandler VerificationCodeTimerTicked;

        public string GetCardNumber { get => cardNumberField.Text; set => throw new NotImplementedException(); }
        public string GetVerificationCode { get => verificationCodeField.Text.Trim(); set => throw new NotImplementedException(); }

        public RentalPaymentForm()
        {
            InitializeComponent();
            sendCodeButton.Click += (sender, e) => SendCodeButtonClicked(this, EventArgs.Empty);
            confirmButton.Click += (sender, e) => ConfirmButtonClicked(this, EventArgs.Empty);
            cardNumberField.KeyPress += (sender, e) => CardNumberFieldKeyPress(this, e);
            progressBarTimer.Tick += (sender, e) => RentalPaymentTimerTicked(this, EventArgs.Empty);
            verificationCodeTimer.Tick += (sender, e) => VerificationCodeTimerTicked(this, EventArgs.Empty);
            instance = this;
            RentalPaymentFormController controller = new RentalPaymentFormController();
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            HomeForm.GetInstance().Show();
            this.Close();
            RentBicycleForm.GetInstance().Close();
        }
    }
}
