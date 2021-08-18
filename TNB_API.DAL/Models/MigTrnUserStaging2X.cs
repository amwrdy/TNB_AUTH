using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigTrnUserStaging2X
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string RegistrationSource { get; set; }
        public string AccountNumber { get; set; }
        public string IsOwnedAccount { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Roc { get; set; }
    }
}
