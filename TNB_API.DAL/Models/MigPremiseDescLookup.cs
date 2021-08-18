using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigPremiseDescLookup
    {
        public short? ProjectCategoryId { get; set; }
        public string Decsription { get; set; }
        public string Code { get; set; }
        public short? Active { get; set; }
    }
}
