
using Feedback_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feedback_Application.DatabaseService
{
    class FADBService
    {
        //testna funkcija da vidimo da li baza radi
        public List<Campaign> GetCampaigns()
        {
            FAContext faContext = new FAContext();
            var campaigns = faContext.Campaigns.ToList();
            return campaigns;
        }
    }
}
