using Fubis.View;
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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm.GetInstance().Show();
            this.Hide();
        }

        private void addBalanceButton_Click(object sender, EventArgs e)
        {
            BalanceForm.GetInstance().Show();
            this.Hide();
        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            RentBicycleForm.GetInstance().Show();
            this.Hide();
        }
    }
}
