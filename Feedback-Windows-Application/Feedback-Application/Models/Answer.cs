using System;
using System.Collections.Generic;

#nullable disable

namespace Feedback_Application.Models
{
    public partial class Answer
    {
        public Answer()
        {
            QuestionAnswers = new HashSet<QuestionAnswer>();
            UserResponses = new HashSet<UserResponse>();
        }

        public int? AnswerId { get; set; }
        public string AnswerText { get; set; }
        public bool IsApicture { get; set; }
        public string Base64 { get; set; }

        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
        public virtual ICollection<UserResponse> UserResponses { get; set; }
    }
}
