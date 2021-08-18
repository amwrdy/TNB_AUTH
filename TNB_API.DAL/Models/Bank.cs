using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Bank
    {
        public int BankId { get; set; }
        public string BankCode { get; set; }
        public string BankDescription { get; set; }
        public string BankAccountNoLength { get; set; }
        public string BankCountry { get; set; }
        public string SwiftCode { get; set; }
        public bool? Giro { get; set; }
        public bool? Rentas { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
