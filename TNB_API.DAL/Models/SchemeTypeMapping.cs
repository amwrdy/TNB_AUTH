using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class SchemeTypeMapping
    {
        public int TariffSchemeId { get; set; }
        public string SchemeType { get; set; }
        public int? PremiseHeaderId { get; set; }
        public string SchemeShortDescription { get; set; }
        public string SchemeLongDescription { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
