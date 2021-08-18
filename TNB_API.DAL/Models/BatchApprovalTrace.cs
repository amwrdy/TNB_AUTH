using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class BatchApprovalTrace
    {
        public Guid BatchApprovalTraceId { get; set; }
        public int? NewConnectionId { get; set; }
        public int? Cotid { get; set; }
        public int? RewiringId { get; set; }
        public int? ProjectId { get; set; }
        public int? Coaid { get; set; }
        public int? Reid { get; set; }
        public DateTime? NextTryDate { get; set; }
        public int? SentCount { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
