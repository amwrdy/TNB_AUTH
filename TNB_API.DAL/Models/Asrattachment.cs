using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Asrattachment
    {
        public Guid FileId { get; set; }
        public int AddressSearchRequestId { get; set; }
        public string FileGroupId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual AddressSearchRequest AddressSearchRequest { get; set; }
        public virtual ApplicationFileUpload File { get; set; }
    }
}
