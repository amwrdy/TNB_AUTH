using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class BcrmDocNoPatching
    {
        public string PaymentId { get; set; }
        public string CaNo { get; set; }
        public string BcrmDocNo { get; set; }
        public double? Amount { get; set; }
        public string RevenueCode { get; set; }
        public string PaymentNo { get; set; }
        public string ReferenceNo { get; set; }
    }
}
