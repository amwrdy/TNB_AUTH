using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class RetechStudyApplicationNew
    {
        public RetechStudyApplicationNew()
        {
            RetechStudyApplicationAttachmentNews = new HashSet<RetechStudyApplicationAttachmentNew>();
        }

        public int RetechStudyApplicationId { get; set; }
        public string ReferenceNo { get; set; }
        public Guid RetechStudyGuid { get; set; }
        public Guid UserId { get; set; }
        public string ServiceNotificationNo { get; set; }
        public bool? IsOwnApplication { get; set; }
        public bool? IsApplyingOnBehalf { get; set; }
        public int AccountTypeId { get; set; }
        public int? SalutationId { get; set; }
        public string SalutationCode { get; set; }
        public int? GivenTitleId { get; set; }
        public string GivenTitleCode { get; set; }
        public int? IdentificationTypeId { get; set; }
        public string IdentificationNo { get; set; }
        public string Rocno { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string MothersName { get; set; }
        public DateTime? Dob { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string HomePhoneNo { get; set; }
        public string FaxNo { get; set; }
        public int? Category { get; set; }
        public int? SubCategory { get; set; }
        public string GenerationCapacityCode { get; set; }
        public string NetExport { get; set; }
        public string BusinessArea { get; set; }
        public bool? PremiseNew { get; set; }
        public string PremiseNo { get; set; }
        public string PremiseState { get; set; }
        public string PremisePostalCode { get; set; }
        public string PremiseArea { get; set; }
        public string PremiseCity { get; set; }
        public string PremiseStreet { get; set; }
        public string PremiseBuilding { get; set; }
        public string PremiseUnitNo { get; set; }
        public string PremiseHouseNo { get; set; }
        public string PremiseType { get; set; }
        public string MailAddrTag { get; set; }
        public string MailState { get; set; }
        public string MailPostalCode { get; set; }
        public string MailArea { get; set; }
        public string MailCity { get; set; }
        public string MailStreet { get; set; }
        public string MailBuilding { get; set; }
        public string MailUnitNo { get; set; }
        public string MailHouseNo { get; set; }
        public string MailType { get; set; }
        public string Spname { get; set; }
        public string Sprocno { get; set; }
        public string SpmobileNo { get; set; }
        public string SpofficePhoneNo { get; set; }
        public string Spemail { get; set; }
        public string Spstate { get; set; }
        public string SppostalCode { get; set; }
        public string Sparea { get; set; }
        public string Spcity { get; set; }
        public string Spstreet { get; set; }
        public string Spbuilding { get; set; }
        public string SpunitNo { get; set; }
        public string SphouseNo { get; set; }
        public string Sptype { get; set; }
        public string AuthName { get; set; }
        public string AuthName2 { get; set; }
        public string AuthPosition { get; set; }
        public string AuthMobileNo { get; set; }
        public string AuthOfficePhoneNo { get; set; }
        public string AuthFaxNo { get; set; }
        public string AuthEmail { get; set; }
        public string Nokname { get; set; }
        public string Nokname2 { get; set; }
        public string NokmobileNo { get; set; }
        public string NokofficePhoneNo { get; set; }
        public string NokhomePhoneNo { get; set; }
        public string Nokemail { get; set; }
        public string PaymentRefStatus { get; set; }
        public bool? Draft { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string PremiseStreetCode { get; set; }
        public int ApplyForId { get; set; }
        public string ApplicationType { get; set; }
        public string Gpscoordinates { get; set; }
        public string SignalStrength { get; set; }
        public string SpfaxNo { get; set; }
        public string Position { get; set; }
        public string PersonInCharge { get; set; }
        public string ExistingFiah { get; set; }
        public string ExistingFiahcapacity { get; set; }
        public string NeminstalledCapacity { get; set; }
        public string TnbsubstationName { get; set; }
        public string MaximumDemand { get; set; }
        public string FuseRatingLowVoltage { get; set; }
        public string CtratingLowVoltage { get; set; }
        public string EstimatedMonthlyGeneration { get; set; }
        public string BatteryEnergyStorageSystem { get; set; }
        public string BatteryCapacity { get; set; }
        public string DaytimePeak { get; set; }
        public string DaytimeLowest { get; set; }
        public string ExportDaytimePeak { get; set; }
        public string ExportDaytimeLowest { get; set; }
        public string ConnectionPointName { get; set; }
        public string TypeOfStudy { get; set; }
        public string GeneratorType { get; set; }
        public string GeneratorTypeOther { get; set; }
        public string Rating { get; set; }
        public string RatedTerminalVoltage { get; set; }
        public string Frequency { get; set; }
        public string MinPflagging { get; set; }
        public string MinPfleading { get; set; }
        public string TypeOfControl { get; set; }
        public string GeneratorSubTransientReactance { get; set; }
        public string GeneratorTransientReactance { get; set; }
        public string PvmoduleType { get; set; }
        public string NumberOfInverterInstalled { get; set; }
        public string InverterType { get; set; }
        public string InverterManufacturer { get; set; }
        public string InverterPowerFactor { get; set; }
        public string InverterPowerFactorLagging { get; set; }
        public string InverterPowerFactorLeading { get; set; }
        public string RatedCapacity { get; set; }
        public string VoltageRatio { get; set; }
        public string TapRangeMin { get; set; }
        public string TapRangeMax { get; set; }
        public string VectorGroup { get; set; }
        public string TapStep { get; set; }
        public string Impedance { get; set; }
        public string MethodOfEarthing { get; set; }
        public string Resistance { get; set; }
        public string ContractAccountNo { get; set; }
        public string RatingPf { get; set; }
        public string ExpectedAnnualEnergyGeneration { get; set; }
        public string OtherSubCategory { get; set; }

        public virtual TrnUser User { get; set; }
        public virtual ICollection<RetechStudyApplicationAttachmentNew> RetechStudyApplicationAttachmentNews { get; set; }
    }
}
