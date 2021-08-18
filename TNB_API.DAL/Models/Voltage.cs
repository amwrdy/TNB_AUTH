using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Voltage
    {
        public string VoltageLevel { get; set; }
        public string VoltageType { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public int VoltageId { get; set; }
        public string VoltageNumberBcrm { get; set; }
        public string VoltageClass { get; set; }
    }
}
