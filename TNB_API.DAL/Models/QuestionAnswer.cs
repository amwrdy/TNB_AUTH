using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class QuestionAnswer
    {
        public int Id { get; set; }
        public int? QuestionCategory { get; set; }
        public int? QuestionId { get; set; }
        public int? AnswerType { get; set; }
        public int? AnswerSet { get; set; }

        public virtual AnswerSet AnswerSetNavigation { get; set; }
        public virtual AnswerType AnswerTypeNavigation { get; set; }
        public virtual Question Question { get; set; }
        public virtual QuestionCategory QuestionCategoryNavigation { get; set; }
    }
}
