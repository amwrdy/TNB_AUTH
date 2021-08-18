﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class PaymentBlockedCa
    {
        public Guid Guid { get; set; }
        public string ContractAccountNo { get; set; }
        public bool? IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
