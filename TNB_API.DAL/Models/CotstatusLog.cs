using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class CotstatusLog
    {
        public Guid Guid { get; set; }
        public int? Cotid { get; set; }
        public int? StatusId { get; set; }
        public short? SrStatus { get; set; }
        public short? SnStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CancelledReason { get; set; }

        public virtual ApplicationStatus Status { get; set; }
    }
}
