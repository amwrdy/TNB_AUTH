using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class DocAttachment
    {
        public Guid FileId { get; set; }
        public int DocumentId { get; set; }
        public string FileType { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModfiiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
