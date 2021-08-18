using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class UserSurveyHeader
    {
        public UserSurveyHeader()
        {
            UserSurveyDetails = new HashSet<UserSurveyDetail>();
        }

        public string SurveyId { get; set; }
        public string UserEmail { get; set; }
        public Guid? UserId { get; set; }
        public string StaffId { get; set; }
        public string CampaignId { get; set; }
        public string Comment { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsSubmitted { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<UserSurveyDetail> UserSurveyDetails { get; set; }
    }
}
