using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class NewConnectionChangeLog
    {
        public Guid NclogId { get; set; }
        public int NewConnectionId { get; set; }
        public int ChangeType { get; set; }
        public string ChangeLog { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
