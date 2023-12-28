
namespace Fubis
{
    public class User
    {
        private int userId;
        private string firstName;
        private string lastName;
        private string nationalId;
        private string email;

        public int UserId { get => userId; set => userId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string NationalId { get => nationalId; set => nationalId = value; }
        public string Email { get => email; set => email = value; }

        public User()
        {
        }

        public User(int userId, string firstName, string lastName, string nationalId, string email)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.nationalId = nationalId;
            this.email = email;
        }
    }
}
