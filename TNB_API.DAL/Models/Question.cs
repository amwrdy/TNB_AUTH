using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Question
    {
        public Question()
        {
            QuestionAnswers = new HashSet<QuestionAnswer>();
            QuestionPrequesiteSetPreviousQuestions = new HashSet<QuestionPrequesiteSet>();
            QuestionPrequesiteSetQuestions = new HashSet<QuestionPrequesiteSet>();
        }

        public int Id { get; set; }
        public string Questions { get; set; }

        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
        public virtual ICollection<QuestionPrequesiteSet> QuestionPrequesiteSetPreviousQuestions { get; set; }
        public virtual ICollection<QuestionPrequesiteSet> QuestionPrequesiteSetQuestions { get; set; }
    }
}
