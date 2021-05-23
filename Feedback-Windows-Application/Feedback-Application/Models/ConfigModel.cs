using System;
using System.Collections.Generic;
using System.Text;

namespace Feedback_Application.Models
{
    public class ConfigModel
    {
        public int? CampaignId { get; set; }
        public int? DeviceId { get; set; }
        public string? Name { get; set; }
        public string? IPAddress { get; set; }
        public bool? ExpectDependentQuestions { get; set; }
        public int? SessionDuration { get; set; }
        public int? PingForDependentQuestionsFrequency { get; set; }
    }
}
