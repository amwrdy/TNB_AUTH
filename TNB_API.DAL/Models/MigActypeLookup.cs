using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigActypeLookup
    {
        public short? EserviceCode { get; set; }
        public string EServiceDescription { get; set; }
        public int? SspaccountTypeId { get; set; }
        public string SspaccountType { get; set; }
        public string Remark { get; set; }
    }
}
