using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MailTemplate
    {
        public MailTemplate()
        {
            MailTemplateAttachments = new HashSet<MailTemplateAttachment>();
        }

        public int MailTemplateId { get; set; }
        public string TemplateSubject { get; set; }
        public string TemplateBody { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<MailTemplateAttachment> MailTemplateAttachments { get; set; }
    }
}
