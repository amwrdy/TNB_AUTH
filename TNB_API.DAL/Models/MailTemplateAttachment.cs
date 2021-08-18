using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MailTemplateAttachment
    {
        public Guid MailTemplateAttachmentId { get; set; }
        public string AttachmentName { get; set; }
        public byte[] AttachmentBinary { get; set; }
        public bool IsInline { get; set; }
        public int MailTemplateId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual MailTemplate MailTemplate { get; set; }
    }
}
