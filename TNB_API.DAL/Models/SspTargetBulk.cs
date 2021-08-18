using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class SspTargetBulk
    {
        public double? OldKey { get; set; }
        public string NewKey { get; set; }
        public string BpName { get; set; }
        public string SmtpAddr { get; set; }
    }
}
