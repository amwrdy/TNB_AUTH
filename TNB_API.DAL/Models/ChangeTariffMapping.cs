using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class ChangeTariffMapping
    {
        public int TariffId { get; set; }
        public bool IsTiomanStation { get; set; }
        public string VoltageLevel { get; set; }
        public int PremiseHeaderId { get; set; }
        public bool IsDiscounted { get; set; }
        public bool Is24OperatingHours { get; set; }
        public string SchemeType { get; set; }
        public string TariffSystemDescription { get; set; }
        public string TariffDescription { get; set; }
        public string TariffCode { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsTimeOfUseEligible { get; set; }
    }
}
