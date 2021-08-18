using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class ExpressPaymentLog
    {
        public int RecordId { get; set; }
        public string ReferenceNo { get; set; }
        public string TransactionStatus { get; set; }
        public string ContractAccountNo { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public bool IsEmailMatch { get; set; }
        public bool IsMobileNoMatch { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Ipaddress { get; set; }
        public string Browser { get; set; }
    }
}
