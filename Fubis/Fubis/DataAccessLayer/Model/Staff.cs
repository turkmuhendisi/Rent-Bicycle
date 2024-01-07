
namespace Fubis.DataAccessLayer.Model
{
    public class Staff
    {
        private int staffId;
        private string firstName;
        private string lastName;
        private string role;
        private string staffCardNumber;
        private int districtId;

        public int StaffId { get => staffId; set => staffId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Role { get => role; set => role = value; }
        public string StaffCardNumber { get => staffCardNumber; set => staffCardNumber = value; }
        public int DistrictId { get => districtId; set => districtId = value; }

        private static Staff instance;

        public static Staff GetInstance()
        {
            if (instance == null)
            {
                instance = new Staff();
            }

            return instance;
        }

        public Staff()
        {
        }

        public Staff(string firstName, string lastName, string role, string staffCardNumber, int districtId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.role = role;
            this.staffCardNumber = staffCardNumber;
            this.districtId = districtId;
        }
    }
}
