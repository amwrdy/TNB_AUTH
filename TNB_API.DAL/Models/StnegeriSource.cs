using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class StnegeriSource
    {
        public int StnegeriId { get; set; }
        public int? KodNegeri { get; set; }
        public string Keterangan { get; set; }
        public string KodNegara { get; set; }
    }
}
