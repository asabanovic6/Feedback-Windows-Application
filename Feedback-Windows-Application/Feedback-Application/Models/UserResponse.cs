using System;
using System.Collections.Generic;

#nullable disable

namespace Feedback_Application.Models
{
    public partial class UserResponse
    {
        public int Id { get; set; }
        public int? AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string CustomAnswer { get; set; }
        public int SessionId { get; set; }

        public virtual Answer Answer { get; set; }
        public virtual Question Question { get; set; }
        public virtual Session Session { get; set; }
    }
}
