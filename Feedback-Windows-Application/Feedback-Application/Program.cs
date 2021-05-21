using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedback_Application
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            if (!File.Exists((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) + "\\config.json"))
            {

                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new Form2());
            }
        }
    }
}
