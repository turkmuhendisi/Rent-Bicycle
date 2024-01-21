using Fubis.View.Balance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fubis.View
{
    public partial class BalanceForm : Form, IBalanceForm
    {
        public BalanceForm()
        {
            InitializeComponent();
            continueButton.Click += (sender, e) => ContinueButtonClicked(this, EventArgs.Empty);
            instance = this;
            BalanceFormController controller = new BalanceFormController();
        }

        private static BalanceForm instance;

        public static BalanceForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new BalanceForm();
            }
            return instance;
        }

        public event EventHandler ContinueButtonClicked;

        public string GetBalance { get => balanceField.Text.Trim(); set => throw new NotImplementedException(); }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            HomeForm.GetInstance().Show();
            this.Close();
        }
    }
}
