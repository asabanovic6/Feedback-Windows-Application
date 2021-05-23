using System;
using System.Collections.Generic;
using System.Text;

namespace Feedback_Application.Models
{
    public class ActivateDeviceModel
    {
        public string Name { get; set; }
        public int DeviceId { get; set; }
        public int CampaignID { get; set; }
    }
}
