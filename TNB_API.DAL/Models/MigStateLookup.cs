using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigStateLookup
    {
        public short? StateId { get; set; }
        public string State { get; set; }
        public short? Tnbactive { get; set; }
        public short? KodNegeriSt { get; set; }
        public short? Crmstate { get; set; }
    }
}
