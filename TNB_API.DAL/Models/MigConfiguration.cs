using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigConfiguration
    {
        public int Id { get; set; }
        public string Area { get; set; }
        public string SubArea { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string ValidCompareOperator { get; set; }
        public string Remarks { get; set; }
        public int? Sequence { get; set; }
    }
}
