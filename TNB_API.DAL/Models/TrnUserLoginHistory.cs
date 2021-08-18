using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class TrnUserLoginHistory
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? LoginOn { get; set; }
        public string LoginFrom { get; set; }
    }
}
