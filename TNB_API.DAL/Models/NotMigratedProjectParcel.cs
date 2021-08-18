using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class NotMigratedProjectParcel
    {
        public string ProjectCreatorEmail { get; set; }
        public string DeveloperName { get; set; }
        public double? TnbProjectId { get; set; }
        public double? GroupNcNo { get; set; }
        public string FlState { get; set; }
        public double? FlPostcode { get; set; }
        public string FlTownArea { get; set; }
        public double? TotalNumberOfUnitsProject { get; set; }
        public string ParcelDescription { get; set; }
        public string PremiseDescription { get; set; }
        public double? TotalNumberOfUnitsParcel { get; set; }
        public double? TotalNumberOfUnitsNotSubmittedParcel { get; set; }
        public double? StationCode { get; set; }
        public string ParcelId { get; set; }
        public string TotalNumberOfUnitEcibs { get; set; }
        public string TotalUnitSubmittedEcibs { get; set; }
        public string BalanceInECibs { get; set; }
        public string MaterialDescription { get; set; }
        public string VoltageLevelForMvLoadOnly { get; set; }
        public string MeterTypeForMvLoadOnly { get; set; }
        public string MaximumDemandForMvLoadOnly { get; set; }
    }
}
