using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class TrnUserMobileHistory
    {
        public Guid TrnUserMobileHistoryId { get; set; }
        public Guid? UserId { get; set; }
        public string MobileNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
