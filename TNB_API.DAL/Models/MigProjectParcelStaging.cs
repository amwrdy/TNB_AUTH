using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigProjectParcelStaging
    {
        public int Id { get; set; }
        public int? ParcelActualId { get; set; }
        public int? ParcelId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProjectStageId { get; set; }
        public string TnbProjectId { get; set; }
        public string Description { get; set; }
        public int? PremiseTypeHeaderId { get; set; }
        public string PremiseTypeItemCode { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public int? Mdid { get; set; }
        public string MeterType { get; set; }
        public string VoltageLevel { get; set; }
        public int? MeterDeclared { get; set; }
        public string ServiceType { get; set; }
        public int? MaxMoveIn { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public int? SourceId { get; set; }
        public int? LoadLineage { get; set; }
        public DateTime? LoadDate { get; set; }
    }
}
