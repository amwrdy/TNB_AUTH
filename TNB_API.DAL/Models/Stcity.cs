using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Stcity
    {
        public int StcityId { get; set; }
        public int? CityCode { get; set; }
        public string ShortFormCode { get; set; }
        public string Description { get; set; }
        public int? StateCode { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
