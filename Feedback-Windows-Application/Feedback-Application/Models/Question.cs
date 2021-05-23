using System;
using System.Collections.Generic;

#nullable disable

namespace Feedback_Application.Models
{
    public partial class Question
    {
        public Question()
        {
            QuestionAnswers = new HashSet<QuestionAnswer>();
            UserResponses = new HashSet<UserResponse>();
        }

        public int QuestionId { get; set; }
        public string QuestionType { get; set; }
        public string QuestionText { get; set; }
        public bool IsDependent { get; set; }
        public string? Data1 { get; set; }
        public string? Data2 { get; set; }
        public string? Data3 { get; set; }
        public int CampaignId { get; set; }

        public virtual Campaign Campaign { get; set; }
        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
        public virtual ICollection<UserResponse> UserResponses { get; set; }
    }
}
