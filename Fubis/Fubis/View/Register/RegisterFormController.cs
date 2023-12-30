using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fubis.View.Register
{

    class RegisterFormController
    {
        private IRegisterForm _view = RegisterForm.GetInstance();
        private User user = new User();
        private Card card = new Card();

        public RegisterFormController()
        {
            _view.RegisterButtonClicked += OnRegisterButtonClicked;
            _view.NationalIdFieldKeyPress += NationalIdFieldKeyPress;
        }

        private void NationalIdFieldKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            if (!UserValid.IsAvailableUser(_view.GetNationalId, _view.GetEmail))
            {
                user.NationalId = _view.GetNationalId;
                user.Email = _view.GetEmail;

                UserRepository userRepository = new UserRepository(user);

                userRepository.AddItem();

                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                RegisterForm.GetInstance().Hide();

                user.UserId = userRepository.UserGetId();


                CardRepository cardRepository = new CardRepository(card,user);

                MessageBox.Show("Successfully");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Invalid Input!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
