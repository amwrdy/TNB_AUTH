using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class RetechStudyApplicationAttachmentNew
    {
        public Guid FileId { get; set; }
        public int RetechStudyApplicationId { get; set; }
        public string FileCode { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ApplicationFileUpload File { get; set; }
        public virtual RetechStudyApplicationNew RetechStudyApplication { get; set; }
    }
}
