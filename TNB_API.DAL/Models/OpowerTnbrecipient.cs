using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class OpowerTnbrecipient
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string LegacyCustomerNumber { get; set; }
        public string LegacyStationCode { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
