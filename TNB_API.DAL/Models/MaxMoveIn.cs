using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MaxMoveIn
    {
        public string TnbProjectId { get; set; }
        public double? Ssp { get; set; }
        public double? Erms { get; set; }
        public double? Variance { get; set; }
    }
}
