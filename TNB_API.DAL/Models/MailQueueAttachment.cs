using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MailQueueAttachment
    {
        public Guid MailQueueAttachmentId { get; set; }
        public string AttachmentName { get; set; }
        public byte[] AttachmentBinary { get; set; }
        public bool IsInline { get; set; }
        public Guid MailQueueId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual MailQueue MailQueue { get; set; }
    }
}
