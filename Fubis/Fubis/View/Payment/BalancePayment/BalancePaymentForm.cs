using Fubis.Service;
using Fubis.View.Payment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fubis
{
    public partial class BalancePaymentForm : Form, IBalancePaymentForm
    {
        public int verificationCode = VerificationCode.GetInstance().digitGenerator();
        private static BalancePaymentForm instance;

        public static BalancePaymentForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new BalancePaymentForm();
            }
            return instance;
        }
       
        public event EventHandler ConfirmButtonClicked;
        public event EventHandler SendCodeButtonClicked;
        public event KeyPressEventHandler CardNumberFieldKeyPress;

        public string GetCardNumber { get => cardNumberField.Text; set => throw new NotImplementedException(); }
        public string GetVerificationCode { get => verificationCodeField.Text.Trim(); set => throw new NotImplementedException(); }

        public BalancePaymentForm()
        {
            InitializeComponent();
            sendCodeButton.Click += (sender, e) => SendCodeButtonClicked(this, EventArgs.Empty);
            confirmButton.Click += (sender, e) => ConfirmButtonClicked(this, EventArgs.Empty);
            cardNumberField.KeyPress += (sender, e) => CardNumberFieldKeyPress(this, e);
            instance = this;
            BalancePaymentFormController controller = new BalancePaymentFormController();
        }
    }
}
