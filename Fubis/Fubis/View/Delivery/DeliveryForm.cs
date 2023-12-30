using Fubis.View.Delivery;
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
    public partial class DeliveryForm : Form, IDeliveryForm
    {
        private static DeliveryForm instance;

        public static DeliveryForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new DeliveryForm();
            }

            return instance;
        }

        public string GetCardNumber { get => cardNumberField.Text; set => throw new NotImplementedException(); }

        public event EventHandler ContinueButtonClicked;

        public DeliveryForm()
        {
            InitializeComponent();
            continueButton.Click += (sender, e) => ContinueButtonClicked?.Invoke(this,EventArgs.Empty);
            instance = this;
            DeliveryFormController controller = new DeliveryFormController();
        }
    }
}
