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
    public partial class PaymentForm : Form, IPaymentForm
    {
        private static PaymentForm instance;

        public static PaymentForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PaymentForm();
            }
            return instance;
        }

        public event EventHandler PaymentButtonClicked;

        public string GetCardNumber { get => cardNumberField.Text; set => throw new NotImplementedException(); }

        public PaymentForm()
        {
            InitializeComponent();

        }
    }
}
