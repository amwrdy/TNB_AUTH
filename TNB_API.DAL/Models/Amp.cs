using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Amp
    {
        public int Ampsid { get; set; }
        public int? VoltageId { get; set; }
        public int? VoltageLevels { get; set; }
    }
}
