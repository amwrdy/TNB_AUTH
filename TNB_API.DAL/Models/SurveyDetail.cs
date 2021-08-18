using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class SurveyDetail
    {
        public int Id { get; set; }
        public int? QuestionNo { get; set; }
        public int? SurveyId { get; set; }
        public int? Rates { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual SurveyHeader Survey { get; set; }
    }
}
