using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.View.Staffs.UserControls.BicycleMaintenance
{
    public interface IBicycleMaintenance
    {
        int GetBicycleId { get; }
        bool GetInMaintenance { get; }
        event EventHandler startMaintenanceButtonClicked;
        event EventHandler finishMaintenanceButtonClicked;
    }
}
