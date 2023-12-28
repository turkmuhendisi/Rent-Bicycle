
using Fubis.controller;
using System.Windows.Forms;

namespace Fubis
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, System.EventArgs e)
        {
            UserController userController = new UserController();
            userController.SetNationalId(nationalIdField.Text);
            userController.SetEmail(emailField.Text);
        }
    }
}
