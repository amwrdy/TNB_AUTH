using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class AsrstatusLog
    {
        public Guid Guid { get; set; }
        public int AddressSearchRequestId { get; set; }
        public int? StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual ApplicationStatus Status { get; set; }
    }
}
