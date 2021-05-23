using Feedback_Application.DatabaseService;
using Feedback_Application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Feedback_Application
{
    public partial class SessionStartForm : MetroFramework.Forms.MetroForm
    {
        private Campaign campaign;
        private FADBService DbService;
        private ConfigModel configModel;
        public SessionStartForm()
        {
            InitializeComponent();
            DbService = new FADBService();
            campaign = DbService.GetCampaign();
            configModel = HelperMethods.GetConfigFile();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnStartSession_Click(object sender, EventArgs e)
        {
            campaign.Sessions.Add(new Session() { IsSynced = false, CampaignId = (int)campaign.CampaignId, Duration = (int)configModel.SessionDuration });
            QuestionsForm sesija = new QuestionsForm(campaign);
            this.Hide();
            sesija.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
