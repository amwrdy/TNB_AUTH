using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class SurveyResult
    {
        public int Id { get; set; }
        public string QuestionValue { get; set; }
        public string AnswerValue { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public Guid TransactionId { get; set; }
        public string QuestionCategoryValue { get; set; }
        public string ModuleName { get; set; }
        public DateTime SubmitDateTime { get; set; }
    }
}
