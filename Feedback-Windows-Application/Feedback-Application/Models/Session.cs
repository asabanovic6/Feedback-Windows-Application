using System;
using System.Collections.Generic;

#nullable disable

namespace Feedback_Application.Models
{
    public partial class Session
    {
        public Session()
        {
            UserResponses = new HashSet<UserResponse>();
        }

        public int SessionId { get; set; }
        public int CampaignId { get; set; }
        public int Duration { get; set; }

        public virtual Campaign Campaign { get; set; }
        public virtual ICollection<UserResponse> UserResponses { get; set; }
    }
}
