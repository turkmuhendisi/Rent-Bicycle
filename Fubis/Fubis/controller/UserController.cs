
namespace Fubis.controller
{
    class UserController
    {
       private User user;
       UserController(User user)
       {
          this.user = user;
       }
       public string SetNationalId(string nationalId)
       {
          user.NationalId =  nationalId;   
       }
    }
}
