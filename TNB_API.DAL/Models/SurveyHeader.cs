using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class SurveyHeader
    {
        public SurveyHeader()
        {
            SurveyDetails = new HashSet<SurveyDetail>();
        }

        public int SurveyId { get; set; }
        public Guid? ContractorId { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? SentOn { get; set; }
        public bool? IsSubmited { get; set; }
        public DateTime? SubmitedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public int? NewConnectionId { get; set; }
        public int? RewiringId { get; set; }

        public virtual ICollection<SurveyDetail> SurveyDetails { get; set; }
    }
}
