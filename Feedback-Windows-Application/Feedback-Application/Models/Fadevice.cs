using System;
using System.Collections.Generic;

#nullable disable

namespace Feedback_Application.Models
{
    public partial class Fadevice
    {
        public int DeviceId { get; set; }
        public int CampaignId { get; set; }
        public bool PingForDependent { get; set; }

        public virtual Campaign Campaign { get; set; }
    }
}
