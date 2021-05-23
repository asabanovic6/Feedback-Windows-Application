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
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(File.Exists(AppDomain.CurrentDomain.BaseDirectory+"\\config.json"))
            {
                Application.Run(new SessionStartForm());
            }
            else
            {
                Application.Run(new ConfigForm());
            }
        }
    }
}
