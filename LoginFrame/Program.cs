using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFrame
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

<<<<<<< HEAD
            Application.Run(new UploadNews());
=======
            Application.Run(new Login());
>>>>>>> 55867dd2dc0bdf070a14193cf4bdfdd0931e44f8
            

        }
    }
}
