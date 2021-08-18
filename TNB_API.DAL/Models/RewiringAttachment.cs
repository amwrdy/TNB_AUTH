using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class RewiringAttachment
    {
        public Guid FileId { get; set; }
        public int RewiringId { get; set; }
        public string FileCode { get; set; }
        public string UploadedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ApplicationFileUpload File { get; set; }
        public virtual Rewiring Rewiring { get; set; }
    }
}
