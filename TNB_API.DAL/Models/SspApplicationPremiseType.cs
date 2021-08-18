using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class SspApplicationPremiseType
    {
        public int PremiseTypeHeaderId { get; set; }
        public string PremiseTypeItemCode { get; set; }
        public string PremiseType { get; set; }
        public string PremiseActivity { get; set; }
    }
}
