using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class ApplicationStatusTracker03022021Bk
    {
        public Guid Id { get; set; }
        public string PreStatusDescription { get; set; }
        public string PostStatusDescription { get; set; }
        public string StatusMessage { get; set; }
        public int? StatusId { get; set; }
        public string StatusCode { get; set; }
        public string StatusProfile { get; set; }
        public string UserAction { get; set; }
        public int? ApplicationModuleId { get; set; }
        public bool IsSmartMeter { get; set; }
        public bool IsOpc { get; set; }
        public bool IsLpc { get; set; }
        public bool IsLpcnem { get; set; }
        public bool IsExpress { get; set; }
        public bool IsGe { get; set; }
        public bool IsMeterChanged { get; set; }
        public bool IsRequireScheduler { get; set; }
        public string Source { get; set; }
        public int Sequence { get; set; }
        public int? RoleId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
