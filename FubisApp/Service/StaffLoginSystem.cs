using Fubis.DataAccessLayer.Model;
using Fubis.DataAccessLayer.Repository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fubis.Service
{
    public class StaffLoginSystem
    {   
        public bool StaffLoginValidation(string fieldValidation, string staffCardNumber)
        {
            if (StaffRepository.IsAvailableStaff(staffCardNumber) && fieldValidation == "11111111111")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AdminLoginValidation(string fieldValidation, string adminCardNumber)
        {
            if (adminCardNumber == "10102401809101" && fieldValidation == "99999999999")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
