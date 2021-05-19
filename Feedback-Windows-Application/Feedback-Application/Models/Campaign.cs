using System;
using System.Collections.Generic;

#nullable disable

namespace Feedback_Application.Models
{
    public partial class Campaign
    {
        public Campaign()
        {
            Fadevices = new HashSet<Fadevice>();
            Questions = new HashSet<Question>();
            Sessions = new HashSet<Session>();
        }

        public int CampaignId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<Fadevice> Fadevices { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
