using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class FeedbackUpdatePersonalDetail
    {
        public Guid UpdatePersonalDetailsId { get; set; }
        public int FeedbackId { get; set; }
        public bool? IsOwner { get; set; }
        public string NewNric { get; set; }
        public string AccOwnerName { get; set; }
        public string NewMobileNo { get; set; }
        public string NewEmailAddress { get; set; }
        public string MailAddressStreetAddress { get; set; }
        public string MailAddressPostcode { get; set; }
        public string MailAddressCity { get; set; }
        public string MailAddressState { get; set; }
        public string PremiseAddressStreetAddress { get; set; }
        public string PremiseAddressPostcode { get; set; }
        public string PremiseAddressCity { get; set; }
        public string PremiseAddressState { get; set; }
        public string Relationship { get; set; }

        public virtual Feedback Feedback { get; set; }
    }
}
