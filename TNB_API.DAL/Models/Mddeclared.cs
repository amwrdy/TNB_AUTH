using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Mddeclared
    {
        public int Mdid { get; set; }
        public string VoltageLevel { get; set; }
        public string MeterType { get; set; }
        public decimal? Mdmin { get; set; }
        public decimal? Mdmax { get; set; }
        public string MaterialDesc { get; set; }
    }
}
