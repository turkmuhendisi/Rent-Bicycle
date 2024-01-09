using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.View.Balance
{
    public interface IBalanceForm
    {
        string GetBalance { get; set; }
        event EventHandler ContinueButtonClicked;
    }
}
