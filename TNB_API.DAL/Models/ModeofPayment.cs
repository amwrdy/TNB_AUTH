using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class ModeofPayment
    {
        public int ModeofPaymentId { get; set; }
        public string ModeofPaymentCode { get; set; }
        public string ModeofPaymentDescription { get; set; }
        public bool IsActive { get; set; }
    }
}
