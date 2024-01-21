
namespace Fubis
{
    public class User
    {
        private int userId;
        private string nationalId;
        private string email;

        public int UserId { get => userId; set => userId = value; }
        public string NationalId { get => nationalId; set => nationalId = value; }
        public string Email { get => email; set => email = value; }

        private static User instance;

        public static User GetInstance()
        {
            if (instance == null)
            {
                instance = new User();
            }

            return instance;
        }

        public User()
        {
        }

        public User(string nationalId, string email)
        {
            this.nationalId = nationalId;
            this.email = email;
        }
    }
}
