using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class ProjectParcel
    {
        public int ParcelId { get; set; }
        public int? ProjectId { get; set; }
        public string Description { get; set; }
        public int? PremiseTypeHeaderId { get; set; }
        public string PremiseTypeItemCode { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public int? Mdid { get; set; }
        public string MeterType { get; set; }
        public string VoltageLevel { get; set; }
        public decimal? MeterDeclared { get; set; }
        public string ServiceType { get; set; }
        public int? MaxMoveIn { get; set; }
        public string Sotype { get; set; }
        public string Sonumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string Source { get; set; }
        public string StreetlightSubCategoryCode { get; set; }
        public string IndicatorFlag { get; set; }
    }
}
