using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigProjectStaging
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public string ReferenceNo { get; set; }
        public string TnbProjectId { get; set; }
        public int? ApplicationModuleId { get; set; }
        public Guid? UserId { get; set; }
        public string ProjectName { get; set; }
        public string SrNo { get; set; }
        public string SnNo { get; set; }
        public string LoadType { get; set; }
        public string PremiseCategory { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public int? IdentificationTypeId { get; set; }
        public string IdentificationNo { get; set; }
        public string FixedLineNo { get; set; }
        public long? EContractorId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string DeclaredMd { get; set; }
        public string VoltageLevel { get; set; }
        public string StationCode { get; set; }
        public string StationCodeErms { get; set; }
        public string PremiseState { get; set; }
        public string PremisePostalCode { get; set; }
        public string PremiseTown { get; set; }
        public string PremiseCity { get; set; }
        public string PremiseStreet { get; set; }
        public string PremiseBuilding { get; set; }
        public string PremiseUnitNo { get; set; }
        public string PremiseType { get; set; }
        public string PremiseSubStation { get; set; }
        public string Bpbuilding { get; set; }
        public string BpunitNo { get; set; }
        public string Bpstreet { get; set; }
        public string BppostalCode { get; set; }
        public string Bptown { get; set; }
        public string Bpcity { get; set; }
        public string Bpstate { get; set; }
        public string Bpcountry { get; set; }
        public string BppropertyType { get; set; }
        public string BpfaxNo { get; set; }
        public int? ParcelQty { get; set; }
        public int? MaxMoveIn { get; set; }
        public decimal? Cctotal { get; set; }
        public string ProformaInvNo { get; set; }
        public bool? IsAcknowledge { get; set; }
        public bool? IsTnc { get; set; }
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
