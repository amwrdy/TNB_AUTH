using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class QuestionPrequesiteSet
    {
        public Guid Id { get; set; }
        public int QuestionId { get; set; }
        public int PreviousQuestionId { get; set; }
        public string AnswerValue { get; set; }
        public string QuestionDescription { get; set; }

        public virtual Question PreviousQuestion { get; set; }
        public virtual Question Question { get; set; }
    }
}
