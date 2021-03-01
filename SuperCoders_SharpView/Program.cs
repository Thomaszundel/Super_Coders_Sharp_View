using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SuperCoders_SharpView
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
            string splashResult = ConfigurationManager.AppSettings["SplashScreen"];
            if (splashResult == "True")
                Application.Run(new SplashScreen());
            Application.Run(new FormSharpView());
        }
    }
}
