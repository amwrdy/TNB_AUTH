using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigStationLookup
    {
        public short? StationId { get; set; }
        public short? StationCode { get; set; }
        public int? BizAreaSspstationCode { get; set; }
        public string StationName { get; set; }
        public short? StateId { get; set; }
        public short? Active { get; set; }
    }
}
