using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fubis.View.Register
{
    public interface IRegisterForm
    {
        string GetNationalId { get; set; }
        string GetEmail { get; set; }

        event EventHandler RegisterButtonClicked;
        event KeyPressEventHandler NationalIdFieldKeyPress;
    }
}
