using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class TrnAccountActivityLog
    {
        public Guid ActivityLogId { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreateBy { get; set; }
        public string Action { get; set; }
        public bool? IsHaveAccess { get; set; }
        public bool? IsApplyEbilling { get; set; }
        public string AccountNo { get; set; }
        public string UserEmail { get; set; }
    }
}
