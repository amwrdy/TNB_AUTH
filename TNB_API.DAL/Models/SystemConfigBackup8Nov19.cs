using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class SystemConfigBackup8Nov19
    {
        public Guid SystemConfigId { get; set; }
        public string Area { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public byte[] FileValue { get; set; }
        public string Description { get; set; }
        public bool IsMaintainable { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
