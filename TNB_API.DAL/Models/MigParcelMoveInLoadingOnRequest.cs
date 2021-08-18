using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigParcelMoveInLoadingOnRequest
    {
        public int Id { get; set; }
        public string ProjectCreator { get; set; }
        public string UserRole { get; set; }
        public string TnbprojectId { get; set; }
        public string ProjectName { get; set; }
        public string GroupNcno { get; set; }
        public string ParcelId { get; set; }
        public string StationCode { get; set; }
        public string AccountType { get; set; }
        public string Salutation { get; set; }
        public string NameOfAppplicant { get; set; }
        public string IdentificationNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PlState { get; set; }
        public string PlPostcode { get; set; }
        public string PlTownArea { get; set; }
        public string PlStreet { get; set; }
        public string PlPremiseType { get; set; }
        public string PlHouseNo { get; set; }
        public string MaState { get; set; }
        public string MaPostcode { get; set; }
        public string MaTownArea { get; set; }
        public string MaStreet { get; set; }
        public string MaHouseNo { get; set; }
        public string NextofKinContactName { get; set; }
        public string NextofKinContactNumber { get; set; }
        public string NextofKinContactEmailAddress { get; set; }
        public string AuthorisedPersonnelName { get; set; }
        public string AuthorisedPersonnelNumber { get; set; }
        public string AdditionalInfo { get; set; }
        public string MigrationStatus { get; set; }
        public int? LoadLineage { get; set; }
        public DateTime? LoadDate { get; set; }
    }
}
