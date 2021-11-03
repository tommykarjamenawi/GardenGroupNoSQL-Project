using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenGroupUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginScreen());
            //Application.Run(new ManageUser());
            // Application.Run(new TicketArchive());
            //Application.Run(new UserArchive());
            //Application.Run(new AddUser());
        }
    }
}
