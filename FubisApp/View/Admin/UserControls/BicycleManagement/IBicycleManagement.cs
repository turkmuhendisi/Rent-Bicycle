
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.View.Admin.UserControls.BicycleManagement
{
    public interface IBicycleManagement
    {
        string Quantity { get; }
        int GetDistrictId { get; }
        int GetBicycleId { get; }
        event EventHandler AddButtonClicked;
        event EventHandler DeleteButtonClicked;
    }
}
