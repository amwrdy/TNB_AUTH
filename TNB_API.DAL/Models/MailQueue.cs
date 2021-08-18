using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MailQueue
    {
        public MailQueue()
        {
            MailQueueAttachments = new HashSet<MailQueueAttachment>();
        }

        public Guid MailQueueId { get; set; }
        public string MailTo { get; set; }
        public string MailCc { get; set; }
        public string MailBcc { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }
        public DateTime? SentDateTime { get; set; }
        public int? SentCount { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<MailQueueAttachment> MailQueueAttachments { get; set; }
    }
}
