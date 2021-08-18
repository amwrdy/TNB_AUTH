using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class CareLineDashboardStatusLog
    {
        public int? RecordId { get; set; }
        public int? ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleType { get; set; }
        public int? StatusId { get; set; }
        public int? StatusOrder { get; set; }
        public string CarelineStatus { get; set; }
        public int? AgingId { get; set; }
        public string AgingDescription { get; set; }
        public int? AgingCount { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
