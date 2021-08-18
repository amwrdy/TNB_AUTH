using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigEservicesUser
    {
        public string CustomerLoginId { get; set; }
        public string Email { get; set; }
        public string OldCano { get; set; }
        public string NewCano { get; set; }
        public string UserId { get; set; }
        public string AccountId { get; set; }
        public string AccountTypeId { get; set; }
        public string GotIndividualRole { get; set; }
        public string BatchNo { get; set; }
    }
}
