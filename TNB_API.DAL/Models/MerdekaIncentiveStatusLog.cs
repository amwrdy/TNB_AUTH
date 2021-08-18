using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MerdekaIncentiveStatusLog
    {
        public Guid Guid { get; set; }
        public int? MerdekaIncentiveId { get; set; }
        public int? StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
