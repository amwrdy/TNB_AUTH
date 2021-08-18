using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Masterlookup20201229
    {
        public int LookupId { get; set; }
        public string Area { get; set; }
        public string Lookup { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public int? Sequence { get; set; }
    }
}
