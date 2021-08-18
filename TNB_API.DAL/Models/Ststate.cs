using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Ststate
    {
        public int StstateId { get; set; }
        public int? StateCode { get; set; }
        public string Description { get; set; }
        public string CountryCode { get; set; }
    }
}
