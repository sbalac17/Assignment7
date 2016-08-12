using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Shivya Balachandran 
    300 884 989 
    Comp 123 - Assignment 7
*/

namespace Assignment7
{
    /**
    * <summary>
    * This class contains the main entry point for the application
    * </summary>
    * 
    * @class Program
    */
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

            Application.Idle += Application_Idle;

            SplashForm form = new SplashForm();
            form.Show();

            Application.Run();
        }

        /**
        * <summary>
        * This event handler exits the application when all forms are closed
        * </summary>
        * 
        * @method Application_Idle
        * @param {object} sender
        * @param {EventArgs} e
        */
        private static void Application_Idle(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
