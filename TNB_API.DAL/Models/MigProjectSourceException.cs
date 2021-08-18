using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigProjectSourceException
    {
        public int? Id { get; set; }
        public string ProjectCreator { get; set; }
        public string DeveloperName { get; set; }
        public string TnbprojectId { get; set; }
        public string GroupNcno { get; set; }
        public string FlState { get; set; }
        public string FlPostcode { get; set; }
        public string FlTownArea { get; set; }
        public string TotalNumberofUnits { get; set; }
        public string ParcelDescription { get; set; }
        public string PremiseDescription { get; set; }
        public string NumberofUnits { get; set; }
        public string TotalParcelNotSubmitted { get; set; }
        public string StationCode { get; set; }
        public string ParcelId { get; set; }
        public string TotalNumberofUnitEcibs { get; set; }
        public string TotalUnitSubmittedEcibs { get; set; }
        public int? LoadLineage { get; set; }
        public DateTime? LoadDate { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionMsg { get; set; }
    }
}
