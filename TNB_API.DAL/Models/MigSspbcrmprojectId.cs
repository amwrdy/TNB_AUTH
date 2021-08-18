using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigSspbcrmprojectId
    {
        public int Id { get; set; }
        public string SspTnbprojectId { get; set; }
        public string BcrmTnbprojectId { get; set; }
        public string MigrationStatus { get; set; }
        public int? LoadLineage { get; set; }
        public DateTime? LoadDate { get; set; }
    }
}
