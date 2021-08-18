using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class PurposeOfPremise
    {
        public int PurposeId { get; set; }
        public int? PremiseTypeHeaderId { get; set; }
        public string PurposeDescription { get; set; }
        public bool IsDiscount { get; set; }
    }
}
