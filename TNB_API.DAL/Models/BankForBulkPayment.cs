using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class BankForBulkPayment
    {
        public BankForBulkPayment()
        {
            BulkPayments = new HashSet<BulkPayment>();
        }

        public string BankId { get; set; }
        public string BankCode { get; set; }
        public string BankDescription { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<BulkPayment> BulkPayments { get; set; }
    }
}
