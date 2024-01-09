using Fubis.View.Rent;
using System;
using System.Windows.Forms;

namespace Fubis
{
    public partial class RentBicycleForm : Form, IRentBicycleForm
    {

        private static RentBicycleForm instance;

        public event EventHandler Selection1ButtonClicked;
        public event EventHandler Selection2ButtonClicked;
        public event EventHandler Selection3ButtonClicked;
        public event EventHandler Selection4ButtonClicked;
        public event EventHandler Selection5ButtonClicked;
        public event EventHandler ContinueButtonClicked;

        public PictureBox exPictureBox = new PictureBox();

        public static RentBicycleForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RentBicycleForm();
            }

            return instance;
        }
        public RentBicycleForm()
        {
            InitializeComponent();
            selection1Button.Click += (sender, e) => Selection1ButtonClicked(this, EventArgs.Empty);
            selection2Button.Click += (sender, e) => Selection2ButtonClicked(this, EventArgs.Empty);
            selection3Button.Click += (sender, e) => Selection3ButtonClicked(this, EventArgs.Empty);
            selection4Button.Click += (sender, e) => Selection4ButtonClicked(this, EventArgs.Empty);
            selection5Button.Click += (sender, e) => Selection5ButtonClicked(this, EventArgs.Empty);
            continueButton.Click += (sender, e) => ContinueButtonClicked(this, EventArgs.Empty);
            instance = this;
            RentBicycleFormController controller = new RentBicycleFormController();
        }

        private void RentBicycleForm_Load(object sender, EventArgs e)
        {
            clockPictureBox.Image = Properties.Resources.Clock_1;
            selection1Button.Visible = false;
            exPictureBox = clockPictureBox;
        }
    }
}
