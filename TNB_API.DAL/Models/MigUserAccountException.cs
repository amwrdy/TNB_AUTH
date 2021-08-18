using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigUserAccountException
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string RegistrationSource { get; set; }
        public string AccountNumber { get; set; }
        public string IsOwnedAccount { get; set; }
        public string Role { get; set; }
        public string Roc { get; set; }
        public string Password { get; set; }
        public string Canumber { get; set; }
        public string AccountType { get; set; }
        public int? LoadLineage { get; set; }
        public DateTime? LoadDate { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionMsg { get; set; }
    }
}
