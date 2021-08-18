using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class NewConnectionTechnical
    {
        public int NewConnectionId { get; set; }
        public int? StationState { get; set; }
        public int? TnbstationCode { get; set; }
        public int? MeterLocation { get; set; }
        public string VoltageLevel { get; set; }
        public int? Amps { get; set; }
        public int? SupplyType { get; set; }
        public int? NoOfPoles { get; set; }
        public string ApplicationType { get; set; }
        public int? Distance { get; set; }
        public string MeterType { get; set; }
        public string PowerConsumption { get; set; }
        public int? NewTotalConnected { get; set; }
        public decimal? NewMaxDemand { get; set; }
        public int? ExistTotalConnected { get; set; }
        public decimal? ExistMaxDemand { get; set; }
        public int? AdditionalTotalConnected { get; set; }
        public decimal? AdditionalMaxDemand { get; set; }
        public int? TotalLoadTotalConnected { get; set; }
        public decimal? TotalLoadMaxDemand { get; set; }
        public int? WeldTotalConnected { get; set; }
        public decimal? WeldMaxDemand { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public int? InstallationType { get; set; }
        public string NoOfFeeder { get; set; }
        public string CtRatio { get; set; }
        public string CodeGroup { get; set; }
        public string Source { get; set; }
        public DateTime? TempSupplyDate { get; set; }
        public bool IsApplyForWeldSetLoad { get; set; }

        public virtual NewConnection NewConnection { get; set; }
    }
}
