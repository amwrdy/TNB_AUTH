using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class StbandarSource
    {
        public int StbandarId { get; set; }
        public int? KodBandar { get; set; }
        public string KodSingkatan { get; set; }
        public string Keterangan { get; set; }
        public int? KodNegeri { get; set; }
    }
}
