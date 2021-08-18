using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Feedback
    {
        public Feedback()
        {
            FeedbackAttachments = new HashSet<FeedbackAttachment>();
            FeedbackItems = new HashSet<FeedbackItem>();
            FeedbackUpdatePersonalDetails = new HashSet<FeedbackUpdatePersonalDetail>();
        }

        public int FeedbackId { get; set; }
        public Guid UserId { get; set; }
        public string ReferenceNo { get; set; }
        public string ContractAccountNo { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string ContactNo2 { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string GslCategory { get; set; }
        public string SrNo { get; set; }
        public string SrType { get; set; }
        public string Nric { get; set; }
        public string OtherId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public int ApplicationModuleId { get; set; }
        public int StatusId { get; set; }
        public bool IsDeleted { get; set; }
        public string SrapplicationDetail { get; set; }

        public virtual ICollection<FeedbackAttachment> FeedbackAttachments { get; set; }
        public virtual ICollection<FeedbackItem> FeedbackItems { get; set; }
        public virtual ICollection<FeedbackUpdatePersonalDetail> FeedbackUpdatePersonalDetails { get; set; }
    }
}
