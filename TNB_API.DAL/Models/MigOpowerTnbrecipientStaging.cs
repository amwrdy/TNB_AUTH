using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigOpowerTnbrecipientStaging
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string LegacyCustomerNumber { get; set; }
        public string LegacyStationCode { get; set; }
    }
}
