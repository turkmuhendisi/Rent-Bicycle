using Fubis.Service;
using Fubis.View.Admin;
using Fubis.View.Staffs.UserControls.BicycleMaintenance;
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
        private CardNumberGenerator cardNumberGenerator = new CardNumberGenerator();


        public RegisterFormController()
        {
            _view.RegisterButtonClicked += OnRegisterButtonClicked;
            _view.NationalIdFieldKeyPress += OnNationalIdFieldKeyPress;
        }

        private void OnNationalIdFieldKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            if (_view.GetNationalId.Length == 11 && _view.GetEmail.Length != 0)
            {
                StaffLoginSystem staffLoginSystem = new StaffLoginSystem();
                if (!UserRepository.IsAvailableUser(_view.GetNationalId, _view.GetEmail))
                {
                    user.NationalId = _view.GetNationalId;
                    user.Email = _view.GetEmail;

                    UserRepository userRepository = new UserRepository(user);

                    userRepository.AddItem();

                    user.UserId = userRepository.UserGetId();
                    card.CardNumber = cardNumberGenerator.GeneratedCardNumberForUser();
                    card.Balance = 0;

                    CardRepository cardRepository = new CardRepository(card, user);
                    cardRepository.AddItem();

                    UserMailService userMailService = new UserMailService();
                    userMailService.MailSender(card.CardNumber, user.Email);

                    DialogResult dialog = MessageBox.Show("Kayıt başarılı", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HomeForm.GetInstance().Show();
                    RegisterForm.GetInstance().Close();
                }
                //For Staff and Admin
                if (staffLoginSystem.StaffLoginValidation(_view.GetNationalId, _view.GetEmail))
                {
                    StaffForm staffForm = new StaffForm();
                    staffForm.Show();
                    RegisterForm.GetInstance().Close();
                }
                if (staffLoginSystem.AdminLoginValidation(_view.GetNationalId, _view.GetEmail))
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    RegisterForm.GetInstance().Close();
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Lütfen bilgilerinizi kontrol ediniz!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
