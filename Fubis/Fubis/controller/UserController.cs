
namespace Fubis.controller
{
    class UserController
    {
        private User user;

        public UserController()
        {
            this.user = new User();
        }

        public void SetNationalId(string nationalId)
        {
            user.NationalId = nationalId;
        }

        public void SetEmail(string email)
        {
            user.Email = email;
        }
    }
}
