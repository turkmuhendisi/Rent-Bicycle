using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.View.Admin.UserControls.ModeratorManagement
{
    public interface IModeratorManagement
    {
        int GetStaffId { get; }
        string GetFirstName { get; }
        string GetLastName { get; }
        string GetRole { get; }
        int GetDistrcitId { get; }
        event EventHandler AddButtonClicked;
        event EventHandler UpdateButtonClicked;
        event EventHandler DeleteButtonClicked;
    }
}
