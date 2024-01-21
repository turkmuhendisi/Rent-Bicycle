using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.View.Rent
{
    public interface IRentBicycleForm
    {
        double GetPrice { get; set; }
        event EventHandler Selection1ButtonClicked;
        event EventHandler Selection2ButtonClicked;
        event EventHandler Selection3ButtonClicked;
        event EventHandler Selection4ButtonClicked;
        event EventHandler Selection5ButtonClicked;

        event EventHandler ContinueButtonClicked;
    }
}
