using Cafe_Management.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management
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
            //Application.Run(new Form1());
            Application.Run(new Login());
            //Application.Run(new BillPanel());
            //Application.Run(new ManageCategory());
            // Application.Run(new ManageProduct());
            //Application.Run(new ProductDashboard());
            // Application.Run(new UserRegistration());
            // Application.Run(new ManageEmployee());
            // Application.Run(new Mp());
        }
    }
}
