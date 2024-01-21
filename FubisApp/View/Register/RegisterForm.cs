
using Fubis.View.Register;
using System;
using System.Windows.Forms;

namespace Fubis
{
    public partial class RegisterForm : Form, IRegisterForm
    {
        private static RegisterForm instance;

        public static RegisterForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                return instance = new RegisterForm();
            }

            return instance;
        }

        public event EventHandler RegisterButtonClicked;
        public event KeyPressEventHandler NationalIdFieldKeyPress;

        public string GetNationalId { get => nationalIdField.Text.Trim(); set => throw new NotImplementedException(); }
        public string GetEmail { get => emailField.Text.Trim(); set => throw new NotImplementedException(); }

        public RegisterForm()
        {
            InitializeComponent();
            registerButton.Click += (sender, e) => RegisterButtonClicked(this, EventArgs.Empty);
            nationalIdField.KeyPress += (sender, e) => NationalIdFieldKeyPress(this, e);
            instance = this;
            RegisterFormController controller = new RegisterFormController();
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            HomeForm.GetInstance().Show();
            this.Close();
        }
    }
}
