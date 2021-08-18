using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class ApplicationFileUpload
    {
        public ApplicationFileUpload()
        {
            Asrattachments = new HashSet<Asrattachment>();
            AsrcallLogAttachments = new HashSet<AsrcallLogAttachment>();
            Coaattachments = new HashSet<Coaattachment>();
            Cotattachments = new HashSet<Cotattachment>();
            MerdekaIncentiveAttachments = new HashSet<MerdekaIncentiveAttachment>();
            NewConnectionAttachments = new HashSet<NewConnectionAttachment>();
            RecontractManagementAttachments = new HashSet<RecontractManagementAttachment>();
            RetechStudyApplicationAttachmentNews = new HashSet<RetechStudyApplicationAttachmentNew>();
            RetechStudyApplicationAttachments = new HashSet<RetechStudyApplicationAttachment>();
            RewiringAttachments = new HashSet<RewiringAttachment>();
        }

        public Guid FileId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public byte[] FileBinary { get; set; }
        public string FileServerPath { get; set; }
        public bool? FileIsReadOnly { get; set; }
        public string UploadStatus { get; set; }
        public byte? NoOfTry { get; set; }
        public DateTime? NextTryDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string FileGroupId { get; set; }
        public bool? Deleted { get; set; }

        public virtual ProjectAttachment ProjectAttachment { get; set; }
        public virtual ICollection<Asrattachment> Asrattachments { get; set; }
        public virtual ICollection<AsrcallLogAttachment> AsrcallLogAttachments { get; set; }
        public virtual ICollection<Coaattachment> Coaattachments { get; set; }
        public virtual ICollection<Cotattachment> Cotattachments { get; set; }
        public virtual ICollection<MerdekaIncentiveAttachment> MerdekaIncentiveAttachments { get; set; }
        public virtual ICollection<NewConnectionAttachment> NewConnectionAttachments { get; set; }
        public virtual ICollection<RecontractManagementAttachment> RecontractManagementAttachments { get; set; }
        public virtual ICollection<RetechStudyApplicationAttachmentNew> RetechStudyApplicationAttachmentNews { get; set; }
        public virtual ICollection<RetechStudyApplicationAttachment> RetechStudyApplicationAttachments { get; set; }
        public virtual ICollection<RewiringAttachment> RewiringAttachments { get; set; }
    }
}
