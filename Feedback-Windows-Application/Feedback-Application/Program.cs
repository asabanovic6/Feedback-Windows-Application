using Feedback_Application.DatabaseService;
using Feedback_Application.Models;
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
                var DbService = new FADBService();
                var campaign = DbService.GetCampaign();
                var configModel = HelperMethods.GetConfigFile();
                campaign.Sessions.Add(new Session() { IsSynced = false, CampaignId = (int)campaign.CampaignId, Duration = (int)configModel.SessionDuration });
                QuestionsForm sesija = new QuestionsForm(campaign);
                Application.Run(sesija);
            }
            else
            {
                Application.Run(new ConfigForm());
            }
        }
    }
}
