using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Otp
    {
        public Guid OtpId { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public short? SourceId { get; set; }
        public short? Trial { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ExpireDateTime { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string Email { get; set; }
    }
}
