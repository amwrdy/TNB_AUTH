using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigTrnUserStaging2
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Salt { get; set; }
        public string SourcePassword { get; set; }
        public string SourceEncryptPassword { get; set; }
        public int? SourceEncryptionProcessFlag { get; set; }
    }
}
