using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigAccountNoMappingException
    {
        public int? Id { get; set; }
        public string OldAcnumber { get; set; }
        public string NewAcnumber { get; set; }
        public string AccountType { get; set; }
        public int? LoadLineage { get; set; }
        public DateTime? LoadDate { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionMsg { get; set; }
    }
}
