using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class BulkPaymentUser
    {
        public Guid? UserId { get; set; }
        public string CollectiveContractAccountNo { get; set; }

        public virtual TrnUser User { get; set; }
    }
}
