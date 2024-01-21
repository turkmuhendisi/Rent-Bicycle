using Fubis.Service;
using Fubis.View.Admin;
using Fubis.View.Staffs.UserControls.BicycleMaintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fubis
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //CardNumberGenerator generator = new CardNumberGenerator();
            //Console.WriteLine(generator.GeneratedCardNumberForAdmin());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm());
        }
    }
}
