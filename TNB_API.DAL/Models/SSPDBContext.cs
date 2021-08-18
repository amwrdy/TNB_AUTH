using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class SSPDBContext : DbContext
    {
        public SSPDBContext()
        {
        }

        public SSPDBContext(DbContextOptions<SSPDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<AcstoAcpbackUpDeleted> AcstoAcpbackUpDeleteds { get; set; }
        public virtual DbSet<AddressSearchRequest> AddressSearchRequests { get; set; }
        public virtual DbSet<AddressSearchRequestLog> AddressSearchRequestLogs { get; set; }
        public virtual DbSet<Amp> Amps { get; set; }
        public virtual DbSet<AnnouncementBak11172020> AnnouncementBak11172020s { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<AnswerSet> AnswerSets { get; set; }
        public virtual DbSet<AnswerType> AnswerTypes { get; set; }
        public virtual DbSet<ApplicationFileUpload> ApplicationFileUploads { get; set; }
        public virtual DbSet<ApplicationFileUploadQueue> ApplicationFileUploadQueues { get; set; }
        public virtual DbSet<ApplicationStatus> ApplicationStatuses { get; set; }
        public virtual DbSet<ApplicationStatusSync> ApplicationStatusSyncs { get; set; }
        public virtual DbSet<ApplicationStatusTracker> ApplicationStatusTrackers { get; set; }
        public virtual DbSet<ApplicationStatusTracker03022021Bk> ApplicationStatusTracker03022021Bks { get; set; }
        public virtual DbSet<ApplicationStatusTracker29012021Bk> ApplicationStatusTracker29012021Bks { get; set; }
        public virtual DbSet<ApplicationStatusTracker30012021Bk> ApplicationStatusTracker30012021Bks { get; set; }
        public virtual DbSet<Asrattachment> Asrattachments { get; set; }
        public virtual DbSet<AsrcallLogAttachment> AsrcallLogAttachments { get; set; }
        public virtual DbSet<AsrcancelInformation> AsrcancelInformations { get; set; }
        public virtual DbSet<AsrfavApplication> AsrfavApplications { get; set; }
        public virtual DbSet<AsrlogAction> AsrlogActions { get; set; }
        public virtual DbSet<AsrstatusLog> AsrstatusLogs { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BankForBulkPayment> BankForBulkPayments { get; set; }
        public virtual DbSet<BatchApprovalQueue> BatchApprovalQueues { get; set; }
        public virtual DbSet<BatchApprovalTrace> BatchApprovalTraces { get; set; }
        public virtual DbSet<BcrmDocNoPatching> BcrmDocNoPatchings { get; set; }
        public virtual DbSet<BillNotificationDummyDataDeleted> BillNotificationDummyDataDeleteds { get; set; }
        public virtual DbSet<BillNotificationInboundQueue> BillNotificationInboundQueues { get; set; }
        public virtual DbSet<BillNotificationInboundTrace> BillNotificationInboundTraces { get; set; }
        public virtual DbSet<BillNotificationOutboundQueue> BillNotificationOutboundQueues { get; set; }
        public virtual DbSet<BillNotificationOutboundTrace> BillNotificationOutboundTraces { get; set; }
        public virtual DbSet<BulkDataPool> BulkDataPools { get; set; }
        public virtual DbSet<BulkPayLotFileDownloadLog> BulkPayLotFileDownloadLogs { get; set; }
        public virtual DbSet<BulkPayLotFileUploadLog> BulkPayLotFileUploadLogs { get; set; }
        public virtual DbSet<BulkPayment> BulkPayments { get; set; }
        public virtual DbSet<BulkPaymentAccountList> BulkPaymentAccountLists { get; set; }
        public virtual DbSet<BulkPaymentAccountListQueue> BulkPaymentAccountListQueues { get; set; }
        public virtual DbSet<BulkPaymentCollectiveAccount> BulkPaymentCollectiveAccounts { get; set; }
        public virtual DbSet<BulkPaymentCollectiveAccountQueue> BulkPaymentCollectiveAccountQueues { get; set; }
        public virtual DbSet<BulkPaymentLog> BulkPaymentLogs { get; set; }
        public virtual DbSet<BulkPaymentLogQueue> BulkPaymentLogQueues { get; set; }
        public virtual DbSet<BulkPaymentQueue> BulkPaymentQueues { get; set; }
        public virtual DbSet<BulkPaymentRejectPaymentList> BulkPaymentRejectPaymentLists { get; set; }
        public virtual DbSet<BulkPaymentTrace> BulkPaymentTraces { get; set; }
        public virtual DbSet<BulkPaymentUser> BulkPaymentUsers { get; set; }
        public virtual DbSet<BulkPrintingFile> BulkPrintingFiles { get; set; }
        public virtual DbSet<BulkPrintingTrace> BulkPrintingTraces { get; set; }
        public virtual DbSet<CallLog> CallLogs { get; set; }
        public virtual DbSet<CareLineDashboardStatus> CareLineDashboardStatuses { get; set; }
        public virtual DbSet<CareLineDashboardStatusLog> CareLineDashboardStatusLogs { get; set; }
        public virtual DbSet<ChangeLoadAcstoAcpbackUpDeleted> ChangeLoadAcstoAcpbackUpDeleteds { get; set; }
        public virtual DbSet<ChangeLoadFavApplication> ChangeLoadFavApplications { get; set; }
        public virtual DbSet<ChangeProductFavApplication> ChangeProductFavApplications { get; set; }
        public virtual DbSet<ChangeTariffMapping> ChangeTariffMappings { get; set; }
        public virtual DbSet<ChannelSecurity> ChannelSecurities { get; set; }
        public virtual DbSet<ChannelSecurityMemOptimized> ChannelSecurityMemOptimizeds { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Coaapplication> Coaapplications { get; set; }
        public virtual DbSet<CoaapplicationStatus> CoaapplicationStatuses { get; set; }
        public virtual DbSet<Coaattachment> Coaattachments { get; set; }
        public virtual DbSet<CoafavApplication> CoafavApplications { get; set; }
        public virtual DbSet<CoastatusLog> CoastatusLogs { get; set; }
        public virtual DbSet<Contractor> Contractors { get; set; }
        public virtual DbSet<ConvertedRoleUser> ConvertedRoleUsers { get; set; }
        public virtual DbSet<Cotapplication> Cotapplications { get; set; }
        public virtual DbSet<CotapplicationStatus> CotapplicationStatuses { get; set; }
        public virtual DbSet<Cotattachment> Cotattachments { get; set; }
        public virtual DbSet<CotcallLog> CotcallLogs { get; set; }
        public virtual DbSet<CotcancelInformation> CotcancelInformations { get; set; }
        public virtual DbSet<CotexistingOwnerLog> CotexistingOwnerLogs { get; set; }
        public virtual DbSet<CotfavApplication> CotfavApplications { get; set; }
        public virtual DbSet<CotstatusLog> CotstatusLogs { get; set; }
        public virtual DbSet<CotsubmitSystemMessage> CotsubmitSystemMessages { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Ctratio> Ctratios { get; set; }
        public virtual DbSet<Developer> Developers { get; set; }
        public virtual DbSet<DeviceLocation> DeviceLocations { get; set; }
        public virtual DbSet<DocAttachment> DocAttachments { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<ElectricitySupplyType> ElectricitySupplyTypes { get; set; }
        public virtual DbSet<ExpressPaymentLog> ExpressPaymentLogs { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<FeedbackAttachment> FeedbackAttachments { get; set; }
        public virtual DbSet<FeedbackItem> FeedbackItems { get; set; }
        public virtual DbSet<FeedbackStatusLog> FeedbackStatusLogs { get; set; }
        public virtual DbSet<FeedbackUpdatePersonalDetail> FeedbackUpdatePersonalDetails { get; set; }
        public virtual DbSet<FileDownload> FileDownloads { get; set; }
        public virtual DbSet<FileDownloadBackup17Dec2020> FileDownloadBackup17Dec2020s { get; set; }
        public virtual DbSet<FileDownloadBak08012021> FileDownloadBak08012021s { get; set; }
        public virtual DbSet<FileUploadGroup> FileUploadGroups { get; set; }
        public virtual DbSet<FileUploadGroupBackup8Nov19> FileUploadGroupBackup8Nov19s { get; set; }
        public virtual DbSet<GivenTitle> GivenTitles { get; set; }
        public virtual DbSet<GreenTariff> GreenTariffs { get; set; }
        public virtual DbSet<GreenTariffAttachment> GreenTariffAttachments { get; set; }
        public virtual DbSet<GreenTariffFavApplication> GreenTariffFavApplications { get; set; }
        public virtual DbSet<GreenTariffStatusLog> GreenTariffStatusLogs { get; set; }
        public virtual DbSet<GslfavApplication> GslfavApplications { get; set; }
        public virtual DbSet<HelpFormFavApplication> HelpFormFavApplications { get; set; }
        public virtual DbSet<HerTarget> HerTargets { get; set; }
        public virtual DbSet<IdentificationType> IdentificationTypes { get; set; }
        public virtual DbSet<InBoundWebServiceLog> InBoundWebServiceLogs { get; set; }
        public virtual DbSet<Individual> Individuals { get; set; }
        public virtual DbSet<LnkUserRole> LnkUserRoles { get; set; }
        public virtual DbSet<LnkUserRoleBackup8Nov19> LnkUserRoleBackup8Nov19s { get; set; }
        public virtual DbSet<LnkUserRoleBackupDeleted> LnkUserRoleBackupDeleteds { get; set; }
        public virtual DbSet<LnkUserRoleBackupForReadOnlyDeletion> LnkUserRoleBackupForReadOnlyDeletions { get; set; }
        public virtual DbSet<Lpc> Lpcs { get; set; }
        public virtual DbSet<MailQueue> MailQueues { get; set; }
        public virtual DbSet<MailQueueAttachment> MailQueueAttachments { get; set; }
        public virtual DbSet<MailTemplate> MailTemplates { get; set; }
        public virtual DbSet<MailTemplateAttachment> MailTemplateAttachments { get; set; }
        public virtual DbSet<MailTemplateBackup8Nov19> MailTemplateBackup8Nov19s { get; set; }
        public virtual DbSet<MailTemplateBk202101020010> MailTemplateBk202101020010s { get; set; }
        public virtual DbSet<MailTemplateBk202101141043> MailTemplateBk202101141043s { get; set; }
        public virtual DbSet<MailTemplateBk202104201607> MailTemplateBk202104201607s { get; set; }
        public virtual DbSet<MailTrace> MailTraces { get; set; }
        public virtual DbSet<MailTraceAttachment> MailTraceAttachments { get; set; }
        public virtual DbSet<MasterLookup> MasterLookups { get; set; }
        public virtual DbSet<Masterlookup20201228> Masterlookup20201228s { get; set; }
        public virtual DbSet<Masterlookup20201229> Masterlookup20201229s { get; set; }
        public virtual DbSet<MaxMoveIn> MaxMoveIns { get; set; }
        public virtual DbSet<Mddeclared> Mddeclareds { get; set; }
        public virtual DbSet<MerdekaIncentive> MerdekaIncentives { get; set; }
        public virtual DbSet<MerdekaIncentiveAttachment> MerdekaIncentiveAttachments { get; set; }
        public virtual DbSet<MerdekaIncentiveFavApplication> MerdekaIncentiveFavApplications { get; set; }
        public virtual DbSet<MerdekaIncentiveStatusLog> MerdekaIncentiveStatusLogs { get; set; }
        public virtual DbSet<MigAccountNoMapping> MigAccountNoMappings { get; set; }
        public virtual DbSet<MigAccountNoMappingCleansed> MigAccountNoMappingCleanseds { get; set; }
        public virtual DbSet<MigAccountNoMappingException> MigAccountNoMappingExceptions { get; set; }
        public virtual DbSet<MigActypeLookup> MigActypeLookups { get; set; }
        public virtual DbSet<MigBcrm> MigBcrms { get; set; }
        public virtual DbSet<MigConfiguration> MigConfigurations { get; set; }
        public virtual DbSet<MigContractorStaging> MigContractorStagings { get; set; }
        public virtual DbSet<MigDeveloperInvidualStaging> MigDeveloperInvidualStagings { get; set; }
        public virtual DbSet<MigDeveloperTrnUserStaging> MigDeveloperTrnUserStagings { get; set; }
        public virtual DbSet<MigEcib> MigEcibs { get; set; }
        public virtual DbSet<MigEservicesUser> MigEservicesUsers { get; set; }
        public virtual DbSet<MigInvidualStaging> MigInvidualStagings { get; set; }
        public virtual DbSet<MigNewConnectionStaging> MigNewConnectionStagings { get; set; }
        public virtual DbSet<MigOpowerTnbrecipientStaging> MigOpowerTnbrecipientStagings { get; set; }
        public virtual DbSet<MigParcelMoveInException> MigParcelMoveInExceptions { get; set; }
        public virtual DbSet<MigParcelMoveInLoading> MigParcelMoveInLoadings { get; set; }
        public virtual DbSet<MigParcelMoveInLoadingOnRequest> MigParcelMoveInLoadingOnRequests { get; set; }
        public virtual DbSet<MigPremiseDescLookup> MigPremiseDescLookups { get; set; }
        public virtual DbSet<MigProjectLoading> MigProjectLoadings { get; set; }
        public virtual DbSet<MigProjectLoadingOnRequest> MigProjectLoadingOnRequests { get; set; }
        public virtual DbSet<MigProjectParcelMoveInLoadingOnRequest> MigProjectParcelMoveInLoadingOnRequests { get; set; }
        public virtual DbSet<MigProjectParcelStaging> MigProjectParcelStagings { get; set; }
        public virtual DbSet<MigProjectParcelUpdateOnRequest> MigProjectParcelUpdateOnRequests { get; set; }
        public virtual DbSet<MigProjectSourceException> MigProjectSourceExceptions { get; set; }
        public virtual DbSet<MigProjectStaging> MigProjectStagings { get; set; }
        public virtual DbSet<MigSalutationLookup> MigSalutationLookups { get; set; }
        public virtual DbSet<MigSrstatusDateSyncTemp> MigSrstatusDateSyncTemps { get; set; }
        public virtual DbSet<MigSspbcrmprojectId> MigSspbcrmprojectIds { get; set; }
        public virtual DbSet<MigStateLookup> MigStateLookups { get; set; }
        public virtual DbSet<MigStationLookup> MigStationLookups { get; set; }
        public virtual DbSet<MigTempSn> MigTempSns { get; set; }
        public virtual DbSet<MigTrnAccountStaging> MigTrnAccountStagings { get; set; }
        public virtual DbSet<MigTrnUserStaging> MigTrnUserStagings { get; set; }
        public virtual DbSet<MigTrnUserStaging2> MigTrnUserStaging2s { get; set; }
        public virtual DbSet<MigTrnUserStaging2X> MigTrnUserStaging2Xes { get; set; }
        public virtual DbSet<MigUserAccountException> MigUserAccountExceptions { get; set; }
        public virtual DbSet<MigUserAccountLoading> MigUserAccountLoadings { get; set; }
        public virtual DbSet<MigUserAccountStaging> MigUserAccountStagings { get; set; }
        public virtual DbSet<ModeofPayment> ModeofPayments { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<ModuleItem> ModuleItems { get; set; }
        public virtual DbSet<NewConnection> NewConnections { get; set; }
        public virtual DbSet<NewConnectionAddressDeleted> NewConnectionAddressDeleteds { get; set; }
        public virtual DbSet<NewConnectionApplicationStatus> NewConnectionApplicationStatuses { get; set; }
        public virtual DbSet<NewConnectionApprovalInformation> NewConnectionApprovalInformations { get; set; }
        public virtual DbSet<NewConnectionAssignment> NewConnectionAssignments { get; set; }
        public virtual DbSet<NewConnectionAttachment> NewConnectionAttachments { get; set; }
        public virtual DbSet<NewConnectionBackup8Nov19> NewConnectionBackup8Nov19s { get; set; }
        public virtual DbSet<NewConnectionBackupDeleted> NewConnectionBackupDeleteds { get; set; }
        public virtual DbSet<NewConnectionBackupPatchStatus18Nov> NewConnectionBackupPatchStatus18Novs { get; set; }
        public virtual DbSet<NewConnectionCallLog> NewConnectionCallLogs { get; set; }
        public virtual DbSet<NewConnectionCancelInformation> NewConnectionCancelInformations { get; set; }
        public virtual DbSet<NewConnectionChangeLog> NewConnectionChangeLogs { get; set; }
        public virtual DbSet<NewConnectionContractor> NewConnectionContractors { get; set; }
        public virtual DbSet<NewConnectionContractorBackup8Nov19> NewConnectionContractorBackup8Nov19s { get; set; }
        public virtual DbSet<NewConnectionContractorBackupDeleted> NewConnectionContractorBackupDeleteds { get; set; }
        public virtual DbSet<NewConnectionFavApplication> NewConnectionFavApplications { get; set; }
        public virtual DbSet<NewConnectionLandlordTenant> NewConnectionLandlordTenants { get; set; }
        public virtual DbSet<NewConnectionReworkInformation> NewConnectionReworkInformations { get; set; }
        public virtual DbSet<NewConnectionStatusLog> NewConnectionStatusLogs { get; set; }
        public virtual DbSet<NewConnectionSubmitSystemMessage> NewConnectionSubmitSystemMessages { get; set; }
        public virtual DbSet<NewConnectionTechnical> NewConnectionTechnicals { get; set; }
        public virtual DbSet<NewlyBuiltSubmission> NewlyBuiltSubmissions { get; set; }
        public virtual DbSet<NotMigratedProjectParcel> NotMigratedProjectParcels { get; set; }
        public virtual DbSet<OpowerTnbrecipient> OpowerTnbrecipients { get; set; }
        public virtual DbSet<Otp> Otps { get; set; }
        public virtual DbSet<OutBoundWebServiceLog> OutBoundWebServiceLogs { get; set; }
        public virtual DbSet<PaymentBlockedCa> PaymentBlockedCas { get; set; }
        public virtual DbSet<PaymentBlockedEmail> PaymentBlockedEmails { get; set; }
        public virtual DbSet<PaymentBlockedMobileNo> PaymentBlockedMobileNos { get; set; }
        public virtual DbSet<PaymentReceipt> PaymentReceipts { get; set; }
        public virtual DbSet<PaymentReceiptBackup8Nov19> PaymentReceiptBackup8Nov19s { get; set; }
        public virtual DbSet<PaymentReceiptDetail> PaymentReceiptDetails { get; set; }
        public virtual DbSet<PaymentReceiptDetailBackup8Nov19> PaymentReceiptDetailBackup8Nov19s { get; set; }
        public virtual DbSet<PaymentReceiptLog> PaymentReceiptLogs { get; set; }
        public virtual DbSet<PaymentReceiptQueue> PaymentReceiptQueues { get; set; }
        public virtual DbSet<PaymentReceiptTrace> PaymentReceiptTraces { get; set; }
        public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public virtual DbSet<PremiseTypeHeader> PremiseTypeHeaders { get; set; }
        public virtual DbSet<PremiseTypeItem> PremiseTypeItems { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectAttachment> ProjectAttachments { get; set; }
        public virtual DbSet<ProjectAttachment18022021Bk> ProjectAttachment18022021Bks { get; set; }
        public virtual DbSet<ProjectCallLog> ProjectCallLogs { get; set; }
        public virtual DbSet<ProjectCancelInformation> ProjectCancelInformations { get; set; }
        public virtual DbSet<ProjectChangeLog> ProjectChangeLogs { get; set; }
        public virtual DbSet<ProjectConsultant> ProjectConsultants { get; set; }
        public virtual DbSet<ProjectContractor> ProjectContractors { get; set; }
        public virtual DbSet<ProjectFavApplication> ProjectFavApplications { get; set; }
        public virtual DbSet<ProjectParcel> ProjectParcels { get; set; }
        public virtual DbSet<ProjectPic> ProjectPics { get; set; }
        public virtual DbSet<ProjectReworkInformation> ProjectReworkInformations { get; set; }
        public virtual DbSet<ProjectStatusLog> ProjectStatusLogs { get; set; }
        public virtual DbSet<ProjectStatusMonitoring> ProjectStatusMonitorings { get; set; }
        public virtual DbSet<ProjectSubmitSystemMessage> ProjectSubmitSystemMessages { get; set; }
        public virtual DbSet<PurposeOfPremise> PurposeOfPremises { get; set; }
        public virtual DbSet<PwdManagement> PwdManagements { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        public virtual DbSet<QuestionCategory> QuestionCategories { get; set; }
        public virtual DbSet<QuestionPrequesiteSet> QuestionPrequesiteSets { get; set; }
        public virtual DbSet<RecontractManagement> RecontractManagements { get; set; }
        public virtual DbSet<RecontractManagementAttachment> RecontractManagementAttachments { get; set; }
        public virtual DbSet<RecontractManagementFavApplication> RecontractManagementFavApplications { get; set; }
        public virtual DbSet<RetailDatum> RetailData { get; set; }
        public virtual DbSet<RetechStudyApplication> RetechStudyApplications { get; set; }
        public virtual DbSet<RetechStudyApplicationAttachment> RetechStudyApplicationAttachments { get; set; }
        public virtual DbSet<RetechStudyApplicationAttachmentNew> RetechStudyApplicationAttachmentNews { get; set; }
        public virtual DbSet<RetechStudyApplicationNew> RetechStudyApplicationNews { get; set; }
        public virtual DbSet<RetechStudyFavApplication> RetechStudyFavApplications { get; set; }
        public virtual DbSet<Rewiring> Rewirings { get; set; }
        public virtual DbSet<RewiringApplicationStatus> RewiringApplicationStatuses { get; set; }
        public virtual DbSet<RewiringAttachment> RewiringAttachments { get; set; }
        public virtual DbSet<RewiringBackup> RewiringBackups { get; set; }
        public virtual DbSet<RewiringBackup8Nov19> RewiringBackup8Nov19s { get; set; }
        public virtual DbSet<RewiringContractor> RewiringContractors { get; set; }
        public virtual DbSet<RewiringContractorBackup8Nov19> RewiringContractorBackup8Nov19s { get; set; }
        public virtual DbSet<RewiringContractorBackupDeleted> RewiringContractorBackupDeleteds { get; set; }
        public virtual DbSet<RewiringStatusLog> RewiringStatusLogs { get; set; }
        public virtual DbSet<RewiringTechnical> RewiringTechnicals { get; set; }
        public virtual DbSet<Salutation> Salutations { get; set; }
        public virtual DbSet<Sapmodule> Sapmodules { get; set; }
        public virtual DbSet<SchemeTypeMapping> SchemeTypeMappings { get; set; }
        public virtual DbSet<Sheet1> Sheet1s { get; set; }
        public virtual DbSet<Smr> Smrs { get; set; }
        public virtual DbSet<Smrattachment> Smrattachments { get; set; }
        public virtual DbSet<SmrfavApplication> SmrfavApplications { get; set; }
        public virtual DbSet<SmrstatusLog> SmrstatusLogs { get; set; }
        public virtual DbSet<SmsTemplate> SmsTemplates { get; set; }
        public virtual DbSet<SmsTraceLog> SmsTraceLogs { get; set; }
        public virtual DbSet<SspApplicationPremiseType> SspApplicationPremiseTypes { get; set; }
        public virtual DbSet<SspTargetBulk> SspTargetBulks { get; set; }
        public virtual DbSet<Sspnotification> Sspnotifications { get; set; }
        public virtual DbSet<SspnotificationQueue> SspnotificationQueues { get; set; }
        public virtual DbSet<SspnotificationTrace> SspnotificationTraces { get; set; }
        public virtual DbSet<Ssprole> Ssproles { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<StbandarSource> StbandarSources { get; set; }
        public virtual DbSet<Stcategory> Stcategories { get; set; }
        public virtual DbSet<Stcity> Stcities { get; set; }
        public virtual DbSet<Stcontractor> Stcontractors { get; set; }
        public virtual DbSet<StcontractorSource> StcontractorSources { get; set; }
        public virtual DbSet<Stcountry> Stcountries { get; set; }
        public virtual DbSet<StintegrationLog> StintegrationLogs { get; set; }
        public virtual DbSet<StkategoriSource> StkategoriSources { get; set; }
        public virtual DbSet<StnegaraSource> StnegaraSources { get; set; }
        public virtual DbSet<StnegeriSource> StnegeriSources { get; set; }
        public virtual DbSet<StreetlightSubCategory> StreetlightSubCategories { get; set; }
        public virtual DbSet<Ststate> Ststates { get; set; }
        public virtual DbSet<SubModule> SubModules { get; set; }
        public virtual DbSet<SurveyDetail> SurveyDetails { get; set; }
        public virtual DbSet<SurveyHeader> SurveyHeaders { get; set; }
        public virtual DbSet<SurveyResult> SurveyResults { get; set; }
        public virtual DbSet<SystemConfig> SystemConfigs { get; set; }
        public virtual DbSet<SystemConfigBackup8Nov19> SystemConfigBackup8Nov19s { get; set; }
        public virtual DbSet<TechnologyCategory> TechnologyCategories { get; set; }
        public virtual DbSet<TechnologyGenerationCapacity> TechnologyGenerationCapacities { get; set; }
        public virtual DbSet<TechnologySubCategory> TechnologySubCategories { get; set; }
        public virtual DbSet<Testapp> Testapps { get; set; }
        public virtual DbSet<Testxml> Testxmls { get; set; }
        public virtual DbSet<Tnbstation> Tnbstations { get; set; }
        public virtual DbSet<TrnAccount> TrnAccounts { get; set; }
        public virtual DbSet<TrnAccount20190624Deleted> TrnAccount20190624Deleteds { get; set; }
        public virtual DbSet<TrnAccountActivityLog> TrnAccountActivityLogs { get; set; }
        public virtual DbSet<TrnAccountDeltaLog> TrnAccountDeltaLogs { get; set; }
        public virtual DbSet<TrnAccountDummyDeleted> TrnAccountDummyDeleteds { get; set; }
        public virtual DbSet<TrnAccountPre> TrnAccountPres { get; set; }
        public virtual DbSet<TrnSubModuleRole> TrnSubModuleRoles { get; set; }
        public virtual DbSet<TrnSubModuleRoleBackup8Nov19> TrnSubModuleRoleBackup8Nov19s { get; set; }
        public virtual DbSet<TrnUser> TrnUsers { get; set; }
        public virtual DbSet<TrnUser20200605> TrnUser20200605s { get; set; }
        public virtual DbSet<TrnUserLoginHistory> TrnUserLoginHistories { get; set; }
        public virtual DbSet<TrnUserMobileHistory> TrnUserMobileHistories { get; set; }
        public virtual DbSet<TrnUserSession> TrnUserSessions { get; set; }
        public virtual DbSet<UserListProdRoleSeparationDeleted> UserListProdRoleSeparationDeleteds { get; set; }
        public virtual DbSet<UserSurveyDetail> UserSurveyDetails { get; set; }
        public virtual DbSet<UserSurveyHeader> UserSurveyHeaders { get; set; }
        public virtual DbSet<Voltage> Voltages { get; set; }
        public virtual DbSet<Walkthrough> Walkthroughs { get; set; }
        public virtual DbSet<WltysentEmailLog> WltysentEmailLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //                optionsBuilder.UseSqlServer("Server=.;Database=SSPDB;Trusted_Connection=True;");
                var a = AppDomain.CurrentDomain.BaseDirectory;
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyTNBDBConnection"));
                

            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.ToTable("AccountType");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.AccountTypeDesc)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AcstoAcpbackUpDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACSToACPBackUp_Deleted");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicantType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BP_No");

                entity.Property(e => e.ContactPersonName1).HasMaxLength(40);

                entity.Property(e => e.ContactPersonName2).HasMaxLength(40);

                entity.Property(e => e.ContactPersonPosition).HasMaxLength(20);

                entity.Property(e => e.ContractAccountNo).HasMaxLength(14);

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(240);

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.FixedLineNo).HasMaxLength(15);

                entity.Property(e => e.GivenTitleId).HasColumnName("GivenTitleID");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(20)
                    .HasColumnName("GSTNo");

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.InstallationNo).HasMaxLength(12);

                entity.Property(e => e.IsSearchByCa).HasColumnName("IsSearchByCA");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoadType)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LockStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaEducation).HasColumnName("MA_Education");

                entity.Property(e => e.MaIncome).HasColumnName("MA_Income");

                entity.Property(e => e.MaOccupation).HasColumnName("MA_Occupation");

                entity.Property(e => e.MaPaymentChannel).HasColumnName("MA_PaymentChannel");

                entity.Property(e => e.MaPaymentMethod).HasColumnName("MA_PaymentMethod");

                entity.Property(e => e.MaRace).HasColumnName("MA_Race");

                entity.Property(e => e.MaReligion).HasColumnName("MA_Religion");

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(10);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.MothersName).HasMaxLength(40);

                entity.Property(e => e.Name1).HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.NextOfKinEmail).HasMaxLength(240);

                entity.Property(e => e.NextOfKinName1).HasMaxLength(40);

                entity.Property(e => e.NextOfKinName2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinPhoneNo).HasMaxLength(15);

                entity.Property(e => e.ParcelId).HasColumnName("ParcelID");

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseCurrentMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(12);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.ProcessBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceNo).HasMaxLength(4000);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.SearchedCano)
                    .HasMaxLength(14)
                    .HasColumnName("SearchedCANo");

                entity.Property(e => e.SnForAttachment)
                    .HasMaxLength(20)
                    .HasColumnName("SN_for_Attachment");

                entity.Property(e => e.SnNo)
                    .HasMaxLength(20)
                    .HasColumnName("SN_No");

                entity.Property(e => e.SnStatus)
                    .HasMaxLength(50)
                    .HasColumnName("SN_Status");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.SrStatus)
                    .HasMaxLength(50)
                    .HasColumnName("SR_Status");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserRole).HasMaxLength(20);
            });

            modelBuilder.Entity<AddressSearchRequest>(entity =>
            {
                entity.ToTable("AddressSearchRequest");

                entity.Property(e => e.AddressSearchRequestId).HasColumnName("AddressSearchRequestID");

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.ApplicationRefNo).HasMaxLength(4000);

                entity.Property(e => e.Area).HasMaxLength(40);

                entity.Property(e => e.AssignedState).HasMaxLength(10);

                entity.Property(e => e.Building).HasMaxLength(40);

                entity.Property(e => e.City).HasMaxLength(40);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FormBuildingName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FormBuildingNumber).HasMaxLength(10);

                entity.Property(e => e.FormUnitNo).HasMaxLength(10);

                entity.Property(e => e.HouseNo).HasMaxLength(10);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LockStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseFullText)
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.PremiseNo).HasMaxLength(12);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.ProcessBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([AddressSearchRequestID],'ASR-000-000-0000'))", false);

                entity.Property(e => e.ResolvedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.StationEmail).HasMaxLength(240);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Street).HasMaxLength(60);

                entity.Property(e => e.StreetCode).HasMaxLength(40);

                entity.Property(e => e.UnitNo).HasMaxLength(10);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.AddressSearchRequests)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AddressSearchRequest_ApplicationStatus");
            });

            modelBuilder.Entity<AddressSearchRequestLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("AddressSearchRequestLog");

                entity.Property(e => e.AddressSearchRequestId).HasColumnName("AddressSearchRequestID");

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.ApplicationRefNo).HasMaxLength(4000);

                entity.Property(e => e.Area).HasMaxLength(80);

                entity.Property(e => e.AssignedState).HasMaxLength(20);

                entity.Property(e => e.Building).HasMaxLength(80);

                entity.Property(e => e.City).HasMaxLength(80);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FormBuildingName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FormBuildingNumber).HasMaxLength(20);

                entity.Property(e => e.FormUnitNo).HasMaxLength(20);

                entity.Property(e => e.HouseNo).HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LockStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LogAction)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LogDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo).HasMaxLength(30);

                entity.Property(e => e.PostalCode).HasMaxLength(20);

                entity.Property(e => e.PremiseFullText)
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.PremiseNo).HasMaxLength(24);

                entity.Property(e => e.PremiseType).HasMaxLength(20);

                entity.Property(e => e.ProcessBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNo).HasMaxLength(4000);

                entity.Property(e => e.ResolvedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.State).HasMaxLength(510);

                entity.Property(e => e.StationEmail).HasMaxLength(480);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Street).HasMaxLength(120);

                entity.Property(e => e.StreetCode).HasMaxLength(80);

                entity.Property(e => e.UnitNo).HasMaxLength(20);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Amp>(entity =>
            {
                entity.HasKey(e => e.Ampsid);

                entity.Property(e => e.Ampsid).HasColumnName("AMPSID");
            });

            modelBuilder.Entity<AnnouncementBak11172020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Announcement_bak11172020");

                entity.Property(e => e.AnnouncementId).HasColumnName("AnnouncementID");

                entity.Property(e => e.AnnouncementMessage).IsRequired();

                entity.Property(e => e.AnnouncementTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PublishFromDateTime).HasColumnType("datetime");

                entity.Property(e => e.PublishToDateTime).HasColumnType("datetime");

                entity.Property(e => e.ViewBy)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.Property(e => e.Answers)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnswerSet>(entity =>
            {
                entity.ToTable("AnswerSet");

                entity.Property(e => e.AnswerSet1)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("AnswerSet");
            });

            modelBuilder.Entity<AnswerType>(entity =>
            {
                entity.ToTable("AnswerType");

                entity.Property(e => e.AnswerType1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("AnswerType");
            });

            modelBuilder.Entity<ApplicationFileUpload>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("ApplicationFileUpload");

                entity.HasIndex(e => e.FileId, "UQ__Applicat__6F0F989E7847ADB9")
                    .IsUnique();

                entity.Property(e => e.FileId)
                    .ValueGeneratedNever()
                    .HasColumnName("FileID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileGroupId)
                    .HasMaxLength(20)
                    .HasColumnName("FileGroupID");

                entity.Property(e => e.FileName).IsRequired();

                entity.Property(e => e.FileServerPath).IsRequired();

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NextTryDate).HasColumnType("datetime");

                entity.Property(e => e.NoOfTry).HasDefaultValueSql("((0))");

                entity.Property(e => e.UploadStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ApplicationFileUploadQueue>(entity =>
            {
                entity.HasKey(e => e.FileQueueId);

                entity.ToTable("ApplicationFileUploadQueue");

                entity.HasIndex(e => e.FileQueueId, "IX_FileQueueID")
                    .IsUnique();

                entity.Property(e => e.FileQueueId)
                    .HasColumnName("FileQueueID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DestinationInd).HasMaxLength(10);

                entity.Property(e => e.FileGroupId)
                    .HasMaxLength(20)
                    .HasColumnName("FileGroupID");

                entity.Property(e => e.FileId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("FileID");

                entity.Property(e => e.FileName).IsRequired();

                entity.Property(e => e.FileServerPath).IsRequired();

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NextTryDate).HasColumnType("datetime");

                entity.Property(e => e.NoOfTry).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferenceNo).HasMaxLength(20);

                entity.Property(e => e.ReferenceType).HasMaxLength(5);

                entity.Property(e => e.UploadStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ApplicationStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("ApplicationStatus");

                entity.HasIndex(e => e.StatusCode, "IX_ApplicationStatus_StatusCode");

                entity.Property(e => e.StatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("StatusID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StatusProfile)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationStatusSync>(entity =>
            {
                entity.ToTable("ApplicationStatusSync");

                entity.HasIndex(e => e.ReferenceNo, "IX_ApplicationStatusSync_ReferenceNo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReadFlag).HasMaxLength(1);

                entity.Property(e => e.ReferenceNo).HasMaxLength(20);

                entity.Property(e => e.SnNo)
                    .HasMaxLength(20)
                    .HasColumnName("SN_No");

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusSap)
                    .HasMaxLength(50)
                    .HasColumnName("Status_SAP");

                entity.Property(e => e.StatusSsp)
                    .HasMaxLength(50)
                    .HasColumnName("Status_SSP");

                entity.Property(e => e.UpdateFlag).HasMaxLength(1);
            });

            modelBuilder.Entity<ApplicationStatusTracker>(entity =>
            {
                entity.ToTable("ApplicationStatusTracker");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationModuleId)
                    .HasColumnName("ApplicationModuleID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('system')");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsGe).HasColumnName("IsGE");

                entity.Property(e => e.IsLpc).HasColumnName("IsLPC");

                entity.Property(e => e.IsLpcnem).HasColumnName("IsLPCNEM");

                entity.Property(e => e.IsOpc).HasColumnName("IsOPC");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('system')");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostStatusDescription).HasMaxLength(100);

                entity.Property(e => e.PreStatusDescription).HasMaxLength(100);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Source).HasMaxLength(10);

                entity.Property(e => e.StatusCode).HasMaxLength(100);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusMessage).HasMaxLength(200);

                entity.Property(e => e.StatusProfile).HasMaxLength(10);

                entity.Property(e => e.UserAction).HasMaxLength(100);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ApplicationStatusTrackers)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_ApplicationStatusMapping_StatusID");
            });

            modelBuilder.Entity<ApplicationStatusTracker03022021Bk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApplicationStatusTracker_03022021_BK");

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsGe).HasColumnName("IsGE");

                entity.Property(e => e.IsLpc).HasColumnName("IsLPC");

                entity.Property(e => e.IsLpcnem).HasColumnName("IsLPCNEM");

                entity.Property(e => e.IsOpc).HasColumnName("IsOPC");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostStatusDescription).HasMaxLength(100);

                entity.Property(e => e.PreStatusDescription).HasMaxLength(100);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Source).HasMaxLength(10);

                entity.Property(e => e.StatusCode).HasMaxLength(100);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusMessage).HasMaxLength(200);

                entity.Property(e => e.StatusProfile).HasMaxLength(10);

                entity.Property(e => e.UserAction).HasMaxLength(100);
            });

            modelBuilder.Entity<ApplicationStatusTracker29012021Bk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApplicationStatusTracker_29012021_BK");

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsGe).HasColumnName("IsGE");

                entity.Property(e => e.IsLpc).HasColumnName("IsLPC");

                entity.Property(e => e.IsLpcnem).HasColumnName("IsLPCNEM");

                entity.Property(e => e.IsOpc).HasColumnName("IsOPC");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostStatusDescription).HasMaxLength(100);

                entity.Property(e => e.PreStatusDescription).HasMaxLength(100);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Source).HasMaxLength(10);

                entity.Property(e => e.StatusCode).HasMaxLength(100);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusMessage).HasMaxLength(200);

                entity.Property(e => e.StatusProfile).HasMaxLength(10);

                entity.Property(e => e.UserAction).HasMaxLength(100);
            });

            modelBuilder.Entity<ApplicationStatusTracker30012021Bk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApplicationStatusTracker_30012021_BK");

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsGe).HasColumnName("IsGE");

                entity.Property(e => e.IsLpc).HasColumnName("IsLPC");

                entity.Property(e => e.IsLpcnem).HasColumnName("IsLPCNEM");

                entity.Property(e => e.IsOpc).HasColumnName("IsOPC");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostStatusDescription).HasMaxLength(100);

                entity.Property(e => e.PreStatusDescription).HasMaxLength(100);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Source).HasMaxLength(10);

                entity.Property(e => e.StatusCode).HasMaxLength(100);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusMessage).HasMaxLength(200);

                entity.Property(e => e.StatusProfile).HasMaxLength(10);

                entity.Property(e => e.UserAction).HasMaxLength(100);
            });

            modelBuilder.Entity<Asrattachment>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.AddressSearchRequestId });

                entity.ToTable("ASRAttachment");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.AddressSearchRequestId).HasColumnName("AddressSearchRequestID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileGroupId)
                    .HasMaxLength(20)
                    .HasColumnName("FileGroupID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.AddressSearchRequest)
                    .WithMany(p => p.Asrattachments)
                    .HasForeignKey(d => d.AddressSearchRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASRAttachment_AddressSearchRequest");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.Asrattachments)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_ASRAttachment_ApplicationFileUpload");
            });

            modelBuilder.Entity<AsrcallLogAttachment>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.AddressSearchRequestId });

                entity.ToTable("ASRCallLogAttachment");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.AddressSearchRequestId).HasColumnName("AddressSearchRequestID");

                entity.Property(e => e.AsrcallLogId).HasColumnName("ASRCallLogID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileGroupId)
                    .HasMaxLength(20)
                    .HasColumnName("FileGroupID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.AddressSearchRequest)
                    .WithMany(p => p.AsrcallLogAttachments)
                    .HasForeignKey(d => d.AddressSearchRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASRCallLogAttachment_AddressSearchRequest");

                entity.HasOne(d => d.AsrcallLog)
                    .WithMany(p => p.AsrcallLogAttachments)
                    .HasForeignKey(d => d.AsrcallLogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASRCallLogAttachment_ASRCallLogID");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.AsrcallLogAttachments)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_ASRCallLogAttachment_ApplicationFileUpload");
            });

            modelBuilder.Entity<AsrcancelInformation>(entity =>
            {
                entity.HasKey(e => e.AsrcancelInfoId);

                entity.ToTable("ASRCancelInformation");

                entity.Property(e => e.AsrcancelInfoId).HasColumnName("ASRCancelInfoID");

                entity.Property(e => e.AddressSearchRequestId).HasColumnName("AddressSearchRequestID");

                entity.Property(e => e.ApplicantUserId).HasColumnName("ApplicantUserID");

                entity.Property(e => e.CancelReasons)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CarelineUserId).HasColumnName("CarelineUserID");

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.AddressSearchRequest)
                    .WithMany(p => p.AsrcancelInformations)
                    .HasForeignKey(d => d.AddressSearchRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASRCancelInformation_AddressSearchRequestID");

                entity.HasOne(d => d.ApplicantUser)
                    .WithMany(p => p.AsrcancelInformationApplicantUsers)
                    .HasForeignKey(d => d.ApplicantUserId)
                    .HasConstraintName("FK_ASRCancelInformation_ApplicantUserID");

                entity.HasOne(d => d.CarelineUser)
                    .WithMany(p => p.AsrcancelInformationCarelineUsers)
                    .HasForeignKey(d => d.CarelineUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASRCancelInformation_CarelineUserID");
            });

            modelBuilder.Entity<AsrfavApplication>(entity =>
            {
                entity.HasKey(e => e.FavAppId)
                    .HasName("PK_ASRFavApplication_FavAppID");

                entity.ToTable("ASRFavApplication");

                entity.HasIndex(e => new { e.UserId, e.RoleId, e.IsDeleted }, "IX_ASRFavApplication_Filter");

                entity.Property(e => e.FavAppId)
                    .HasColumnName("FavAppID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BackendAppId).HasColumnName("BackendAppID");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<AsrlogAction>(entity =>
            {
                entity.ToTable("ASRLogAction");

                entity.Property(e => e.AsrlogActionId).HasColumnName("ASRLogActionID");

                entity.Property(e => e.AddressSearchRequestId).HasColumnName("AddressSearchRequestID");

                entity.Property(e => e.Asraction)
                    .HasMaxLength(50)
                    .HasColumnName("ASRAction");

                entity.Property(e => e.AssignedState).HasMaxLength(10);

                entity.Property(e => e.CancelReason).HasMaxLength(50);

                entity.Property(e => e.CarelineUserId).HasColumnName("CarelineUserID");

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.RetailDataUserId).HasColumnName("RetailDataUserID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.AddressSearchRequest)
                    .WithMany(p => p.AsrlogActions)
                    .HasForeignKey(d => d.AddressSearchRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASRLogAction_AddressSearchRequest");

                entity.HasOne(d => d.CarelineUser)
                    .WithMany(p => p.AsrlogActionCarelineUsers)
                    .HasForeignKey(d => d.CarelineUserId)
                    .HasConstraintName("FK_ASRLogAction_TrnUserCarelineUserID");

                entity.HasOne(d => d.RetailDataUser)
                    .WithMany(p => p.AsrlogActionRetailDataUsers)
                    .HasForeignKey(d => d.RetailDataUserId)
                    .HasConstraintName("FK_ASRLogAction_TrnUserRetailDataUserID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.AsrlogActions)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASRLogAction_ApplicationStatus");
            });

            modelBuilder.Entity<AsrstatusLog>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_ASRStatusLog_Guid");

                entity.ToTable("ASRStatusLog");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddressSearchRequestId).HasColumnName("AddressSearchRequestID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.AsrstatusLogs)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_ASRStatusLog_ApplicationStatus");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("Bank");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankAccountNoLength).HasMaxLength(20);

                entity.Property(e => e.BankCode)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.BankCountry).HasMaxLength(20);

                entity.Property(e => e.BankDescription).HasMaxLength(200);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SwiftCode).HasMaxLength(40);
            });

            modelBuilder.Entity<BankForBulkPayment>(entity =>
            {
                entity.HasKey(e => e.BankId)
                    .HasName("PK_EBulkBank");

                entity.ToTable("BankForBulkPayment");

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .HasColumnName("BankID");

                entity.Property(e => e.BankCode).HasMaxLength(10);

                entity.Property(e => e.BankDescription).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BatchApprovalQueue>(entity =>
            {
                entity.ToTable("BatchApprovalQueue");

                entity.Property(e => e.BatchApprovalQueueId)
                    .HasColumnName("BatchApprovalQueueID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Coaid).HasColumnName("COAID");

                entity.Property(e => e.Cotid).HasColumnName("COTID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.NextTryDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Reid).HasColumnName("REID");

                entity.Property(e => e.RewiringId).HasColumnName("RewiringID");
            });

            modelBuilder.Entity<BatchApprovalTrace>(entity =>
            {
                entity.ToTable("BatchApprovalTrace");

                entity.Property(e => e.BatchApprovalTraceId)
                    .HasColumnName("BatchApprovalTraceID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Coaid).HasColumnName("COAID");

                entity.Property(e => e.Cotid).HasColumnName("COTID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.NextTryDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Reid).HasColumnName("REID");

                entity.Property(e => e.RewiringId).HasColumnName("RewiringID");
            });

            modelBuilder.Entity<BcrmDocNoPatching>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BcrmDocNoPatching");

                entity.Property(e => e.BcrmDocNo).HasMaxLength(255);

                entity.Property(e => e.CaNo)
                    .HasMaxLength(255)
                    .HasColumnName("CA_No");

                entity.Property(e => e.PaymentId)
                    .HasMaxLength(255)
                    .HasColumnName("PaymentID");

                entity.Property(e => e.PaymentNo).HasMaxLength(255);

                entity.Property(e => e.ReferenceNo).HasMaxLength(255);

                entity.Property(e => e.RevenueCode).HasMaxLength(255);
            });

            modelBuilder.Entity<BillNotificationDummyDataDeleted>(entity =>
            {
                entity.ToTable("BillNotificationDummyData_Deleted");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(40)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .HasColumnName("EmailID");
            });

            modelBuilder.Entity<BillNotificationInboundQueue>(entity =>
            {
                entity.ToTable("BillNotificationInboundQueue");

                entity.Property(e => e.BillNotificationInboundQueueId)
                    .HasColumnName("BillNotificationInboundQueueID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(40)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .HasColumnName("EmailID");

                entity.Property(e => e.IsDeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SentDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BillNotificationInboundTrace>(entity =>
            {
                entity.ToTable("BillNotificationInboundTrace");

                entity.Property(e => e.BillNotificationInboundTraceId)
                    .HasColumnName("BillNotificationInboundTraceID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(40)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .HasColumnName("EmailID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SentDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BillNotificationOutboundQueue>(entity =>
            {
                entity.ToTable("BillNotificationOutboundQueue");

                entity.Property(e => e.BillNotificationOutboundQueueId)
                    .HasColumnName("BillNotificationOutboundQueueID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(40)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .HasColumnName("EmailID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NextTryDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnCode).HasMaxLength(3);

                entity.Property(e => e.SentDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<BillNotificationOutboundTrace>(entity =>
            {
                entity.ToTable("BillNotificationOutboundTrace");

                entity.Property(e => e.BillNotificationOutboundTraceId)
                    .HasColumnName("BillNotificationOutboundTraceID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(40)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .HasColumnName("EmailID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NextTryDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnCode).HasMaxLength(3);

                entity.Property(e => e.SentDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<BulkDataPool>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BulkDataPool");

                entity.Property(e => e.ContractAccountNo)
                    .HasMaxLength(255)
                    .HasColumnName("Contract Account No");

                entity.Property(e => e.F3).HasMaxLength(255);

                entity.Property(e => e.NewInvoiceNo)
                    .HasMaxLength(255)
                    .HasColumnName("New Invoice No");
            });

            modelBuilder.Entity<BulkPayLotFileDownloadLog>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("BulkPayLotFileDownloadLog");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).IsRequired();

                entity.Property(e => e.FileServerPath).IsRequired();

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BulkPayLotFileUploadLog>(entity =>
            {
                entity.HasKey(e => e.FileNo);

                entity.ToTable("BulkPayLotFileUploadLog");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).IsRequired();

                entity.Property(e => e.FileServerPath).IsRequired();

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BulkPayment>(entity =>
            {
                entity.HasKey(e => e.EbulkPaymentId)
                    .HasName("PK_TrnEBulkPayment");

                entity.ToTable("BulkPayment");

                entity.Property(e => e.EbulkPaymentId)
                    .HasColumnName("EBulkPaymentID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApproveOrrejectedBy)
                    .HasMaxLength(10)
                    .HasColumnName("ApproveORRejectedBy");

                entity.Property(e => e.ApproveOrrejectedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ApproveORRejectedDate");

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .HasColumnName("BankID");

                entity.Property(e => e.CollectiveContractAccountNo).HasMaxLength(12);

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsPaymentPaid).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModeofPayment)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentRefNo).HasMaxLength(30);

                entity.Property(e => e.ReturnCode).HasMaxLength(2);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TnbreferenceNo)
                    .HasMaxLength(50)
                    .HasColumnName("TNBReferenceNo");

                entity.Property(e => e.TotalItems)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransactionAmount).HasMaxLength(20);

                entity.Property(e => e.TypeOfPayment).HasMaxLength(1);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.BulkPayments)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK__TrnEBulkP__BankI__2AD55B43");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.BulkPayments)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK__TrnEBulkP__Statu__1837881B");
            });

            modelBuilder.Entity<BulkPaymentAccountList>(entity =>
            {
                entity.HasKey(e => e.InvoiceNo)
                    .HasName("PK_TrnEBulkAccountList");

                entity.ToTable("BulkPaymentAccountList");

                entity.HasIndex(e => new { e.ContractAccountNo, e.IsDeleted }, "IX_BulkPaymentAccountList_ContractAccountNo_IsDeleted");

                entity.HasIndex(e => e.CreatedDate, "IX_BulkPaymentAccountList_CreatedDate");

                entity.HasIndex(e => e.EbulkPaymentId, "IX_BulkPaymentAccountList_EBulkPaymentID");

                entity.HasIndex(e => e.InvoiceNo, "IX_BulkPaymentAccountList_InvoiceNo");

                entity.HasIndex(e => e.ReferenceNo, "IX_BulkPaymentAccountList_ReferenceNo");

                entity.HasIndex(e => e.InvoiceNo, "XI_BulkPaymentAccountList_Included_Index");

                entity.HasIndex(e => e.EbulkExtractionId, "i1");

                entity.Property(e => e.InvoiceNo).HasMaxLength(12);

                entity.Property(e => e.ActiveId)
                    .HasMaxLength(15)
                    .HasColumnName("ActiveID");

                entity.Property(e => e.AdjustmentIndicator).HasMaxLength(3);

                entity.Property(e => e.AmountWithoutGst)
                    .HasMaxLength(15)
                    .HasColumnName("AmountWithoutGST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CollectiveContractAccountNo)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.Property(e => e.CollectiveInvoiceNo)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.ContractAccountNo)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentCharge)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrentReading)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EbulkExtractionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EbulkExtractionID");

                entity.Property(e => e.EbulkPaymentId).HasColumnName("EBulkPaymentID");

                entity.Property(e => e.Gstamount)
                    .HasMaxLength(15)
                    .HasColumnName("GSTAmount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InstanceFlag).HasMaxLength(5);

                entity.Property(e => e.InvoiceDate).HasMaxLength(10);

                entity.Property(e => e.IsPayLotmatch)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IsPaymentNotificationSent).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastAmountPaid)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastBillNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.LastBillPaid).HasMaxLength(10);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OutstandingAmount)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentDueDate).HasColumnType("datetime");

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.ReadingDate).HasMaxLength(10);

                entity.Property(e => e.ReadingEndDate)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('00000000')");

                entity.Property(e => e.ReadingType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.Reference)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.ReturnCode).HasMaxLength(2);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.TariffCode)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TariffDescription)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TaxBasedAmount)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TnbreferenceNo)
                    .HasMaxLength(50)
                    .HasColumnName("TNBReferenceNo");

                entity.Property(e => e.TotalAmountPayable)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CollectiveInvoiceNoNavigation)
                    .WithMany(p => p.BulkPaymentAccountLists)
                    .HasForeignKey(d => d.CollectiveInvoiceNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BulkPaymentAccountList_BulkPaymentCollectiveAccount");

                entity.HasOne(d => d.EbulkPayment)
                    .WithMany(p => p.BulkPaymentAccountLists)
                    .HasForeignKey(d => d.EbulkPaymentId)
                    .HasConstraintName("FK_BulkPaymentAccountList_BulkPayment");
            });

            modelBuilder.Entity<BulkPaymentAccountListQueue>(entity =>
            {
                entity.HasKey(e => e.InvoiceNo)
                    .HasName("PK_TrnEBulkAccountListQueue");

                entity.ToTable("BulkPaymentAccountListQueue");

                entity.Property(e => e.InvoiceNo).HasMaxLength(12);

                entity.Property(e => e.ActiveId)
                    .HasMaxLength(15)
                    .HasColumnName("ActiveID");

                entity.Property(e => e.AdjustmentIndicator).HasMaxLength(3);

                entity.Property(e => e.AmountWithoutGst)
                    .HasMaxLength(15)
                    .HasColumnName("AmountWithoutGST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CollectiveContractAccountNo)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.Property(e => e.CollectiveInvoiceNo)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.ContractAccountNo)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentCharge)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrentReading)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EbulkExtractionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EbulkExtractionID");

                entity.Property(e => e.EbulkPaymentId).HasColumnName("EBulkPaymentID");

                entity.Property(e => e.Gstamount)
                    .HasMaxLength(15)
                    .HasColumnName("GSTAmount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InstanceFlag)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasMaxLength(10);

                entity.Property(e => e.IsPaymentNotificationSent).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastAmountPaid)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastBillNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.LastBillPaid).HasMaxLength(10);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OutstandingAmount)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentDueDate).HasColumnType("datetime");

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.ReadingDate).HasMaxLength(10);

                entity.Property(e => e.ReadingEndDate)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('00000000')");

                entity.Property(e => e.ReadingType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.Reference)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.ReturnCode).HasMaxLength(2);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.TariffCode)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TariffDescription)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TaxBasedAmount)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TnbreferenceNo)
                    .HasMaxLength(50)
                    .HasColumnName("TNBReferenceNo");

                entity.Property(e => e.TotalAmountPayable)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CollectiveInvoiceNoNavigation)
                    .WithMany(p => p.BulkPaymentAccountListQueues)
                    .HasForeignKey(d => d.CollectiveInvoiceNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BulkPaymentAccountListQueue_BulkPaymentCollectiveAccountQueue");

                entity.HasOne(d => d.EbulkPayment)
                    .WithMany(p => p.BulkPaymentAccountListQueues)
                    .HasForeignKey(d => d.EbulkPaymentId)
                    .HasConstraintName("FK_BulkPaymentAccountListQueue_BulkPayment");
            });

            modelBuilder.Entity<BulkPaymentCollectiveAccount>(entity =>
            {
                entity.HasKey(e => e.CollectiveInvoiceNo)
                    .HasName("PK_TrnEBulkCollectiveAccount");

                entity.ToTable("BulkPaymentCollectiveAccount");

                entity.Property(e => e.CollectiveInvoiceNo).HasMaxLength(12);

                entity.Property(e => e.CollectiveAccountName).HasMaxLength(255);

                entity.Property(e => e.CollectiveContractAccountNo).HasMaxLength(12);

                entity.Property(e => e.CollectiveInvoiceDueDate).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EbulkExtractionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EbulkExtractionID");

                entity.Property(e => e.EbulkPaymentId).HasColumnName("EBulkPaymentID");

                entity.Property(e => e.ExtractionDate).HasMaxLength(10);

                entity.Property(e => e.ExtractionTime).HasMaxLength(20);

                entity.Property(e => e.IsPaidByCollectiveAccount).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentPaidDate).HasMaxLength(10);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.ReturnCode).HasMaxLength(2);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TnbreferenceNo)
                    .HasMaxLength(50)
                    .HasColumnName("TNBReferenceNo");

                entity.Property(e => e.TotalTransactionAmount).HasMaxLength(20);

                entity.Property(e => e.TotalTransactionRecords).HasMaxLength(10);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.EbulkPayment)
                    .WithMany(p => p.BulkPaymentCollectiveAccounts)
                    .HasForeignKey(d => d.EbulkPaymentId)
                    .HasConstraintName("FK_BulkPaymentCollectiveAccount_BulkPayment");
            });

            modelBuilder.Entity<BulkPaymentCollectiveAccountQueue>(entity =>
            {
                entity.HasKey(e => e.CollectiveInvoiceNo)
                    .HasName("PK_TrnEBulkCollectiveAccountQueue");

                entity.ToTable("BulkPaymentCollectiveAccountQueue");

                entity.Property(e => e.CollectiveInvoiceNo).HasMaxLength(12);

                entity.Property(e => e.CollectiveAccountName).HasMaxLength(255);

                entity.Property(e => e.CollectiveContractAccountNo).HasMaxLength(12);

                entity.Property(e => e.CollectiveInvoiceDueDate).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EbulkExtractionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EbulkExtractionID");

                entity.Property(e => e.EbulkPaymentId).HasColumnName("EBulkPaymentID");

                entity.Property(e => e.ExtractionDate).HasMaxLength(10);

                entity.Property(e => e.ExtractionTime).HasMaxLength(20);

                entity.Property(e => e.IsPaidByCollectiveAccount).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentPaidDate).HasMaxLength(10);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.ReturnCode).HasMaxLength(2);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TnbreferenceNo)
                    .HasMaxLength(50)
                    .HasColumnName("TNBReferenceNo");

                entity.Property(e => e.TotalTransactionAmount).HasMaxLength(20);

                entity.Property(e => e.TotalTransactionRecords).HasMaxLength(10);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.EbulkPayment)
                    .WithMany(p => p.BulkPaymentCollectiveAccountQueues)
                    .HasForeignKey(d => d.EbulkPaymentId)
                    .HasConstraintName("FK_BulkPaymentCollectiveAccountQueue_BulkPayment");
            });

            modelBuilder.Entity<BulkPaymentLog>(entity =>
            {
                entity.ToTable("BulkPaymentLog");

                entity.Property(e => e.BulkPaymentLogId).HasColumnName("BulkPaymentLogID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Method).HasMaxLength(50);
            });

            modelBuilder.Entity<BulkPaymentLogQueue>(entity =>
            {
                entity.ToTable("BulkPaymentLogQueue");

                entity.Property(e => e.BulkPaymentLogQueueId).HasColumnName("BulkPaymentLogQueueID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Method).HasMaxLength(50);
            });

            modelBuilder.Entity<BulkPaymentQueue>(entity =>
            {
                entity.HasKey(e => e.BulkQueueId);

                entity.ToTable("BulkPaymentQueue");

                entity.Property(e => e.BulkQueueId)
                    .ValueGeneratedNever()
                    .HasColumnName("BulkQueueID");

                entity.Property(e => e.AccountNo).HasMaxLength(14);

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.BankCode).HasMaxLength(3);

                entity.Property(e => e.CardTransType).HasMaxLength(50);

                entity.Property(e => e.ChequeNo).HasMaxLength(20);

                entity.Property(e => e.ChequeType).HasMaxLength(1);

                entity.Property(e => e.CollAccountNo).HasMaxLength(14);

                entity.Property(e => e.CollInvoiceNo).HasMaxLength(14);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditCardNo).HasMaxLength(50);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LineNo).HasMaxLength(50);

                entity.Property(e => e.MerchantId).HasMaxLength(50);

                entity.Property(e => e.NextTryDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentAmount).HasMaxLength(50);

                entity.Property(e => e.PaymentChannel).HasMaxLength(2);

                entity.Property(e => e.PaymentDate).HasMaxLength(10);

                entity.Property(e => e.PaymentId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("PaymentID");

                entity.Property(e => e.PaymentMode).HasMaxLength(2);

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.RevenueCode).HasMaxLength(2);

                entity.Property(e => e.SentDateTime).HasColumnType("datetime");

                entity.Property(e => e.TotalAmount).HasMaxLength(50);

                entity.Property(e => e.TotalItems).HasMaxLength(50);
            });

            modelBuilder.Entity<BulkPaymentRejectPaymentList>(entity =>
            {
                entity.HasKey(e => e.EbulkExtractionId)
                    .HasName("PK__BulkPaym__C5C353D4E0E6C8CB");

                entity.ToTable("BulkPaymentRejectPaymentList");

                entity.Property(e => e.EbulkExtractionId).HasColumnName("EbulkExtractionID");

                entity.Property(e => e.ActiveId)
                    .HasMaxLength(15)
                    .HasColumnName("ActiveID");

                entity.Property(e => e.AmountWithoutGst)
                    .HasMaxLength(15)
                    .HasColumnName("AmountWithoutGST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CollectiveContractAccountNo)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.Property(e => e.CollectiveInvoiceNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.ContractAccountNo)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentCharge)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrentReading)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EbulkPaymentId).HasColumnName("EBulkPaymentID");

                entity.Property(e => e.Gstamount)
                    .HasMaxLength(15)
                    .HasColumnName("GSTAmount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceDate).HasMaxLength(10);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.IsPaymentNotificationSent).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastAmountPaid)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastBillNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.LastBillPaid).HasMaxLength(10);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OutstandingAmount)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentDueDate).HasColumnType("datetime");

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.ReadingDate).HasMaxLength(10);

                entity.Property(e => e.ReadingType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.Reference)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.ReturnCode).HasMaxLength(2);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.TariffCode)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TariffDescription)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TaxBasedAmount)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TnbreferenceNo)
                    .HasMaxLength(50)
                    .HasColumnName("TNBReferenceNo");

                entity.Property(e => e.TotalAmountPayable)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BulkPaymentTrace>(entity =>
            {
                entity.HasKey(e => e.BulkTraceId);

                entity.ToTable("BulkPaymentTrace");

                entity.Property(e => e.BulkTraceId)
                    .ValueGeneratedNever()
                    .HasColumnName("BulkTraceID");

                entity.Property(e => e.AccountNo).HasMaxLength(14);

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.BankCode).HasMaxLength(3);

                entity.Property(e => e.CardTransType).HasMaxLength(50);

                entity.Property(e => e.ChequeNo).HasMaxLength(20);

                entity.Property(e => e.ChequeType).HasMaxLength(1);

                entity.Property(e => e.CollAccountNo).HasMaxLength(14);

                entity.Property(e => e.CollInvoiceNo).HasMaxLength(14);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditCardNo).HasMaxLength(50);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LineNo).HasMaxLength(50);

                entity.Property(e => e.MerchantId).HasMaxLength(50);

                entity.Property(e => e.NextTryDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentAmount).HasMaxLength(50);

                entity.Property(e => e.PaymentChannel).HasMaxLength(2);

                entity.Property(e => e.PaymentDate).HasMaxLength(10);

                entity.Property(e => e.PaymentId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("PaymentID");

                entity.Property(e => e.PaymentMode).HasMaxLength(2);

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.ReturnCode).HasMaxLength(2);

                entity.Property(e => e.RevenueCode).HasMaxLength(2);

                entity.Property(e => e.SentDateTime).HasColumnType("datetime");

                entity.Property(e => e.TotalAmount).HasMaxLength(50);

                entity.Property(e => e.TotalItems).HasMaxLength(50);
            });

            modelBuilder.Entity<BulkPaymentUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BulkPaymentUser");

                entity.Property(e => e.CollectiveContractAccountNo)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__EBulkUser__UserI__48EFCE0F");
            });

            modelBuilder.Entity<BulkPrintingFile>(entity =>
            {
                entity.ToTable("BulkPrintingFile");

                entity.Property(e => e.BulkPrintingFileId)
                    .HasColumnName("BulkPrintingFileID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndExecuteDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartExecuteDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<BulkPrintingTrace>(entity =>
            {
                entity.ToTable("BulkPrintingTrace");

                entity.Property(e => e.BulkPrintingTraceId).HasColumnName("BulkPrintingTraceID");

                entity.Property(e => e.BulkPrintingFileId).HasColumnName("BulkPrintingFileID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Status).HasMaxLength(20);
            });

            modelBuilder.Entity<CallLog>(entity =>
            {
                entity.ToTable("CallLog");

                entity.Property(e => e.CallLogId).HasColumnName("CallLogID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CallLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CallLog_TrnUser");
            });

            modelBuilder.Entity<CareLineDashboardStatus>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK_CareLineDashboardStauts");

                entity.ToTable("CareLineDashboardStatus");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.AgingDescription).HasMaxLength(500);

                entity.Property(e => e.CarelineStatus).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.ModuleName).HasMaxLength(500);

                entity.Property(e => e.ModuleType).HasMaxLength(500);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<CareLineDashboardStatusLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CareLineDashboardStatusLog");

                entity.Property(e => e.AgingDescription).HasMaxLength(500);

                entity.Property(e => e.CarelineStatus).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.ModuleName).HasMaxLength(500);

                entity.Property(e => e.ModuleType).HasMaxLength(500);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ChangeLoadAcstoAcpbackUpDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChangeLoadACSToACPBackUp_Deleted");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicantType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.BpNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BP_No");

                entity.Property(e => e.ContactPersonBpNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ContactPerson_BP_No");

                entity.Property(e => e.ContactPersonName1).HasMaxLength(40);

                entity.Property(e => e.ContactPersonName2).HasMaxLength(40);

                entity.Property(e => e.ContactPersonPosition).HasMaxLength(20);

                entity.Property(e => e.ContractAccountNo).HasMaxLength(14);

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(240);

                entity.Property(e => e.FaxNo).HasMaxLength(30);

                entity.Property(e => e.FixedLineNo).HasMaxLength(30);

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadChangeType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LoadType).HasMaxLength(7);

                entity.Property(e => e.MailAddrTag).HasMaxLength(10);

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(10);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.MobileNo).HasMaxLength(30);

                entity.Property(e => e.MothersName).HasMaxLength(40);

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.NewPremiseTypeHeaderId).HasColumnName("NewPremiseTypeHeaderID");

                entity.Property(e => e.NextOfKinEmail).HasMaxLength(241);

                entity.Property(e => e.NextOfKinName1).HasMaxLength(40);

                entity.Property(e => e.NextOfKinName2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinPhoneNo).HasMaxLength(30);

                entity.Property(e => e.PaymentFlag).HasMaxLength(50);

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseCurrentMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(10);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.PremiseVoltageLevel).HasMaxLength(20);

                entity.Property(e => e.ReferenceNo).HasMaxLength(4000);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.RewiringId).HasColumnName("RewiringID");

                entity.Property(e => e.SnNo)
                    .HasMaxLength(20)
                    .HasColumnName("SN_No");

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TariffRate).HasMaxLength(20);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ChangeLoadFavApplication>(entity =>
            {
                entity.HasKey(e => e.FavAppId)
                    .HasName("PK_ChangeLoadFavApplication_FavAppID");

                entity.ToTable("ChangeLoadFavApplication");

                entity.HasIndex(e => new { e.UserId, e.RoleId, e.IsDeleted }, "IX_ChangeLoadFavApplication_Filter");

                entity.Property(e => e.FavAppId)
                    .HasColumnName("FavAppID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BackendAppId).HasColumnName("BackendAppID");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ChangeProductFavApplication>(entity =>
            {
                entity.HasKey(e => e.FavAppId)
                    .HasName("PK_ChangeProductFavApplication_FavAppID");

                entity.ToTable("ChangeProductFavApplication");

                entity.HasIndex(e => new { e.UserId, e.RoleId, e.IsDeleted }, "IX_ChangeProductFavApplication_Filter");

                entity.Property(e => e.FavAppId)
                    .HasColumnName("FavAppID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BackendAppId).HasColumnName("BackendAppID");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ChangeTariffMapping>(entity =>
            {
                entity.HasKey(e => e.TariffId)
                    .HasName("PK__ChangeTa__EBAF9DB3645DAFF1");

                entity.ToTable("ChangeTariffMapping");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('system')");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('system')");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SchemeType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TariffCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Tariff_Code");

                entity.Property(e => e.TariffDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Tariff_Description");

                entity.Property(e => e.TariffSystemDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Tariff_SystemDescription");

                entity.Property(e => e.VoltageLevel)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChannelSecurity>(entity =>
            {
                entity.ToTable("ChannelSecurity");

                entity.Property(e => e.ChannelSecurityId)
                    .HasColumnName("ChannelSecurityID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ChannelKey)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EncryptionKey)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChannelSecurityMemOptimized>(entity =>
            {
                entity.HasKey(e => e.ChannelSecurityId)
                    .IsClustered(false);

                entity.ToTable("ChannelSecurityMemOptimized");

                entity.Property(e => e.ChannelSecurityId)
                    .HasColumnName("ChannelSecurityID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ChannelKey)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EncryptionKey)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShortFormCode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_State_StateID_City_StateID");
            });

            modelBuilder.Entity<Coaapplication>(entity =>
            {
                entity.HasKey(e => e.Coaid);

                entity.ToTable("COAApplication");

                entity.HasIndex(e => e.CreatedBy, "IX_COAApplication_CreatedBy");

                entity.HasIndex(e => e.LastModifiedDate, "IX_COA_LastModifiedDate");

                entity.Property(e => e.Coaid).HasColumnName("COAID");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.AlternateBpnumber)
                    .HasMaxLength(40)
                    .HasColumnName("AlternateBPNumber");

                entity.Property(e => e.ApplicationModuleId)
                    .HasColumnName("ApplicationModuleID")
                    .HasDefaultValueSql("((101006))");

                entity.Property(e => e.BankAccount).HasMaxLength(40);

                entity.Property(e => e.BankName).HasMaxLength(40);

                entity.Property(e => e.Bpnumber)
                    .HasMaxLength(40)
                    .HasColumnName("BPNumber");

                entity.Property(e => e.ContactNumber).HasMaxLength(15);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DisconnectDate).HasColumnType("datetime");

                entity.Property(e => e.DisconnectTime).HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(241);

                entity.Property(e => e.GroupPaymentId).HasColumnName("GroupPaymentID");

                entity.Property(e => e.HousePhoneNumber).HasMaxLength(20);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.IsAlternateRefundMethod).HasColumnName("isAlternateRefundMethod");

                entity.Property(e => e.IsOwnStaying).HasColumnName("isOwnStaying");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(40);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(10);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.Name1).HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.OwnerId)
                    .HasMaxLength(40)
                    .HasColumnName("OwnerID");

                entity.Property(e => e.OwnerIdentificationTypeId).HasColumnName("OwnerIdentificationTypeID");

                entity.Property(e => e.PaymentType).HasMaxLength(50);

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(50);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([COAID],'COA-000-000-0000'))", false);

                entity.Property(e => e.RefundMethod).HasMaxLength(50);

                entity.Property(e => e.RefundName1).HasMaxLength(40);

                entity.Property(e => e.RefundName2).HasMaxLength(40);

                entity.Property(e => e.SrNo)
                    .HasMaxLength(40)
                    .HasColumnName("SR_No");

                entity.Property(e => e.SrapplicationDetail).HasColumnName("SRApplicationDetail");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TransferDepositCaNo)
                    .HasMaxLength(14)
                    .HasColumnName("TransferDeposit_CA_NO");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<CoaapplicationStatus>(entity =>
            {
                entity.HasKey(e => e.ApplicationStatusId);

                entity.ToTable("COAApplicationStatus");

                entity.Property(e => e.ApplicationStatusId).HasColumnName("ApplicationStatusID");

                entity.Property(e => e.Coaid).HasColumnName("COAID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DisplayText).HasMaxLength(30);

                entity.Property(e => e.StatusCode).HasMaxLength(10);

                entity.Property(e => e.StatusDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusFor)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusText).HasMaxLength(30);

                entity.HasOne(d => d.Coa)
                    .WithMany(p => p.CoaapplicationStatuses)
                    .HasForeignKey(d => d.Coaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COAApplicationStatus_COAApplication");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.CoaapplicationStatuses)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_COAApplicationStatus_ApplicationStatus");
            });

            modelBuilder.Entity<Coaattachment>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.Coaid });

                entity.ToTable("COAAttachment");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.Coaid).HasColumnName("COAID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileType).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Coa)
                    .WithMany(p => p.Coaattachments)
                    .HasForeignKey(d => d.Coaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COAAttachment_COAApplication");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.Coaattachments)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_COAAttachment_ApplicationFileUpload");
            });

            modelBuilder.Entity<CoafavApplication>(entity =>
            {
                entity.HasKey(e => e.FavAppId)
                    .HasName("PK_COAFavApplication_FavAppID");

                entity.ToTable("COAFavApplication");

                entity.HasIndex(e => new { e.UserId, e.RoleId, e.IsDeleted }, "IX_COAFavApplication_Filter");

                entity.Property(e => e.FavAppId)
                    .HasColumnName("FavAppID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BackendAppId).HasColumnName("BackendAppID");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<CoastatusLog>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("COAStatusLog");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Coaid).HasColumnName("COAID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<Contractor>(entity =>
            {
                entity.ToTable("Contractor");

                entity.HasIndex(e => new { e.Rocno, e.IsDeleted }, "IX_Contractor_ROCNo_IsDeleted");

                entity.HasIndex(e => new { e.UserId, e.IsDeleted }, "IX_Contractor_UserID_IsDeleted");

                entity.Property(e => e.ContractorId)
                    .HasColumnName("ContractorID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ContactPersonEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonOtherPhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonPhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContractorRating).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OfficeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rocno)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ROCNo");

                entity.Property(e => e.StcontractorId).HasColumnName("STContractorID");

                entity.HasOne(d => d.Stcontractor)
                    .WithMany(p => p.Contractors)
                    .HasForeignKey(d => d.StcontractorId)
                    .HasConstraintName("FK_Contractor_STContractor");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Contractors)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_TrnUser_UserID_Contractor_UserID");
            });

            modelBuilder.Entity<ConvertedRoleUser>(entity =>
            {
                entity.ToTable("ConvertedRoleUser");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Cotapplication>(entity =>
            {
                entity.HasKey(e => e.Cotid);

                entity.ToTable("COTApplication");

                entity.HasIndex(e => e.ApplicationModuleId, "IX_COTApplication_ApplicationModuleID");

                entity.HasIndex(e => e.ExistingOwnerId, "IX_COTApplication_ExistingOwnerID");

                entity.HasIndex(e => e.IsDeleted, "IX_COTApplication_IsDeleted");

                entity.HasIndex(e => e.RequestReasonId, "IX_COTApplication_RequestReasonID");

                entity.HasIndex(e => e.SrNo, "IX_COTApplication_SR_No");

                entity.HasIndex(e => e.StatusId, "IX_COTApplication_StatusID");

                entity.HasIndex(e => e.UserId, "IX_COTApplication_UserID");

                entity.HasIndex(e => e.LastModifiedDate, "IX_COT_LastModifiedDate");

                entity.Property(e => e.Cotid).HasColumnName("COTID");

                entity.Property(e => e.AccountClass).HasMaxLength(10);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.AlternateBpnumber)
                    .HasMaxLength(40)
                    .HasColumnName("AlternateBPNumber");

                entity.Property(e => e.ApplicantType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationModuleId)
                    .HasColumnName("ApplicationModuleID")
                    .HasDefaultValueSql("((101005))");

                entity.Property(e => e.BillingEmail).HasMaxLength(241);

                entity.Property(e => e.BpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BP_No");

                entity.Property(e => e.ContactPersonName1).HasMaxLength(40);

                entity.Property(e => e.ContactPersonName2).HasMaxLength(40);

                entity.Property(e => e.ContactPersonPosition).HasMaxLength(20);

                entity.Property(e => e.ContractAccountNo).HasMaxLength(14);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DisconnetDate).HasColumnType("date");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(240);

                entity.Property(e => e.ExistingContractAccountNo).HasMaxLength(14);

                entity.Property(e => e.ExistingOwnerId).HasColumnName("ExistingOwnerID");

                entity.Property(e => e.ExistingOwnerName1).HasMaxLength(40);

                entity.Property(e => e.ExistingOwnerName2).HasMaxLength(40);

                entity.Property(e => e.FaxNo).HasMaxLength(30);

                entity.Property(e => e.FixedLineNo).HasMaxLength(30);

                entity.Property(e => e.GivenTitleId).HasColumnName("GivenTitleID");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(20)
                    .HasColumnName("GSTNo");

                entity.Property(e => e.HousePhoneNumber).HasMaxLength(20);

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.IsAlternateRefundMethod).HasColumnName("isAlternateRefundMethod");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LockStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MaEducation).HasColumnName("MA_Education");

                entity.Property(e => e.MaIncome).HasColumnName("MA_Income");

                entity.Property(e => e.MaOccupation).HasColumnName("MA_Occupation");

                entity.Property(e => e.MaPaymentChannel).HasColumnName("MA_PaymentChannel");

                entity.Property(e => e.MaPaymentMethod).HasColumnName("MA_PaymentMethod");

                entity.Property(e => e.MaRace).HasColumnName("MA_Race");

                entity.Property(e => e.MaReligion).HasColumnName("MA_Religion");

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(10);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.MeterBoardAccessible).HasDefaultValueSql("((0))");

                entity.Property(e => e.MobileNo).HasMaxLength(30);

                entity.Property(e => e.MothersName).HasMaxLength(40);

                entity.Property(e => e.Name1).HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinEmail).HasMaxLength(241);

                entity.Property(e => e.NextOfKinName1).HasMaxLength(40);

                entity.Property(e => e.NextOfKinName2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinPhoneNo).HasMaxLength(30);

                entity.Property(e => e.OwnerContactNo).HasMaxLength(30);

                entity.Property(e => e.OwnerEmail).HasMaxLength(241);

                entity.Property(e => e.OwnerId)
                    .HasMaxLength(20)
                    .HasColumnName("OwnerID");

                entity.Property(e => e.OwnerIdentificationTypeId).HasColumnName("OwnerIdentificationTypeID");

                entity.Property(e => e.OwnerMailArea).HasMaxLength(40);

                entity.Property(e => e.OwnerMailBuilding).HasMaxLength(40);

                entity.Property(e => e.OwnerMailCity).HasMaxLength(40);

                entity.Property(e => e.OwnerMailHouseNo).HasMaxLength(10);

                entity.Property(e => e.OwnerMailPostalCode).HasMaxLength(10);

                entity.Property(e => e.OwnerMailState).HasMaxLength(20);

                entity.Property(e => e.OwnerMailStreet).HasMaxLength(60);

                entity.Property(e => e.OwnerMailType).HasMaxLength(10);

                entity.Property(e => e.OwnerMailUnitNo).HasMaxLength(10);

                entity.Property(e => e.PaymentFlag).HasMaxLength(50);

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(20);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.ProcessBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([COTID],'COT-000-000-0000'))", false);

                entity.Property(e => e.RefundBankAccount).HasMaxLength(20);

                entity.Property(e => e.RefundBankId).HasColumnName("RefundBankID");

                entity.Property(e => e.RefundEmail).HasMaxLength(241);

                entity.Property(e => e.RefundMethod).HasMaxLength(50);

                entity.Property(e => e.RefundMobileNumber).HasMaxLength(20);

                entity.Property(e => e.RefundName1).HasMaxLength(40);

                entity.Property(e => e.RefundName2).HasMaxLength(40);

                entity.Property(e => e.RegisterGroup).HasMaxLength(40);

                entity.Property(e => e.RejectReason).HasMaxLength(255);

                entity.Property(e => e.RequestReasonId)
                    .HasColumnName("RequestReasonID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.SdexemptionFlag).HasColumnName("SDExemptionFlag");

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.SrapplicationDetail).HasColumnName("SRApplicationDetail");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TransferDepositCaNo)
                    .HasMaxLength(14)
                    .HasColumnName("TransferDeposit_CA_NO");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Cotapplications)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COTApplication_ApplicationStatus");
            });

            modelBuilder.Entity<CotapplicationStatus>(entity =>
            {
                entity.HasKey(e => e.ApplicationStatusId);

                entity.ToTable("COTApplicationStatus");

                entity.Property(e => e.ApplicationStatusId).HasColumnName("ApplicationStatusID");

                entity.Property(e => e.Cotid).HasColumnName("COTID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DisplayText).HasMaxLength(30);

                entity.Property(e => e.StatusCode).HasMaxLength(10);

                entity.Property(e => e.StatusDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusFor)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusText).HasMaxLength(30);

                entity.HasOne(d => d.Cot)
                    .WithMany(p => p.CotapplicationStatuses)
                    .HasForeignKey(d => d.Cotid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COTApplicationStatus_COTApplication");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.CotapplicationStatuses)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_COTApplicationStatus_ApplicationStatus");
            });

            modelBuilder.Entity<Cotattachment>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.Cotid });

                entity.ToTable("COTAttachment");

                entity.HasIndex(e => e.UploadedBy, "IX_COTAttachment");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.Cotid).HasColumnName("COTID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UploadedBy)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Cot)
                    .WithMany(p => p.Cotattachments)
                    .HasForeignKey(d => d.Cotid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COTAttachment_COTApplication");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.Cotattachments)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_COTAttachment_ApplicationFileUpload");
            });

            modelBuilder.Entity<CotcallLog>(entity =>
            {
                entity.ToTable("COTCallLog");

                entity.Property(e => e.CotcallLogId).HasColumnName("COTCallLogID");

                entity.Property(e => e.Cotid).HasColumnName("COTID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Cot)
                    .WithMany(p => p.CotcallLogs)
                    .HasForeignKey(d => d.Cotid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COTCallLog_COTApplication");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CotcallLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COTCallLog_TrnUser");
            });

            modelBuilder.Entity<CotcancelInformation>(entity =>
            {
                entity.HasKey(e => e.CotcancelInfoId);

                entity.ToTable("COTCancelInformation");

                entity.Property(e => e.CotcancelInfoId).HasColumnName("COTCancelInfoID");

                entity.Property(e => e.CancelReasons)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CarelineUserId).HasColumnName("CarelineUserID");

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.Cotid).HasColumnName("COTID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExistingOwnerUserId).HasColumnName("ExistingOwnerUserID");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewOwnerUserId).HasColumnName("NewOwnerUserID");

                entity.HasOne(d => d.CarelineUser)
                    .WithMany(p => p.CotcancelInformationCarelineUsers)
                    .HasForeignKey(d => d.CarelineUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COTCancelInformation_TrnUserCarelineUserID");

                entity.HasOne(d => d.Cot)
                    .WithMany(p => p.CotcancelInformations)
                    .HasForeignKey(d => d.Cotid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COTCancelInformation_COT");

                entity.HasOne(d => d.ExistingOwnerUser)
                    .WithMany(p => p.CotcancelInformationExistingOwnerUsers)
                    .HasForeignKey(d => d.ExistingOwnerUserId)
                    .HasConstraintName("FK_COTCancelInformation_TrnUserExistingOwnerUserID");

                entity.HasOne(d => d.NewOwnerUser)
                    .WithMany(p => p.CotcancelInformationNewOwnerUsers)
                    .HasForeignKey(d => d.NewOwnerUserId)
                    .HasConstraintName("FK_COTCancelInformation_TrnUserNewOwnerUserID");
            });

            modelBuilder.Entity<CotexistingOwnerLog>(entity =>
            {
                entity.ToTable("COTExistingOwnerLog");

                entity.Property(e => e.CotexistingOwnerLogId)
                    .ValueGeneratedNever()
                    .HasColumnName("COTExistingOwnerLogID");

                entity.Property(e => e.Attachments).HasMaxLength(500);

                entity.Property(e => e.Cotid).HasColumnName("COTID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DisconnectDate).HasColumnType("datetime");

                entity.Property(e => e.ExistingOwnerId).HasColumnName("ExistingOwnerID");

                entity.Property(e => e.HousePhoneNumber).HasMaxLength(20);

                entity.Property(e => e.IsAlternateRefundMethod).HasColumnName("isAlternateRefundMethod");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OwnerIdentificationTypeId).HasColumnName("OwnerIdentificationTypeID");

                entity.Property(e => e.OwnerMailArea).HasMaxLength(40);

                entity.Property(e => e.OwnerMailBuilding).HasMaxLength(41);

                entity.Property(e => e.OwnerMailCity).HasMaxLength(40);

                entity.Property(e => e.OwnerMailHouseNo).HasMaxLength(10);

                entity.Property(e => e.OwnerMailPostalCode).HasMaxLength(10);

                entity.Property(e => e.OwnerMailState).HasMaxLength(20);

                entity.Property(e => e.OwnerMailStreet).HasMaxLength(60);

                entity.Property(e => e.OwnerMailUnitNo).HasMaxLength(10);

                entity.Property(e => e.Ownerid)
                    .HasMaxLength(20)
                    .HasColumnName("OWNERID");

                entity.Property(e => e.RefundBankAccount).HasMaxLength(20);

                entity.Property(e => e.RefundBankId).HasColumnName("RefundBankID");

                entity.Property(e => e.RefundEmail).HasMaxLength(241);

                entity.Property(e => e.RefundMethod).HasMaxLength(50);

                entity.Property(e => e.RefundMobileNumber).HasMaxLength(20);

                entity.Property(e => e.RefundName1).HasMaxLength(40);

                entity.Property(e => e.RefundName2).HasMaxLength(40);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TransferDepositCaNo)
                    .HasMaxLength(14)
                    .HasColumnName("TransferDeposit_CA_NO");
            });

            modelBuilder.Entity<CotfavApplication>(entity =>
            {
                entity.HasKey(e => e.FavAppId)
                    .HasName("PK_COTFavApplication_FavAppID");

                entity.ToTable("COTFavApplication");

                entity.HasIndex(e => new { e.UserId, e.RoleId, e.IsDeleted }, "IX_COTFavApplication_Filter");

                entity.Property(e => e.FavAppId)
                    .HasColumnName("FavAppID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BackendAppId).HasColumnName("BackendAppID");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<CotstatusLog>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_COTStatusLog_Guid");

                entity.ToTable("COTStatusLog");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CancelledReason).HasMaxLength(50);

                entity.Property(e => e.Cotid).HasColumnName("COTID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SnStatus).HasColumnName("SN_Status");

                entity.Property(e => e.SrStatus).HasColumnName("SR_Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.CotstatusLogs)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_COTStatusLog_ApplicationStatus");
            });

            modelBuilder.Entity<CotsubmitSystemMessage>(entity =>
            {
                entity.HasKey(e => e.CotsubmitSysMsgId)
                    .HasName("PK_COTSubmitSystemMessage_COTSubmitSysMsgID");

                entity.ToTable("COTSubmitSystemMessage");

                entity.Property(e => e.CotsubmitSysMsgId).HasColumnName("COTSubmitSysMsgID");

                entity.Property(e => e.Cotid).HasColumnName("COTID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.MessageType).HasMaxLength(20);

                entity.HasOne(d => d.Cot)
                    .WithMany(p => p.CotsubmitSystemMessages)
                    .HasForeignKey(d => d.Cotid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COTSubmitSystemMessage_COTID");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ctratio>(entity =>
            {
                entity.HasKey(e => e.Ctid)
                    .HasName("PK__CTRatio__F4AA1BE09150E5C7");

                entity.ToTable("CTRatio");

                entity.Property(e => e.Ctid).HasColumnName("CTID");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.MaxValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MinValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RatioValue).HasMaxLength(50);
            });

            modelBuilder.Entity<Developer>(entity =>
            {
                entity.ToTable("Developer");

                entity.Property(e => e.DeveloperId)
                    .HasColumnName("DeveloperID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IdentificationNo).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Developers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_TrnUser_UserID_Developer_UserID");
            });

            modelBuilder.Entity<DeviceLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK_DeviceLcoation");

                entity.ToTable("DeviceLocation");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DocAttachment>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("DocAttachment");

                entity.Property(e => e.FileId)
                    .ValueGeneratedNever()
                    .HasColumnName("FileID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.FileType).HasMaxLength(50);

                entity.Property(e => e.LastModfiiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("Document");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<ElectricitySupplyType>(entity =>
            {
                entity.HasKey(e => e.SupplyTypeId);

                entity.ToTable("ElectricitySupplyType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SupplyType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpressPaymentLog>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK_ExpressPaymentLog_RecordID");

                entity.ToTable("ExpressPaymentLog");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Browser).HasMaxLength(50);

                entity.Property(e => e.ContractAccountNo)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(100)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceNo)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.TransactionStatus).HasMaxLength(10);
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback");

                entity.HasIndex(e => new { e.UserId, e.IsDeleted, e.StatusId }, "idx_ms_sa_get_application");

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");

                entity.Property(e => e.ApplicationModuleId)
                    .HasColumnName("ApplicationModuleID")
                    .HasDefaultValueSql("((101007))");

                entity.Property(e => e.ContactNo).HasMaxLength(20);

                entity.Property(e => e.ContactNo2).HasMaxLength(20);

                entity.Property(e => e.ContractAccountNo)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.GslCategory)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("GSL_Category")
                    .IsFixedLength(true);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nric)
                    .HasMaxLength(20)
                    .HasColumnName("NRIC");

                entity.Property(e => e.OtherId)
                    .HasMaxLength(20)
                    .HasColumnName("OtherID");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(case when [TYPE]='ZCOM' then format([FeedbackID],'GC-000-000-0000') else format([FeedbackID],'RB-000-000-0000') end)", false);

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.SrType)
                    .HasMaxLength(10)
                    .HasColumnName("SR_Type");

                entity.Property(e => e.SrapplicationDetail).HasColumnName("SRApplicationDetail");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Subject).HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<FeedbackAttachment>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.FeedbackId });

                entity.ToTable("FeedbackAttachment");

                entity.HasIndex(e => e.FeedbackId, "IX_FeedbackAttachment_FeedbackID");

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileGroupId)
                    .HasMaxLength(20)
                    .HasColumnName("FileGroupID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Feedback)
                    .WithMany(p => p.FeedbackAttachments)
                    .HasForeignKey(d => d.FeedbackId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeedbackAttachment_Feedback");
            });

            modelBuilder.Entity<FeedbackItem>(entity =>
            {
                entity.HasKey(e => new { e.RequestId, e.FeedbackId })
                    .HasName("PK_FeedbackItem_1");

                entity.ToTable("FeedbackItem");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Feedback)
                    .WithMany(p => p.FeedbackItems)
                    .HasForeignKey(d => d.FeedbackId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeedbackItem_Feedback");
            });

            modelBuilder.Entity<FeedbackStatusLog>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("FeedbackStatusLog");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<FeedbackUpdatePersonalDetail>(entity =>
            {
                entity.HasKey(e => e.UpdatePersonalDetailsId);

                entity.Property(e => e.UpdatePersonalDetailsId).ValueGeneratedNever();

                entity.Property(e => e.AccOwnerName).HasMaxLength(50);

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");

                entity.Property(e => e.MailAddressCity)
                    .HasMaxLength(50)
                    .HasColumnName("MailAddress_City");

                entity.Property(e => e.MailAddressPostcode)
                    .HasMaxLength(50)
                    .HasColumnName("MailAddress_Postcode");

                entity.Property(e => e.MailAddressState)
                    .HasMaxLength(50)
                    .HasColumnName("MailAddress_State");

                entity.Property(e => e.MailAddressStreetAddress)
                    .HasMaxLength(50)
                    .HasColumnName("MailAddress_StreetAddress");

                entity.Property(e => e.NewEmailAddress).HasMaxLength(50);

                entity.Property(e => e.NewMobileNo).HasMaxLength(20);

                entity.Property(e => e.NewNric)
                    .HasMaxLength(20)
                    .HasColumnName("NewNRIC");

                entity.Property(e => e.PremiseAddressCity)
                    .HasMaxLength(50)
                    .HasColumnName("PremiseAddress_City");

                entity.Property(e => e.PremiseAddressPostcode)
                    .HasMaxLength(50)
                    .HasColumnName("PremiseAddress_Postcode");

                entity.Property(e => e.PremiseAddressState)
                    .HasMaxLength(50)
                    .HasColumnName("PremiseAddress_State");

                entity.Property(e => e.PremiseAddressStreetAddress)
                    .HasMaxLength(50)
                    .HasColumnName("PremiseAddress_StreetAddress");

                entity.Property(e => e.Relationship).HasMaxLength(50);

                entity.HasOne(d => d.Feedback)
                    .WithMany(p => p.FeedbackUpdatePersonalDetails)
                    .HasForeignKey(d => d.FeedbackId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeedbackUpdatePersonalDetails_Feedback");
            });

            modelBuilder.Entity<FileDownload>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .IsClustered(false);

                entity.ToTable("FileDownload");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.CreatedBy).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileButtonDescription).HasMaxLength(200);

                entity.Property(e => e.FileGroupName).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.FileType).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FileDownloadBackup17Dec2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FileDownloadBackup17Dec2020");

                entity.Property(e => e.CreatedBy).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileButtonDescription).HasMaxLength(200);

                entity.Property(e => e.FileGroupName).HasMaxLength(50);

                entity.Property(e => e.FileId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FileID");

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.FileType).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FileDownloadBak08012021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FileDownload_bak08012021");

                entity.Property(e => e.CreatedBy).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileButtonDescription).HasMaxLength(200);

                entity.Property(e => e.FileGroupName).HasMaxLength(50);

                entity.Property(e => e.FileId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FileID");

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.FileType).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FileUploadGroup>(entity =>
            {
                entity.HasKey(e => new { e.FileGroupName, e.FileCode });

                entity.ToTable("FileUploadGroup");

                entity.Property(e => e.FileGroupName).HasMaxLength(100);

                entity.Property(e => e.FileCode).HasMaxLength(100);

                entity.Property(e => e.FileGroupId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FileGroupID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FileSize).HasColumnType("decimal(25, 0)");

                entity.Property(e => e.FileType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PopupUrl).HasMaxLength(200);

                entity.Property(e => e.RestrictedFileName).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sequence).HasDefaultValueSql("((1))");

                entity.Property(e => e.SizeType).HasMaxLength(10);
            });

            modelBuilder.Entity<FileUploadGroupBackup8Nov19>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FileUploadGroupBackup8Nov19");

                entity.Property(e => e.FileCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FileGroupId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FileGroupID");

                entity.Property(e => e.FileGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FileSize).HasColumnType("decimal(25, 0)");

                entity.Property(e => e.FileType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PopupUrl).HasMaxLength(200);

                entity.Property(e => e.SizeType).HasMaxLength(10);
            });

            modelBuilder.Entity<GivenTitle>(entity =>
            {
                entity.HasKey(e => e.TitleId);

                entity.ToTable("GivenTitle");

                entity.Property(e => e.TitleId)
                    .ValueGeneratedNever()
                    .HasColumnName("TitleID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceCode).HasMaxLength(50);

                entity.Property(e => e.TitleDesc).HasMaxLength(50);
            });

            modelBuilder.Entity<GreenTariff>(entity =>
            {
                entity.ToTable("GreenTariff");

                entity.Property(e => e.GreenTariffId).HasColumnName("GreenTariffID");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.BpNo)
                    .HasMaxLength(15)
                    .HasColumnName("BP_No");

                entity.Property(e => e.ContactPersonBpNo)
                    .HasMaxLength(15)
                    .HasColumnName("ContactPerson_BP_No");

                entity.Property(e => e.ContactPersonEmail).HasMaxLength(240);

                entity.Property(e => e.ContactPersonMobileNo).HasMaxLength(15);

                entity.Property(e => e.ContactPersonName1).HasMaxLength(40);

                entity.Property(e => e.ContactPersonName2).HasMaxLength(40);

                entity.Property(e => e.ContractAccountNo).HasMaxLength(14);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(240);

                entity.Property(e => e.GreenTariffEntryMode)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.Name1).HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(12);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([GreenTariffID],'GT-000-000-0000'))", false);

                entity.Property(e => e.SnNo)
                    .HasMaxLength(20)
                    .HasColumnName("SN_No");

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.SrapplicationDetail).HasColumnName("SRApplicationDetail");

                entity.Property(e => e.StationCode).HasMaxLength(4);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VoltageLevel).HasMaxLength(10);
            });

            modelBuilder.Entity<GreenTariffAttachment>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_GreenTariffAttachment_FileID");

                entity.ToTable("GreenTariffAttachment");

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.GreenTariffId).HasColumnName("GreenTariffID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UploadedBy)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.GreenTariff)
                    .WithMany(p => p.GreenTariffAttachments)
                    .HasForeignKey(d => d.GreenTariffId)
                    .HasConstraintName("FK_GreenTariffAttachment_GreenTariff");
            });

            modelBuilder.Entity<GreenTariffFavApplication>(entity =>
            {
                entity.HasKey(e => e.FavAppId)
                    .HasName("PK_GreenTariffFavApplication_FavAppID");

                entity.ToTable("GreenTariffFavApplication");

                entity.HasIndex(e => new { e.UserId, e.RoleId, e.IsDeleted }, "IX_GreenTariffFavApplication_Filter");

                entity.Property(e => e.FavAppId)
                    .HasColumnName("FavAppID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BackendAppId).HasColumnName("BackendAppID");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<GreenTariffStatusLog>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("GreenTariffStatusLog");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GreenTariffId).HasColumnName("GreenTariffID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<GslfavApplication>(entity =>
            {
                entity.HasKey(e => e.FavAppId)
                    .HasName("PK_GSLFavApplication_FavAppID");

                entity.ToTable("GSLFavApplication");

                entity.HasIndex(e => new { e.UserId, e.RoleId, e.IsDeleted }, "IX_GSLFavApplication_Filter");

                entity.Property(e => e.FavAppId)
                    .HasColumnName("FavAppID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BackendAppId).HasColumnName("BackendAppID");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<HelpFormFavApplication>(entity =>
            {
                entity.HasKey(e => e.FavAppId)
                    .HasName("PK_HelpFormFavApplication_FavAppID");

                entity.ToTable("HelpFormFavApplication");

                entity.HasIndex(e => new { e.UserId, e.RoleId, e.IsDeleted }, "IX_HelpFormFavApplication_Filter");

                entity.Property(e => e.FavAppId)
                    .HasColumnName("FavAppID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BackendAppId).HasColumnName("BackendAppID");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<HerTarget>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HER_TARGET");

                entity.Property(e => e.Cano)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANo");

                entity.Property(e => e.Legacy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IdentificationType>(entity =>
            {
                entity.ToTable("IdentificationType");

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<InBoundWebServiceLog>(entity =>
            {
                entity.ToTable("InBoundWebServiceLog");

                entity.Property(e => e.InBoundWebServiceLogId).HasColumnName("InBoundWebServiceLogID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IpAddress).HasMaxLength(25);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MethodName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Individual>(entity =>
            {
                entity.ToTable("Individual");

                entity.HasIndex(e => e.UserId, "IX_Individual_UserID");

                entity.Property(e => e.IndividualId)
                    .HasColumnName("IndividualID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CommId).HasColumnName("CommID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.IdentificationNo).HasMaxLength(50);

                entity.Property(e => e.KinContactNo).HasMaxLength(15);

                entity.Property(e => e.KinName).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MaidenName).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Individuals)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_IndividualUserID");
            });

            modelBuilder.Entity<LnkUserRole>(entity =>
            {
                entity.HasKey(e => e.UserRoleId)
                    .HasName("pk_user_role_id");

                entity.ToTable("LnkUserRole");

                entity.HasIndex(e => new { e.RoleId, e.IsDeleted }, "IX_LnkUserRole_RoleID_IsDeleted");

                entity.HasIndex(e => new { e.UserId, e.IsDeleted }, "IX_LnkUserRole_UserID_IsDeleted");

                entity.Property(e => e.UserRoleId)
                    .HasColumnName("UserRoleID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleDescription).HasMaxLength(30);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(15);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.LnkUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_RoleID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LnkUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_UserID");
            });

            modelBuilder.Entity<LnkUserRoleBackup8Nov19>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LnkUserRoleBackup8Nov19");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleDescription).HasMaxLength(30);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(15);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            });

            modelBuilder.Entity<LnkUserRoleBackupDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LnkUserRoleBackup_Deleted");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleDescription).HasMaxLength(30);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(15);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            });

            modelBuilder.Entity<LnkUserRoleBackupForReadOnlyDeletion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LnkUserRoleBackupForReadOnlyDeletion");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleDescription).HasMaxLength(30);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(15);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            });

            modelBuilder.Entity<Lpc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LPC");

                entity.Property(e => e.Ca)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CA");
            });

            modelBuilder.Entity<MailQueue>(entity =>
            {
                entity.ToTable("MailQueue");

                entity.Property(e => e.MailQueueId)
                    .HasColumnName("MailQueueID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MailTo).IsRequired();

                entity.Property(e => e.SentDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MailQueueAttachment>(entity =>
            {
                entity.ToTable("MailQueueAttachment");

                entity.Property(e => e.MailQueueAttachmentId)
                    .HasColumnName("MailQueueAttachmentID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AttachmentBinary).IsRequired();

                entity.Property(e => e.AttachmentName).IsRequired();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MailQueueId).HasColumnName("MailQueueID");

                entity.HasOne(d => d.MailQueue)
                    .WithMany(p => p.MailQueueAttachments)
                    .HasForeignKey(d => d.MailQueueId)
                    .HasConstraintName("fk_MailQueueID");
            });

            modelBuilder.Entity<MailTemplate>(entity =>
            {
                entity.ToTable("MailTemplate");

                entity.Property(e => e.MailTemplateId).HasColumnName("MailTemplateID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TemplateBody).IsRequired();

                entity.Property(e => e.TemplateSubject).IsRequired();
            });

            modelBuilder.Entity<MailTemplateAttachment>(entity =>
            {
                entity.ToTable("MailTemplateAttachment");

                entity.Property(e => e.MailTemplateAttachmentId)
                    .HasColumnName("MailTemplateAttachmentID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AttachmentBinary).IsRequired();

                entity.Property(e => e.AttachmentName).IsRequired();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MailTemplateId).HasColumnName("MailTemplateID");

                entity.HasOne(d => d.MailTemplate)
                    .WithMany(p => p.MailTemplateAttachments)
                    .HasForeignKey(d => d.MailTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MailTemplateID");
            });

            modelBuilder.Entity<MailTemplateBackup8Nov19>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MailTemplateBackup8Nov19");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MailTemplateId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MailTemplateID");

                entity.Property(e => e.TemplateBody).IsRequired();

                entity.Property(e => e.TemplateSubject).IsRequired();
            });

            modelBuilder.Entity<MailTemplateBk202101020010>(entity =>
            {
                entity.HasKey(e => e.MailTemplateId)
                    .HasName("pk_MailTemplate_Bk20210102_0010_id");

                entity.ToTable("MailTemplate_Bk20210102_0010");

                entity.Property(e => e.MailTemplateId)
                    .ValueGeneratedNever()
                    .HasColumnName("MailTemplateID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TemplateBody).IsRequired();

                entity.Property(e => e.TemplateSubject).IsRequired();
            });

            modelBuilder.Entity<MailTemplateBk202101141043>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MailTemplate_Bk20210114_1043");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MailTemplateId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MailTemplateID");

                entity.Property(e => e.TemplateBody).IsRequired();

                entity.Property(e => e.TemplateSubject).IsRequired();
            });

            modelBuilder.Entity<MailTemplateBk202104201607>(entity =>
            {
                entity.HasKey(e => e.MailTemplateId)
                    .HasName("pk_MailTemplate_Bk20210420_1607_id");

                entity.ToTable("MailTemplate_Bk20210420_1607");

                entity.Property(e => e.MailTemplateId)
                    .ValueGeneratedNever()
                    .HasColumnName("MailTemplateID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TemplateBody).IsRequired();

                entity.Property(e => e.TemplateSubject).IsRequired();
            });

            modelBuilder.Entity<MailTrace>(entity =>
            {
                entity.ToTable("MailTrace");

                entity.HasIndex(e => e.CreatedDate, "IX_MailTrace_CreatedDate");

                entity.HasIndex(e => e.SentDateTime, "IX_MailTrace_SentDateTime");

                entity.Property(e => e.MailTraceId)
                    .HasColumnName("MailTraceID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MailFrom).IsRequired();

                entity.Property(e => e.MailTo).IsRequired();

                entity.Property(e => e.SentDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MailTraceAttachment>(entity =>
            {
                entity.ToTable("MailTraceAttachment");

                entity.Property(e => e.MailTraceAttachmentId)
                    .HasColumnName("MailTraceAttachmentID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AttachmentBinary).IsRequired();

                entity.Property(e => e.AttachmentName).IsRequired();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MailTraceId).HasColumnName("MailTraceID");

                entity.HasOne(d => d.MailTrace)
                    .WithMany(p => p.MailTraceAttachments)
                    .HasForeignKey(d => d.MailTraceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MailTraceID");
            });

            modelBuilder.Entity<MasterLookup>(entity =>
            {
                entity.HasKey(e => e.LookupId);

                entity.ToTable("MasterLookup");

                entity.HasIndex(e => new { e.Area, e.Lookup, e.Value }, "IX_MasterLookup");

                entity.HasIndex(e => e.Value, "IX_MasterLookup_Value");

                entity.Property(e => e.LookupId)
                    .ValueGeneratedNever()
                    .HasColumnName("LookupID");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lookup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Masterlookup20201228>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MASTERLOOKUP_20201228");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Lookup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LookupId).HasColumnName("LookupID");

                entity.Property(e => e.Rb)
                    .HasMaxLength(100)
                    .HasColumnName("RB");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Masterlookup20201229>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MASTERLOOKUP_20201229");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Lookup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LookupId).HasColumnName("LookupID");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MaxMoveIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MaxMoveIn");

                entity.Property(e => e.Erms).HasColumnName("ERMS");

                entity.Property(e => e.Ssp).HasColumnName("SSP");

                entity.Property(e => e.TnbProjectId)
                    .HasMaxLength(255)
                    .HasColumnName("TNB_ProjectID");
            });

            modelBuilder.Entity<Mddeclared>(entity =>
            {
                entity.HasKey(e => e.Mdid);

                entity.ToTable("MDDeclared");

                entity.Property(e => e.Mdid)
                    .ValueGeneratedNever()
                    .HasColumnName("MDID");

                entity.Property(e => e.MaterialDesc).HasMaxLength(250);

                entity.Property(e => e.Mdmax)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MDMax");

                entity.Property(e => e.Mdmin)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MDMin");

                entity.Property(e => e.MeterType).HasMaxLength(20);

                entity.Property(e => e.VoltageLevel).HasMaxLength(50);
            });

            modelBuilder.Entity<MerdekaIncentive>(entity =>
            {
                entity.ToTable("MerdekaIncentive");

                entity.Property(e => e.MerdekaIncentiveId).HasColumnName("MerdekaIncentiveID");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicantType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationModuleId)
                    .HasColumnName("ApplicationModuleID")
                    .HasDefaultValueSql("((101008))");

                entity.Property(e => e.BpNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BP_No");

                entity.Property(e => e.ContactPersonBpNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ContactPerson_BP_No");

                entity.Property(e => e.ContactPersonName1).HasMaxLength(40);

                entity.Property(e => e.ContactPersonName2).HasMaxLength(40);

                entity.Property(e => e.ContactPersonPosition).HasMaxLength(20);

                entity.Property(e => e.ContractAccountNo).HasMaxLength(14);

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(240);

                entity.Property(e => e.FaxNo).HasMaxLength(30);

                entity.Property(e => e.FixedLineNo).HasMaxLength(30);

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadChangeType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(10);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.MobileNo).HasMaxLength(30);

                entity.Property(e => e.MothersName).HasMaxLength(40);

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinEmail).HasMaxLength(241);

                entity.Property(e => e.NextOfKinName1).HasMaxLength(40);

                entity.Property(e => e.NextOfKinName2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinPhoneNo).HasMaxLength(30);

                entity.Property(e => e.PaymentFlag).HasMaxLength(50);

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(10);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([MerdekaIncentiveID],'MD-000-000-0000'))", false);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.SnNo)
                    .HasMaxLength(20)
                    .HasColumnName("SN_No");

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.SrapplicationDetail).HasColumnName("SRApplicationDetail");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.MerdekaIncentives)
                    .HasForeignKey(d => d.AccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MerdekaIncentive_AccountType");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MerdekaIncentives)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MerdekaIncentive_ApplicationStatus");
            });

            modelBuilder.Entity<MerdekaIncentiveAttachment>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.MerdekaIncentiveId });

                entity.ToTable("MerdekaIncentiveAttachment");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.MerdekaIncentiveId).HasColumnName("MerdekaIncentiveID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UploadedBy)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.File)
                    .WithMany(p => p.MerdekaIncentiveAttachments)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_MerdekaIncentiveAttachment_ApplicationFileUpload");

                entity.HasOne(d => d.MerdekaIncentive)
                    .WithMany(p => p.MerdekaIncentiveAttachments)
                    .HasForeignKey(d => d.MerdekaIncentiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MerdekaIncentiveAttachment_MerdekaIncentive");
            });

            modelBuilder.Entity<MerdekaIncentiveFavApplication>(entity =>
            {
                entity.HasKey(e => e.FavAppId)
                    .HasName("PK_MerdekaIncentiveFavApplication_FavAppID");

                entity.ToTable("MerdekaIncentiveFavApplication");

                entity.HasIndex(e => new { e.UserId, e.RoleId, e.IsDeleted }, "IX_MerdekaIncentiveFavApplication_Filter");

                entity.Property(e => e.FavAppId)
                    .HasColumnName("FavAppID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BackendAppId).HasColumnName("BackendAppID");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<MerdekaIncentiveStatusLog>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("MerdekaIncentiveStatusLog");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MerdekaIncentiveId).HasColumnName("MerdekaIncentiveID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<MigAccountNoMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigAccountNoMapping");

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.MigrationStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NewAcnumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NewACNumber");

                entity.Property(e => e.OldAcnumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OldACNumber");
            });

            modelBuilder.Entity<MigAccountNoMappingCleansed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigAccountNoMappingCleansed");

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.NewAcnumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NewACNumber");

                entity.Property(e => e.OldAcnumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OldACNumber");
            });

            modelBuilder.Entity<MigAccountNoMappingException>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigAccountNoMappingException");

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.ExceptionMsg).HasMaxLength(255);

                entity.Property(e => e.ExceptionType).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.NewAcnumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NewACNumber");

                entity.Property(e => e.OldAcnumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OldACNumber");
            });

            modelBuilder.Entity<MigActypeLookup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigACTypeLookup");

                entity.Property(e => e.EServiceDescription)
                    .HasMaxLength(100)
                    .HasColumnName("eServiceDescription");

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.SspaccountType)
                    .HasMaxLength(25)
                    .HasColumnName("SSPAccountType");

                entity.Property(e => e.SspaccountTypeId).HasColumnName("SSPAccountTypeID");
            });

            modelBuilder.Entity<MigBcrm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigBcrm");

                entity.Property(e => e.TnbProjectId)
                    .HasMaxLength(16)
                    .HasColumnName("TNB_ProjectID");
            });

            modelBuilder.Entity<MigConfiguration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigConfiguration");

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.SubArea).HasMaxLength(50);

                entity.Property(e => e.ValidCompareOperator).HasMaxLength(50);

                entity.Property(e => e.Value).HasMaxLength(100);
            });

            modelBuilder.Entity<MigContractorStaging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigContractorStaging");

                entity.Property(e => e.ContactPersonEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonOtherPhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonPhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.ContractorRating).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.OfficeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rocno)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ROCNo");

                entity.Property(e => e.StcontractorId).HasColumnName("STContractorID");
            });

            modelBuilder.Entity<MigDeveloperInvidualStaging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigDeveloperInvidualStaging");

                entity.Property(e => e.CommId).HasColumnName("CommID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdentificationNo).HasMaxLength(50);

                entity.Property(e => e.IndividualId).HasColumnName("IndividualID");

                entity.Property(e => e.KinContactNo).HasMaxLength(15);

                entity.Property(e => e.KinName).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.MaidenName).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<MigDeveloperTrnUserStaging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigDeveloperTrnUserStaging");

                entity.Property(e => e.ActivationExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(25);

                entity.Property(e => e.CommId).HasColumnName("CommID");

                entity.Property(e => e.Country).HasMaxLength(25);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.FixedLineNo).HasMaxLength(15);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdentificationNo).HasMaxLength(50);

                entity.Property(e => e.KinContactNo).HasMaxLength(15);

                entity.Property(e => e.KinName).HasMaxLength(50);

                entity.Property(e => e.LastLoginFromMobile).HasColumnType("datetime");

                entity.Property(e => e.LastLoginFromWeb).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.MaidenName).HasMaxLength(50);

                entity.Property(e => e.MailingAddr1).HasMaxLength(25);

                entity.Property(e => e.MailingAddr2).HasMaxLength(25);

                entity.Property(e => e.MailingAddr3).HasMaxLength(25);

                entity.Property(e => e.MailingAddrState).HasMaxLength(25);

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.RegistrationSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Salt).HasMaxLength(50);

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.SourceEncryptPassword).HasMaxLength(255);

                entity.Property(e => e.SourcePassword).HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserPassword).HasMaxLength(255);
            });

            modelBuilder.Entity<MigEcib>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TnbProjectId)
                    .HasMaxLength(16)
                    .HasColumnName("TNB_ProjectID");
            });

            modelBuilder.Entity<MigEservicesUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigEServicesUsers");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(255)
                    .HasColumnName("AccountID");

                entity.Property(e => e.AccountTypeId)
                    .HasMaxLength(255)
                    .HasColumnName("AccountTypeID");

                entity.Property(e => e.BatchNo).HasMaxLength(255);

                entity.Property(e => e.CustomerLoginId)
                    .HasMaxLength(255)
                    .HasColumnName("Customer login ID");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.GotIndividualRole).HasMaxLength(255);

                entity.Property(e => e.NewCano)
                    .HasMaxLength(255)
                    .HasColumnName("NewCANo");

                entity.Property(e => e.OldCano)
                    .HasMaxLength(255)
                    .HasColumnName("OldCANo");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<MigInvidualStaging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigInvidualStaging");

                entity.Property(e => e.CommId).HasColumnName("CommID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdentificationNo).HasMaxLength(50);

                entity.Property(e => e.IndividualId).HasColumnName("IndividualID");

                entity.Property(e => e.KinContactNo).HasMaxLength(15);

                entity.Property(e => e.KinName).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.MaidenName).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<MigNewConnectionStaging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigNewConnectionStaging");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicantType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.BpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BP_No");

                entity.Property(e => e.ContactPersonName1).HasMaxLength(40);

                entity.Property(e => e.ContactPersonName2).HasMaxLength(40);

                entity.Property(e => e.ContactPersonPosition).HasMaxLength(20);

                entity.Property(e => e.ContractAccountNo).HasMaxLength(14);

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(240);

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.FixedLineNo).HasMaxLength(15);

                entity.Property(e => e.GivenTitleId).HasColumnName("GivenTitleID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IdentificationNo).HasMaxLength(14);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.LoadType)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MaEducation).HasColumnName("MA_Education");

                entity.Property(e => e.MaIncome).HasColumnName("MA_Income");

                entity.Property(e => e.MaOccupation).HasColumnName("MA_Occupation");

                entity.Property(e => e.MaPaymentChannel).HasColumnName("MA_PaymentChannel");

                entity.Property(e => e.MaPaymentMethod).HasColumnName("MA_PaymentMethod");

                entity.Property(e => e.MaRace).HasColumnName("MA_Race");

                entity.Property(e => e.MaReligion).HasColumnName("MA_Religion");

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(10);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.MothersName).HasMaxLength(40);

                entity.Property(e => e.Name1).HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.NextOfKinEmail).HasMaxLength(240);

                entity.Property(e => e.NextOfKinName1).HasMaxLength(40);

                entity.Property(e => e.NextOfKinName2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinPhoneNo).HasMaxLength(15);

                entity.Property(e => e.ParcelActualId).HasColumnName("ParcelActualID");

                entity.Property(e => e.ParcelId).HasColumnName("ParcelID");

                entity.Property(e => e.ParcelStageId).HasColumnName("ParcelStageID");

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(12);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.ProformaInvoiceNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceNo).HasMaxLength(4000);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.SnNo)
                    .HasMaxLength(20)
                    .HasColumnName("SN_No");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<MigOpowerTnbrecipientStaging>(entity =>
            {
                entity.ToTable("MigOpowerTNBRecipientStaging");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LegacyCustomerNumber).HasMaxLength(20);

                entity.Property(e => e.LegacyStationCode).HasMaxLength(20);
            });

            modelBuilder.Entity<MigParcelMoveInException>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigParcelMoveInException");

                entity.Property(e => e.AccountType).HasMaxLength(255);

                entity.Property(e => e.AdditionalInfo).HasMaxLength(255);

                entity.Property(e => e.AuthorisedPersonnelName).HasMaxLength(255);

                entity.Property(e => e.AuthorisedPersonnelNumber).HasMaxLength(255);

                entity.Property(e => e.EmailAddress).HasMaxLength(255);

                entity.Property(e => e.ExceptionMsg).HasMaxLength(255);

                entity.Property(e => e.ExceptionType).HasMaxLength(50);

                entity.Property(e => e.GroupNcno)
                    .HasMaxLength(255)
                    .HasColumnName("GroupNCNo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdentificationNumber).HasMaxLength(255);

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.MaHouseNo)
                    .HasMaxLength(255)
                    .HasColumnName("MA_HouseNo");

                entity.Property(e => e.MaPostcode)
                    .HasMaxLength(255)
                    .HasColumnName("MA_Postcode");

                entity.Property(e => e.MaState)
                    .HasMaxLength(255)
                    .HasColumnName("MA_State");

                entity.Property(e => e.MaStreet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_Street");

                entity.Property(e => e.MaTownArea)
                    .HasMaxLength(255)
                    .HasColumnName("MA_TownArea");

                entity.Property(e => e.NameOfAppplicant).HasMaxLength(255);

                entity.Property(e => e.NextofKinContactEmailAddress).HasMaxLength(255);

                entity.Property(e => e.NextofKinContactName).HasMaxLength(255);

                entity.Property(e => e.NextofKinContactNumber).HasMaxLength(255);

                entity.Property(e => e.ParcelId)
                    .HasMaxLength(255)
                    .HasColumnName("ParcelID");

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.PlHouseNo)
                    .HasMaxLength(255)
                    .HasColumnName("PL_HouseNo");

                entity.Property(e => e.PlPostcode)
                    .HasMaxLength(255)
                    .HasColumnName("PL_Postcode");

                entity.Property(e => e.PlPremiseType)
                    .HasMaxLength(255)
                    .HasColumnName("PL_PremiseType");

                entity.Property(e => e.PlState)
                    .HasMaxLength(255)
                    .HasColumnName("PL_State");

                entity.Property(e => e.PlStreet)
                    .HasMaxLength(255)
                    .HasColumnName("PL_Street");

                entity.Property(e => e.PlTownArea)
                    .HasMaxLength(255)
                    .HasColumnName("PL_TownArea");

                entity.Property(e => e.ProjectCreator).HasMaxLength(255);

                entity.Property(e => e.ProjectName).HasMaxLength(255);

                entity.Property(e => e.Salutation).HasMaxLength(255);

                entity.Property(e => e.StationCode).HasMaxLength(255);

                entity.Property(e => e.TnbprojectId)
                    .HasMaxLength(255)
                    .HasColumnName("TNBProjectID");

                entity.Property(e => e.UserRole).HasMaxLength(255);
            });

            modelBuilder.Entity<MigParcelMoveInLoading>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigParcelMoveInLoading");

                entity.Property(e => e.AccountType).HasMaxLength(255);

                entity.Property(e => e.AdditionalInfo).HasMaxLength(255);

                entity.Property(e => e.AuthorisedPersonnelName).HasMaxLength(255);

                entity.Property(e => e.AuthorisedPersonnelNumber).HasMaxLength(255);

                entity.Property(e => e.EmailAddress).HasMaxLength(255);

                entity.Property(e => e.GroupNcno)
                    .HasMaxLength(255)
                    .HasColumnName("GroupNCNo");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IdentificationNumber).HasMaxLength(255);

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.MaHouseNo)
                    .HasMaxLength(255)
                    .HasColumnName("MA_HouseNo");

                entity.Property(e => e.MaPostcode)
                    .HasMaxLength(255)
                    .HasColumnName("MA_Postcode");

                entity.Property(e => e.MaState)
                    .HasMaxLength(255)
                    .HasColumnName("MA_State");

                entity.Property(e => e.MaStreet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_Street");

                entity.Property(e => e.MaTownArea)
                    .HasMaxLength(255)
                    .HasColumnName("MA_TownArea");

                entity.Property(e => e.MigrationStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfAppplicant).HasMaxLength(255);

                entity.Property(e => e.NextofKinContactEmailAddress).HasMaxLength(255);

                entity.Property(e => e.NextofKinContactName).HasMaxLength(255);

                entity.Property(e => e.NextofKinContactNumber).HasMaxLength(255);

                entity.Property(e => e.ParcelId)
                    .HasMaxLength(255)
                    .HasColumnName("ParcelID");

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.PlHouseNo)
                    .HasMaxLength(255)
                    .HasColumnName("PL_HouseNo");

                entity.Property(e => e.PlPostcode)
                    .HasMaxLength(255)
                    .HasColumnName("PL_Postcode");

                entity.Property(e => e.PlPremiseType)
                    .HasMaxLength(255)
                    .HasColumnName("PL_PremiseType");

                entity.Property(e => e.PlState)
                    .HasMaxLength(255)
                    .HasColumnName("PL_State");

                entity.Property(e => e.PlStreet)
                    .HasMaxLength(255)
                    .HasColumnName("PL_Street");

                entity.Property(e => e.PlTownArea)
                    .HasMaxLength(255)
                    .HasColumnName("PL_TownArea");

                entity.Property(e => e.ProjectCreator).HasMaxLength(255);

                entity.Property(e => e.ProjectName).HasMaxLength(255);

                entity.Property(e => e.Salutation).HasMaxLength(255);

                entity.Property(e => e.StationCode).HasMaxLength(255);

                entity.Property(e => e.TnbprojectId)
                    .HasMaxLength(255)
                    .HasColumnName("TNBProjectID");

                entity.Property(e => e.UserRole).HasMaxLength(255);
            });

            modelBuilder.Entity<MigParcelMoveInLoadingOnRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigParcelMoveInLoadingOnRequest");

                entity.Property(e => e.AccountType).HasMaxLength(255);

                entity.Property(e => e.AdditionalInfo).HasMaxLength(255);

                entity.Property(e => e.AuthorisedPersonnelName).HasMaxLength(255);

                entity.Property(e => e.AuthorisedPersonnelNumber).HasMaxLength(255);

                entity.Property(e => e.EmailAddress).HasMaxLength(255);

                entity.Property(e => e.GroupNcno)
                    .HasMaxLength(255)
                    .HasColumnName("GroupNCNo");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IdentificationNumber).HasMaxLength(255);

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.MaHouseNo)
                    .HasMaxLength(255)
                    .HasColumnName("MA_HouseNo");

                entity.Property(e => e.MaPostcode)
                    .HasMaxLength(255)
                    .HasColumnName("MA_Postcode");

                entity.Property(e => e.MaState)
                    .HasMaxLength(255)
                    .HasColumnName("MA_State");

                entity.Property(e => e.MaStreet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_Street");

                entity.Property(e => e.MaTownArea)
                    .HasMaxLength(255)
                    .HasColumnName("MA_TownArea");

                entity.Property(e => e.MigrationStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfAppplicant).HasMaxLength(255);

                entity.Property(e => e.NextofKinContactEmailAddress).HasMaxLength(255);

                entity.Property(e => e.NextofKinContactName).HasMaxLength(255);

                entity.Property(e => e.NextofKinContactNumber).HasMaxLength(255);

                entity.Property(e => e.ParcelId)
                    .HasMaxLength(255)
                    .HasColumnName("ParcelID");

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.PlHouseNo)
                    .HasMaxLength(255)
                    .HasColumnName("PL_HouseNo");

                entity.Property(e => e.PlPostcode)
                    .HasMaxLength(255)
                    .HasColumnName("PL_Postcode");

                entity.Property(e => e.PlPremiseType)
                    .HasMaxLength(255)
                    .HasColumnName("PL_PremiseType");

                entity.Property(e => e.PlState)
                    .HasMaxLength(255)
                    .HasColumnName("PL_State");

                entity.Property(e => e.PlStreet)
                    .HasMaxLength(255)
                    .HasColumnName("PL_Street");

                entity.Property(e => e.PlTownArea)
                    .HasMaxLength(255)
                    .HasColumnName("PL_TownArea");

                entity.Property(e => e.ProjectCreator).HasMaxLength(255);

                entity.Property(e => e.ProjectName).HasMaxLength(255);

                entity.Property(e => e.Salutation).HasMaxLength(255);

                entity.Property(e => e.StationCode).HasMaxLength(255);

                entity.Property(e => e.TnbprojectId)
                    .HasMaxLength(255)
                    .HasColumnName("TNBProjectID");

                entity.Property(e => e.UserRole).HasMaxLength(255);
            });

            modelBuilder.Entity<MigPremiseDescLookup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigPremiseDescLookup");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.Decsription).HasMaxLength(100);

                entity.Property(e => e.ProjectCategoryId).HasColumnName("ProjectCategoryID");
            });

            modelBuilder.Entity<MigProjectLoading>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigProjectLoading");

                entity.Property(e => e.DeveloperName).HasMaxLength(255);

                entity.Property(e => e.FlPostcode)
                    .HasMaxLength(255)
                    .HasColumnName("FL_Postcode");

                entity.Property(e => e.FlState)
                    .HasMaxLength(255)
                    .HasColumnName("FL_State");

                entity.Property(e => e.FlTownArea)
                    .HasMaxLength(255)
                    .HasColumnName("FL_TownArea");

                entity.Property(e => e.GroupNcno)
                    .HasMaxLength(255)
                    .HasColumnName("GroupNCNo");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.MigrationStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumberofUnits).HasMaxLength(255);

                entity.Property(e => e.ParcelDescription).HasMaxLength(255);

                entity.Property(e => e.ParcelId)
                    .HasMaxLength(255)
                    .HasColumnName("ParcelID");

                entity.Property(e => e.PremiseDescription).HasMaxLength(255);

                entity.Property(e => e.ProjectCreator).HasMaxLength(255);

                entity.Property(e => e.Sn)
                    .HasMaxLength(255)
                    .HasColumnName("SN");

                entity.Property(e => e.StationCode).HasMaxLength(255);

                entity.Property(e => e.TnbprojectId)
                    .HasMaxLength(255)
                    .HasColumnName("TNBProjectID");

                entity.Property(e => e.TotalNumberofUnitEcibs)
                    .HasMaxLength(255)
                    .HasColumnName("TotalNumberofUnit_ECIBS");

                entity.Property(e => e.TotalNumberofUnits).HasMaxLength(255);

                entity.Property(e => e.TotalParcelNotSubmitted).HasMaxLength(255);

                entity.Property(e => e.TotalUnitSubmittedEcibs)
                    .HasMaxLength(255)
                    .HasColumnName("TotalUnitSubmitted_ECIBS");
            });

            modelBuilder.Entity<MigProjectLoadingOnRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigProjectLoadingOnRequest");

                entity.Property(e => e.DeveloperName).HasMaxLength(255);

                entity.Property(e => e.FlPostcode)
                    .HasMaxLength(255)
                    .HasColumnName("FL_Postcode");

                entity.Property(e => e.FlState)
                    .HasMaxLength(255)
                    .HasColumnName("FL_State");

                entity.Property(e => e.FlTownArea)
                    .HasMaxLength(255)
                    .HasColumnName("FL_TownArea");

                entity.Property(e => e.GroupNcno)
                    .HasMaxLength(255)
                    .HasColumnName("GroupNCNo");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.MaterialDescription).HasMaxLength(255);

                entity.Property(e => e.Mdid)
                    .HasMaxLength(255)
                    .HasColumnName("MDID");

                entity.Property(e => e.Mdload)
                    .HasMaxLength(255)
                    .HasColumnName("MDLoad");

                entity.Property(e => e.MeterType).HasMaxLength(255);

                entity.Property(e => e.MigrationStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumberofUnits).HasMaxLength(255);

                entity.Property(e => e.ParcelDescription).HasMaxLength(255);

                entity.Property(e => e.ParcelId)
                    .HasMaxLength(255)
                    .HasColumnName("ParcelID");

                entity.Property(e => e.PremiseDescription).HasMaxLength(255);

                entity.Property(e => e.ProjectCreator).HasMaxLength(255);

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.Sn)
                    .HasMaxLength(255)
                    .HasColumnName("SN");

                entity.Property(e => e.SspparcelId)
                    .HasMaxLength(255)
                    .HasColumnName("SSPParcelID");

                entity.Property(e => e.StationCode).HasMaxLength(255);

                entity.Property(e => e.TnbprojectId)
                    .HasMaxLength(255)
                    .HasColumnName("TNBProjectID");

                entity.Property(e => e.TotalNumberofUnitEcibs)
                    .HasMaxLength(255)
                    .HasColumnName("TotalNumberofUnit_ECIBS");

                entity.Property(e => e.TotalNumberofUnits).HasMaxLength(255);

                entity.Property(e => e.TotalParcelNotSubmitted).HasMaxLength(255);

                entity.Property(e => e.TotalUnitSubmittedEcibs)
                    .HasMaxLength(255)
                    .HasColumnName("TotalUnitSubmitted_ECIBS");

                entity.Property(e => e.VoltageId).HasMaxLength(255);
            });

            modelBuilder.Entity<MigProjectParcelMoveInLoadingOnRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigProjectParcelMoveInLoadingOnRequest");

                entity.Property(e => e.AccountType).HasMaxLength(255);

                entity.Property(e => e.AdditionalInfo).HasMaxLength(255);

                entity.Property(e => e.AuthorisedPersonnelName).HasMaxLength(255);

                entity.Property(e => e.AuthorisedPersonnelNumber).HasMaxLength(255);

                entity.Property(e => e.EmailAddress).HasMaxLength(255);

                entity.Property(e => e.GroupNcno)
                    .HasMaxLength(255)
                    .HasColumnName("GroupNCNo");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IdentificationNumber).HasMaxLength(255);

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.MaHouseNo)
                    .HasMaxLength(255)
                    .HasColumnName("MA_HouseNo");

                entity.Property(e => e.MaPostcode)
                    .HasMaxLength(255)
                    .HasColumnName("MA_Postcode");

                entity.Property(e => e.MaState)
                    .HasMaxLength(255)
                    .HasColumnName("MA_State");

                entity.Property(e => e.MaStreet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_Street");

                entity.Property(e => e.MaTownArea)
                    .HasMaxLength(255)
                    .HasColumnName("MA_TownArea");

                entity.Property(e => e.MigrationStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfAppplicant).HasMaxLength(255);

                entity.Property(e => e.NextofKinContactEmailAddress).HasMaxLength(255);

                entity.Property(e => e.NextofKinContactName).HasMaxLength(255);

                entity.Property(e => e.NextofKinContactNumber).HasMaxLength(255);

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.PlHouseNo)
                    .HasMaxLength(255)
                    .HasColumnName("PL_HouseNo");

                entity.Property(e => e.PlPostcode)
                    .HasMaxLength(255)
                    .HasColumnName("PL_Postcode");

                entity.Property(e => e.PlPremiseType)
                    .HasMaxLength(255)
                    .HasColumnName("PL_PremiseType");

                entity.Property(e => e.PlState)
                    .HasMaxLength(255)
                    .HasColumnName("PL_State");

                entity.Property(e => e.PlStreet)
                    .HasMaxLength(255)
                    .HasColumnName("PL_Street");

                entity.Property(e => e.PlTownArea)
                    .HasMaxLength(255)
                    .HasColumnName("PL_TownArea");

                entity.Property(e => e.ProjectCreator).HasMaxLength(255);

                entity.Property(e => e.ProjectName).HasMaxLength(255);

                entity.Property(e => e.Salutation).HasMaxLength(255);

                entity.Property(e => e.SspparcelId)
                    .HasMaxLength(255)
                    .HasColumnName("SSPParcelID");

                entity.Property(e => e.StationCode).HasMaxLength(255);

                entity.Property(e => e.TnbprojectId)
                    .HasMaxLength(255)
                    .HasColumnName("TNBProjectID");

                entity.Property(e => e.UserRole).HasMaxLength(255);
            });

            modelBuilder.Entity<MigProjectParcelStaging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigProjectParcelStaging");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.Mdid).HasColumnName("MDID");

                entity.Property(e => e.MeterType).HasMaxLength(20);

                entity.Property(e => e.ParcelActualId).HasColumnName("ParcelActualID");

                entity.Property(e => e.ParcelId).HasColumnName("ParcelID");

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectStageId).HasColumnName("ProjectStageID");

                entity.Property(e => e.ServiceType).HasMaxLength(20);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.TnbProjectId)
                    .HasMaxLength(16)
                    .HasColumnName("TNB_ProjectID");

                entity.Property(e => e.VoltageLevel).HasMaxLength(20);
            });

            modelBuilder.Entity<MigProjectParcelUpdateOnRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigProjectParcelUpdateOnRequest");

                entity.Property(e => e.Action).HasMaxLength(255);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.MaterialDescription).HasMaxLength(255);

                entity.Property(e => e.Mdload)
                    .HasMaxLength(255)
                    .HasColumnName("MDLoad");

                entity.Property(e => e.MeterType).HasMaxLength(255);

                entity.Property(e => e.MigrationStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumberofUnits).HasMaxLength(255);

                entity.Property(e => e.ParcelDescription).HasMaxLength(255);

                entity.Property(e => e.ReferenceNo).HasMaxLength(255);

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.SspparcelId)
                    .HasMaxLength(255)
                    .HasColumnName("SSPParcelID");

                entity.Property(e => e.TnbprojectId)
                    .HasMaxLength(255)
                    .HasColumnName("TNBProjectID");

                entity.Property(e => e.Tnbstation)
                    .HasMaxLength(255)
                    .HasColumnName("TNBStation");

                entity.Property(e => e.TnbstationCode)
                    .HasMaxLength(255)
                    .HasColumnName("TNBStationCode");

                entity.Property(e => e.TotalNumberofUnits).HasMaxLength(255);

                entity.Property(e => e.VoltageLevel).HasMaxLength(255);
            });

            modelBuilder.Entity<MigProjectSourceException>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigProjectSourceException");

                entity.Property(e => e.DeveloperName).HasMaxLength(255);

                entity.Property(e => e.ExceptionMsg).HasMaxLength(255);

                entity.Property(e => e.ExceptionType).HasMaxLength(50);

                entity.Property(e => e.FlPostcode)
                    .HasMaxLength(255)
                    .HasColumnName("FL_Postcode");

                entity.Property(e => e.FlState)
                    .HasMaxLength(255)
                    .HasColumnName("FL_State");

                entity.Property(e => e.FlTownArea)
                    .HasMaxLength(255)
                    .HasColumnName("FL_TownArea");

                entity.Property(e => e.GroupNcno)
                    .HasMaxLength(255)
                    .HasColumnName("GroupNCNo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.NumberofUnits).HasMaxLength(255);

                entity.Property(e => e.ParcelDescription).HasMaxLength(255);

                entity.Property(e => e.ParcelId)
                    .HasMaxLength(255)
                    .HasColumnName("ParcelID");

                entity.Property(e => e.PremiseDescription).HasMaxLength(255);

                entity.Property(e => e.ProjectCreator).HasMaxLength(255);

                entity.Property(e => e.StationCode).HasMaxLength(255);

                entity.Property(e => e.TnbprojectId)
                    .HasMaxLength(255)
                    .HasColumnName("TNBProjectID");

                entity.Property(e => e.TotalNumberofUnitEcibs)
                    .HasMaxLength(255)
                    .HasColumnName("TotalNumberofUnit_ECIBS");

                entity.Property(e => e.TotalNumberofUnits).HasMaxLength(255);

                entity.Property(e => e.TotalParcelNotSubmitted).HasMaxLength(255);

                entity.Property(e => e.TotalUnitSubmittedEcibs)
                    .HasMaxLength(255)
                    .HasColumnName("TotalUnitSubmitted_ECIBS");
            });

            modelBuilder.Entity<MigProjectStaging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigProjectStaging");

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.Bpbuilding)
                    .HasMaxLength(40)
                    .HasColumnName("BPBuilding");

                entity.Property(e => e.Bpcity)
                    .HasMaxLength(40)
                    .HasColumnName("BPCity");

                entity.Property(e => e.Bpcountry)
                    .HasMaxLength(3)
                    .HasColumnName("BPCountry");

                entity.Property(e => e.BpfaxNo)
                    .HasMaxLength(15)
                    .HasColumnName("BPFaxNo");

                entity.Property(e => e.BppostalCode)
                    .HasMaxLength(10)
                    .HasColumnName("BPPostalCode");

                entity.Property(e => e.BppropertyType)
                    .HasMaxLength(1)
                    .HasColumnName("BPPropertyType");

                entity.Property(e => e.Bpstate)
                    .HasMaxLength(3)
                    .HasColumnName("BPState");

                entity.Property(e => e.Bpstreet)
                    .HasMaxLength(60)
                    .HasColumnName("BPStreet");

                entity.Property(e => e.Bptown)
                    .HasMaxLength(60)
                    .HasColumnName("BPTown");

                entity.Property(e => e.BpunitNo)
                    .HasMaxLength(10)
                    .HasColumnName("BPUnitNo");

                entity.Property(e => e.Cctotal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CCTotal");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeclaredMd)
                    .HasMaxLength(20)
                    .HasColumnName("DeclaredMD");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EContractorId).HasColumnName("eContractorID");

                entity.Property(e => e.FixedLineNo).HasMaxLength(15);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IdentificationNo).HasMaxLength(14);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.IsTnc).HasColumnName("IsTNC");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.LoadType)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Name1).HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseSubStation).HasMaxLength(20);

                entity.Property(e => e.PremiseTown).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.ProformaInvNo).HasMaxLength(10);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectName).HasMaxLength(100);

                entity.Property(e => e.ReferenceNo).HasMaxLength(4000);

                entity.Property(e => e.RequiredDate).HasColumnType("date");

                entity.Property(e => e.SnNo)
                    .HasMaxLength(20)
                    .HasColumnName("SN_No");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StationCodeErms)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("StationCodeERMS")
                    .IsFixedLength(true);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TnbProjectId)
                    .HasMaxLength(16)
                    .HasColumnName("TNB_ProjectID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VoltageLevel).HasMaxLength(10);
            });

            modelBuilder.Entity<MigSalutationLookup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigSalutationLookup");

                entity.Property(e => e.Salutation).HasMaxLength(20);

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.Sspsalutation)
                    .HasMaxLength(20)
                    .HasColumnName("SSPSalutation");
            });

            modelBuilder.Entity<MigSrstatusDateSyncTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigSRStatusDateSyncTemp");

                entity.Property(e => e.Cat1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cat2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cat3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cat4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChangedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChangedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ChangedTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressIndicator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeterIndicator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeterReplacement)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MyTnbapplicationId).HasColumnName("MyTNBApplicationID");

                entity.Property(e => e.MyTnbapplicationNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MyTNBApplicationNo");

                entity.Property(e => e.ServiceRequestNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoltageLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MigSspbcrmprojectId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigSSPBCRMProjectID");

                entity.Property(e => e.BcrmTnbprojectId)
                    .HasMaxLength(255)
                    .HasColumnName("BCRM_TNBProjectID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.MigrationStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SspTnbprojectId)
                    .HasMaxLength(255)
                    .HasColumnName("SSP_TNBProjectID");
            });

            modelBuilder.Entity<MigStateLookup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigStateLookup");

                entity.Property(e => e.Crmstate).HasColumnName("CRMState");

                entity.Property(e => e.KodNegeriSt).HasColumnName("KodNegeriST");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.Tnbactive).HasColumnName("TNBActive");
            });

            modelBuilder.Entity<MigStationLookup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigStationLookup");

                entity.Property(e => e.BizAreaSspstationCode).HasColumnName("BizArea_SSPStationCode");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.Property(e => e.StationName).HasMaxLength(200);
            });

            modelBuilder.Entity<MigTempSn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigTempSn");

                entity.Property(e => e.Sn)
                    .HasMaxLength(50)
                    .HasColumnName("SN");

                entity.Property(e => e.Wbs)
                    .HasMaxLength(50)
                    .HasColumnName("WBS");
            });

            modelBuilder.Entity<MigTrnAccountStaging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigTrnAccountStaging");

                entity.Property(e => e.AccountCategory)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCategoryId)
                    .HasColumnName("AccountCategoryID")
                    .HasComputedColumnSql("(case when [AccountCategory]='Utility Account' then (1) when [AccountCategory]='FIAH Account' then (2) else (99) end)", true);

                entity.Property(e => e.AccountDescription).HasMaxLength(100);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.Area)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Building)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(40);

                entity.Property(e => e.ContactNo).HasMaxLength(15);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.HouseNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdentificationNo).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.MotherName).HasMaxLength(50);

                entity.Property(e => e.OwnerName).HasMaxLength(50);

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Roc).HasColumnName("ROC");

                entity.Property(e => e.State).HasMaxLength(40);

                entity.Property(e => e.Street)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UnitNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<MigTrnUserStaging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigTrnUserStaging");

                entity.Property(e => e.ActivationExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(25);

                entity.Property(e => e.CommId).HasColumnName("CommID");

                entity.Property(e => e.Country).HasMaxLength(25);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.FixedLineNo).HasMaxLength(15);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdentificationNo).HasMaxLength(50);

                entity.Property(e => e.KinContactNo).HasMaxLength(15);

                entity.Property(e => e.KinName).HasMaxLength(50);

                entity.Property(e => e.LastLoginFromMobile).HasColumnType("datetime");

                entity.Property(e => e.LastLoginFromWeb).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.MaidenName).HasMaxLength(50);

                entity.Property(e => e.MailingAddr1).HasMaxLength(25);

                entity.Property(e => e.MailingAddr2).HasMaxLength(25);

                entity.Property(e => e.MailingAddr3).HasMaxLength(25);

                entity.Property(e => e.MailingAddrState).HasMaxLength(25);

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.RegistrationSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Salt).HasMaxLength(50);

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.SourceEncryptPassword).HasMaxLength(255);

                entity.Property(e => e.SourcePassword).HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserPassword).HasMaxLength(255);
            });

            modelBuilder.Entity<MigTrnUserStaging2>(entity =>
            {
                entity.ToTable("MigTrnUserStaging2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Salt).HasMaxLength(50);

                entity.Property(e => e.SourceEncryptPassword).HasMaxLength(255);

                entity.Property(e => e.SourcePassword).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserPassword).HasMaxLength(255);
            });

            modelBuilder.Entity<MigTrnUserStaging2X>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigTrnUserStaging2X");

                entity.Property(e => e.AccountNumber).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.IsOwnedAccount).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.RegistrationSource).HasMaxLength(255);

                entity.Property(e => e.Roc)
                    .HasMaxLength(255)
                    .HasColumnName("ROC");

                entity.Property(e => e.Role).HasMaxLength(255);
            });

            modelBuilder.Entity<MigUserAccountException>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigUserAccountException");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Canumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CANumber");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExceptionMsg).HasMaxLength(255);

                entity.Property(e => e.ExceptionType).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsOwnedAccount)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationSource)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Roc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ROC");

                entity.Property(e => e.Role)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MigUserAccountLoading>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigUserAccountLoading");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Canumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANumber");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsOwnedAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.MigrationStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Roc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROC");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MigUserAccountStaging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigUserAccountStaging");

                entity.Property(e => e.AccountNumber).HasMaxLength(14);

                entity.Property(e => e.AccountType).HasMaxLength(1);

                entity.Property(e => e.Canumber)
                    .HasMaxLength(12)
                    .HasColumnName("CANumber");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ImportStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsOwnedAccount).HasMaxLength(12);

                entity.Property(e => e.LoadDate).HasColumnType("datetime");

                entity.Property(e => e.LoadingId).HasColumnName("LoadingID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.RegistrationSource).HasMaxLength(1);

                entity.Property(e => e.Roc)
                    .HasMaxLength(30)
                    .HasColumnName("ROC");

                entity.Property(e => e.Role).HasMaxLength(1);
            });

            modelBuilder.Entity<ModeofPayment>(entity =>
            {
                entity.ToTable("ModeofPayment");

                entity.Property(e => e.ModeofPaymentCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ModeofPaymentDescription)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.ToTable("Module");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.ActionName).IsRequired();

                entity.Property(e => e.Controller).IsRequired();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ImagePath).IsUnicode(false);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ModuleItem>(entity =>
            {
                entity.ToTable("ModuleItem");

                entity.Property(e => e.ModuleItemId).HasColumnName("ModuleItemID");

                entity.Property(e => e.ActionName).IsRequired();

                entity.Property(e => e.Controller).IsRequired();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ImagePath).IsUnicode(false);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.ModuleItemDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleItemName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.ModuleItems)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModuleItem_Module");
            });

            modelBuilder.Entity<NewConnection>(entity =>
            {
                entity.ToTable("NewConnection");

                entity.HasIndex(e => e.StatusId, "IX_NewConnection");

                entity.HasIndex(e => e.ApplicantType, "IX_NewConnection_ApplicantType");

                entity.HasIndex(e => e.ApplicationModuleId, "IX_NewConnection_ApplicationModuleID");

                entity.HasIndex(e => e.ContractAccountNo, "IX_NewConnection_ContractAccountNo");

                entity.HasIndex(e => e.ContractorId, "IX_NewConnection_ContractorID");

                entity.HasIndex(e => e.Email, "IX_NewConnection_Email");

                entity.HasIndex(e => e.LastModifiedDate, "IX_NewConnection_LastModifiedDate");

                entity.HasIndex(e => e.ParcelId, "IX_NewConnection_ParcelID");

                entity.HasIndex(e => new { e.UserId, e.IsDeleted, e.ApplicationModuleId, e.StatusId }, "IX_NewConnection_StatusID");

                entity.HasIndex(e => new { e.ContractAccountNo, e.StationCode, e.CreatedDate, e.StatusId }, "idx_ms_nc_application");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicantType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BillingEmail).HasMaxLength(241);

                entity.Property(e => e.BpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BP_No");

                entity.Property(e => e.ContactPersonName1).HasMaxLength(40);

                entity.Property(e => e.ContactPersonName2).HasMaxLength(40);

                entity.Property(e => e.ContactPersonPosition).HasMaxLength(20);

                entity.Property(e => e.ContractAccountNo).HasMaxLength(14);

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(240);

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.FixedLineNo).HasMaxLength(15);

                entity.Property(e => e.GivenTitleId).HasColumnName("GivenTitleID");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(20)
                    .HasColumnName("GSTNo");

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.InstallationNo).HasMaxLength(12);

                entity.Property(e => e.IsRsgexist).HasColumnName("isRSGExist");

                entity.Property(e => e.IsSearchByCa).HasColumnName("IsSearchByCA");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoadType)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LockStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaEducation).HasColumnName("MA_Education");

                entity.Property(e => e.MaIncome).HasColumnName("MA_Income");

                entity.Property(e => e.MaOccupation).HasColumnName("MA_Occupation");

                entity.Property(e => e.MaPaymentChannel).HasColumnName("MA_PaymentChannel");

                entity.Property(e => e.MaPaymentMethod).HasColumnName("MA_PaymentMethod");

                entity.Property(e => e.MaRace).HasColumnName("MA_Race");

                entity.Property(e => e.MaReligion).HasColumnName("MA_Religion");

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(10);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.MothersName).HasMaxLength(40);

                entity.Property(e => e.Name1).HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinEmail).HasMaxLength(240);

                entity.Property(e => e.NextOfKinName1).HasMaxLength(40);

                entity.Property(e => e.NextOfKinName2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinPhoneNo).HasMaxLength(15);

                entity.Property(e => e.ParcelId).HasColumnName("ParcelID");

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseCurrentMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(12);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.ProcessBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([NewConnectionID],'NC-000-000-0000'))", false);

                entity.Property(e => e.RegisterGroup).HasMaxLength(40);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.SdexemptionFlag).HasColumnName("SDExemptionFlag");

                entity.Property(e => e.SearchedCano)
                    .HasMaxLength(14)
                    .HasColumnName("SearchedCANo");

                entity.Property(e => e.SnForAttachment)
                    .HasMaxLength(20)
                    .HasColumnName("SN_for_Attachment");

                entity.Property(e => e.SnNo)
                    .HasMaxLength(20)
                    .HasColumnName("SN_No");

                entity.Property(e => e.SnStatus)
                    .HasMaxLength(50)
                    .HasColumnName("SN_Status");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.SrStatus)
                    .HasMaxLength(50)
                    .HasColumnName("SR_Status");

                entity.Property(e => e.SrapplicationDetail).HasColumnName("SRApplicationDetail");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StreetlightSubCategoryCode).HasMaxLength(10);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserRole).HasMaxLength(20);

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.NewConnections)
                    .HasForeignKey(d => d.AccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnection_AccountType");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.NewConnections)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnection_ApplicationStatus");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NewConnections)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnection_TrnUser");
            });

            modelBuilder.Entity<NewConnectionAddressDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NewConnectionAddress_Deleted");

                entity.Property(e => e.RegionalStructure)
                    .IsRequired()
                    .HasMaxLength(178);
            });

            modelBuilder.Entity<NewConnectionApplicationStatus>(entity =>
            {
                entity.HasKey(e => e.ApplicationStatusId);

                entity.ToTable("NewConnectionApplicationStatus");

                entity.HasIndex(e => e.NewConnectionId, "IX_NewConnectionApplicationStatus_NewConnectionID");

                entity.Property(e => e.ApplicationStatusId).HasColumnName("ApplicationStatusID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DisplayText).HasMaxLength(30);

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.StatusCode).HasMaxLength(40);

                entity.Property(e => e.StatusDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusFor)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusText).HasMaxLength(30);

                entity.HasOne(d => d.NewConnection)
                    .WithMany(p => p.NewConnectionApplicationStatuses)
                    .HasForeignKey(d => d.NewConnectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionApplicationStatus_NewConnection");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.NewConnectionApplicationStatuses)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_NewConnectionApplicationStatus_ApplicationStatus");
            });

            modelBuilder.Entity<NewConnectionApprovalInformation>(entity =>
            {
                entity.HasKey(e => e.NewConnectionApprovalId);

                entity.ToTable("NewConnectionApprovalInformation");

                entity.HasIndex(e => e.NewConnectionId, "IX_NewConnectionApprovalInformation_NewConnectionID");

                entity.Property(e => e.NewConnectionApprovalId).HasColumnName("NewConnectionApprovalID");

                entity.Property(e => e.ApprovalStatus).HasMaxLength(20);

                entity.Property(e => e.Bpid).HasColumnName("BPID");

                entity.Property(e => e.Bpno)
                    .HasMaxLength(20)
                    .HasColumnName("BPNo");

                entity.Property(e => e.Bprelationship).HasColumnName("BPRelationship");

                entity.Property(e => e.CaNo).HasMaxLength(14);

                entity.Property(e => e.Ccamount)
                    .HasMaxLength(20)
                    .HasColumnName("CCAmount");

                entity.Property(e => e.ContactBpno)
                    .HasMaxLength(20)
                    .HasColumnName("ContactBPNo");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.PremiseNo).HasMaxLength(12);

                entity.Property(e => e.ProcessingFee).HasMaxLength(20);

                entity.Property(e => e.ProformaInvoice).HasMaxLength(20);

                entity.Property(e => e.Sdamount)
                    .HasMaxLength(20)
                    .HasColumnName("SDAmount");

                entity.Property(e => e.Snno)
                    .HasMaxLength(20)
                    .HasColumnName("SNNo");

                entity.Property(e => e.Srno)
                    .HasMaxLength(20)
                    .HasColumnName("SRNo");

                entity.Property(e => e.StampDuty).HasMaxLength(20);

                entity.Property(e => e.Tmdstatus)
                    .HasMaxLength(10)
                    .HasColumnName("TMDStatus");

                entity.Property(e => e.TmdworkFlow)
                    .HasMaxLength(10)
                    .HasColumnName("TMDWorkFlow");

                entity.HasOne(d => d.NewConnection)
                    .WithMany(p => p.NewConnectionApprovalInformations)
                    .HasForeignKey(d => d.NewConnectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionApprovalInformation_NewConnection");
            });

            modelBuilder.Entity<NewConnectionAssignment>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("NewConnectionAssignment");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Action)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");
            });

            modelBuilder.Entity<NewConnectionAttachment>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.NewConnectionId });

                entity.ToTable("NewConnectionAttachment");

                entity.HasIndex(e => new { e.NewConnectionId, e.FileGroupId, e.UploadedBy, e.IsDeleted }, "IX_NewConnectionAttachment_NewConnectionID_FileGroupID_UploadedBy_IsDeleted");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileGroupId)
                    .HasMaxLength(20)
                    .HasColumnName("FileGroupID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UploadedBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength(true);

                entity.HasOne(d => d.File)
                    .WithMany(p => p.NewConnectionAttachments)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_NewConnectionAttachment_ApplicationFileUpload");

                entity.HasOne(d => d.NewConnection)
                    .WithMany(p => p.NewConnectionAttachments)
                    .HasForeignKey(d => d.NewConnectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionAttachment_NewConnection");
            });

            modelBuilder.Entity<NewConnectionBackup8Nov19>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NewConnectionBackup8Nov19");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicantType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BP_No");

                entity.Property(e => e.ContactPersonName1).HasMaxLength(40);

                entity.Property(e => e.ContactPersonName2).HasMaxLength(40);

                entity.Property(e => e.ContactPersonPosition).HasMaxLength(20);

                entity.Property(e => e.ContractAccountNo).HasMaxLength(14);

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(240);

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.FixedLineNo).HasMaxLength(15);

                entity.Property(e => e.GivenTitleId).HasColumnName("GivenTitleID");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(20)
                    .HasColumnName("GSTNo");

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.InstallationNo).HasMaxLength(12);

                entity.Property(e => e.IsRsgexist).HasColumnName("isRSGExist");

                entity.Property(e => e.IsSearchByCa).HasColumnName("IsSearchByCA");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoadType)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LockStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaEducation).HasColumnName("MA_Education");

                entity.Property(e => e.MaIncome).HasColumnName("MA_Income");

                entity.Property(e => e.MaOccupation).HasColumnName("MA_Occupation");

                entity.Property(e => e.MaPaymentChannel).HasColumnName("MA_PaymentChannel");

                entity.Property(e => e.MaPaymentMethod).HasColumnName("MA_PaymentMethod");

                entity.Property(e => e.MaRace).HasColumnName("MA_Race");

                entity.Property(e => e.MaReligion).HasColumnName("MA_Religion");

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(10);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.MothersName).HasMaxLength(40);

                entity.Property(e => e.Name1).HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.NewConnectionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NewConnectionID");

                entity.Property(e => e.NextOfKinEmail).HasMaxLength(240);

                entity.Property(e => e.NextOfKinName1).HasMaxLength(40);

                entity.Property(e => e.NextOfKinName2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinPhoneNo).HasMaxLength(15);

                entity.Property(e => e.ParcelId).HasColumnName("ParcelID");

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseCurrentMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(12);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.ProcessBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceNo).HasMaxLength(4000);

                entity.Property(e => e.RegisterGroup).HasMaxLength(40);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.SdexemptionFlag).HasColumnName("SDExemptionFlag");

                entity.Property(e => e.SearchedCano)
                    .HasMaxLength(14)
                    .HasColumnName("SearchedCANo");

                entity.Property(e => e.SnForAttachment)
                    .HasMaxLength(20)
                    .HasColumnName("SN_for_Attachment");

                entity.Property(e => e.SnNo)
                    .HasMaxLength(20)
                    .HasColumnName("SN_No");

                entity.Property(e => e.SnStatus)
                    .HasMaxLength(50)
                    .HasColumnName("SN_Status");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.SrStatus)
                    .HasMaxLength(50)
                    .HasColumnName("SR_Status");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StreetlightSubCategoryCode).HasMaxLength(10);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserRole).HasMaxLength(20);
            });

            modelBuilder.Entity<NewConnectionBackupDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NewConnectionBackup_Deleted");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicantType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BP_No");

                entity.Property(e => e.ContactPersonName1).HasMaxLength(40);

                entity.Property(e => e.ContactPersonName2).HasMaxLength(40);

                entity.Property(e => e.ContactPersonPosition).HasMaxLength(20);

                entity.Property(e => e.ContractAccountNo).HasMaxLength(14);

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(240);

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.FixedLineNo).HasMaxLength(15);

                entity.Property(e => e.GivenTitleId).HasColumnName("GivenTitleID");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(20)
                    .HasColumnName("GSTNo");

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.InstallationNo).HasMaxLength(12);

                entity.Property(e => e.IsRsgexist).HasColumnName("isRSGExist");

                entity.Property(e => e.IsSearchByCa).HasColumnName("IsSearchByCA");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoadType)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LockStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaEducation).HasColumnName("MA_Education");

                entity.Property(e => e.MaIncome).HasColumnName("MA_Income");

                entity.Property(e => e.MaOccupation).HasColumnName("MA_Occupation");

                entity.Property(e => e.MaPaymentChannel).HasColumnName("MA_PaymentChannel");

                entity.Property(e => e.MaPaymentMethod).HasColumnName("MA_PaymentMethod");

                entity.Property(e => e.MaRace).HasColumnName("MA_Race");

                entity.Property(e => e.MaReligion).HasColumnName("MA_Religion");

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(10);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.MothersName).HasMaxLength(40);

                entity.Property(e => e.Name1).HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.NewConnectionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NewConnectionID");

                entity.Property(e => e.NextOfKinEmail).HasMaxLength(240);

                entity.Property(e => e.NextOfKinName1).HasMaxLength(40);

                entity.Property(e => e.NextOfKinName2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinPhoneNo).HasMaxLength(15);

                entity.Property(e => e.ParcelId).HasColumnName("ParcelID");

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseCurrentMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PremiseFullText)
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(12);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.ProcessBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceNo).HasMaxLength(4000);

                entity.Property(e => e.RegisterGroup).HasMaxLength(40);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.SdexemptionFlag).HasColumnName("SDExemptionFlag");

                entity.Property(e => e.SearchedCano)
                    .HasMaxLength(14)
                    .HasColumnName("SearchedCANo");

                entity.Property(e => e.SnForAttachment)
                    .HasMaxLength(20)
                    .HasColumnName("SN_for_Attachment");

                entity.Property(e => e.SnNo)
                    .HasMaxLength(20)
                    .HasColumnName("SN_No");

                entity.Property(e => e.SnStatus)
                    .HasMaxLength(50)
                    .HasColumnName("SN_Status");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.SrStatus)
                    .HasMaxLength(50)
                    .HasColumnName("SR_Status");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StreetlightSubCategoryCode).HasMaxLength(10);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserRole).HasMaxLength(20);
            });

            modelBuilder.Entity<NewConnectionBackupPatchStatus18Nov>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NewConnectionBackupPatchStatus18Nov");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicantType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BP_No");

                entity.Property(e => e.ContactPersonName1).HasMaxLength(40);

                entity.Property(e => e.ContactPersonName2).HasMaxLength(40);

                entity.Property(e => e.ContactPersonPosition).HasMaxLength(20);

                entity.Property(e => e.ContractAccountNo).HasMaxLength(14);

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(240);

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.FixedLineNo).HasMaxLength(15);

                entity.Property(e => e.GivenTitleId).HasColumnName("GivenTitleID");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(20)
                    .HasColumnName("GSTNo");

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.InstallationNo).HasMaxLength(12);

                entity.Property(e => e.IsRsgexist).HasColumnName("isRSGExist");

                entity.Property(e => e.IsSearchByCa).HasColumnName("IsSearchByCA");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoadType)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LockStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaEducation).HasColumnName("MA_Education");

                entity.Property(e => e.MaIncome).HasColumnName("MA_Income");

                entity.Property(e => e.MaOccupation).HasColumnName("MA_Occupation");

                entity.Property(e => e.MaPaymentChannel).HasColumnName("MA_PaymentChannel");

                entity.Property(e => e.MaPaymentMethod).HasColumnName("MA_PaymentMethod");

                entity.Property(e => e.MaRace).HasColumnName("MA_Race");

                entity.Property(e => e.MaReligion).HasColumnName("MA_Religion");

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(10);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.MothersName).HasMaxLength(40);

                entity.Property(e => e.Name1).HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.NewConnectionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NewConnectionID");

                entity.Property(e => e.NextOfKinEmail).HasMaxLength(240);

                entity.Property(e => e.NextOfKinName1).HasMaxLength(40);

                entity.Property(e => e.NextOfKinName2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinPhoneNo).HasMaxLength(15);

                entity.Property(e => e.ParcelId).HasColumnName("ParcelID");

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseCurrentMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(12);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.ProcessBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProformaInvoiceNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceNo).HasMaxLength(4000);

                entity.Property(e => e.RegisterGroup).HasMaxLength(40);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.SdexemptionFlag).HasColumnName("SDExemptionFlag");

                entity.Property(e => e.SearchedCano)
                    .HasMaxLength(14)
                    .HasColumnName("SearchedCANo");

                entity.Property(e => e.SnForAttachment)
                    .HasMaxLength(20)
                    .HasColumnName("SN_for_Attachment");

                entity.Property(e => e.SnNo)
                    .HasMaxLength(20)
                    .HasColumnName("SN_No");

                entity.Property(e => e.SnStatus)
                    .HasMaxLength(50)
                    .HasColumnName("SN_Status");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.SrStatus)
                    .HasMaxLength(50)
                    .HasColumnName("SR_Status");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StreetlightSubCategoryCode).HasMaxLength(10);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserRole).HasMaxLength(20);
            });

            modelBuilder.Entity<NewConnectionCallLog>(entity =>
            {
                entity.HasKey(e => e.NccallLogId);

                entity.ToTable("NewConnectionCallLog");

                entity.HasIndex(e => new { e.NewConnectionId, e.IsDeleted }, "IX_NewConnectionCallLog_NewConnectionID_IsDeleted");

                entity.Property(e => e.NccallLogId).HasColumnName("NCCallLogID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.NewConnection)
                    .WithMany(p => p.NewConnectionCallLogs)
                    .HasForeignKey(d => d.NewConnectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionCallLog_NewConnection");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NewConnectionCallLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionCallLog_TrnUser");
            });

            modelBuilder.Entity<NewConnectionCancelInformation>(entity =>
            {
                entity.HasKey(e => e.NccancelInfoId);

                entity.ToTable("NewConnectionCancelInformation");

                entity.HasIndex(e => e.NewConnectionId, "IX_NewConnectionCancelInformation_NewConnectionID");

                entity.Property(e => e.NccancelInfoId).HasColumnName("NCCancelInfoID");

                entity.Property(e => e.ApplicantUserId).HasColumnName("ApplicantUserID");

                entity.Property(e => e.CarelineUserId).HasColumnName("CarelineUserID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ContractorUserId).HasColumnName("ContractorUserID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.HasOne(d => d.ApplicantUser)
                    .WithMany(p => p.NewConnectionCancelInformationApplicantUsers)
                    .HasForeignKey(d => d.ApplicantUserId)
                    .HasConstraintName("FK_NewConnectionCancelInformation_TrnUserApplicantUserId");

                entity.HasOne(d => d.CarelineUser)
                    .WithMany(p => p.NewConnectionCancelInformationCarelineUsers)
                    .HasForeignKey(d => d.CarelineUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionCancelInformation_TrnUserCarelineUserID");

                entity.HasOne(d => d.ContractorUser)
                    .WithMany(p => p.NewConnectionCancelInformationContractorUsers)
                    .HasForeignKey(d => d.ContractorUserId)
                    .HasConstraintName("FK_NewConnectionCancelInformation_TrnUserContractorUserId");

                entity.HasOne(d => d.NewConnection)
                    .WithMany(p => p.NewConnectionCancelInformations)
                    .HasForeignKey(d => d.NewConnectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionCancelInformation_NewConnection");
            });

            modelBuilder.Entity<NewConnectionChangeLog>(entity =>
            {
                entity.HasKey(e => e.NclogId)
                    .HasName("PK_NewConnectionChangeLog_NCLogID");

                entity.ToTable("NewConnectionChangeLog");

                entity.Property(e => e.NclogId)
                    .HasColumnName("NCLogID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");
            });

            modelBuilder.Entity<NewConnectionContractor>(entity =>
            {
                entity.ToTable("NewConnectionContractor");

                entity.HasIndex(e => e.LastModifiedDate, "IX_NewConnectionContractor");

                entity.HasIndex(e => new { e.ContractorId, e.IsDeleted }, "IX_NewConnectionContractor_ContractorID_IsDeleted");

                entity.HasIndex(e => new { e.NewConnectionId, e.IsDeleted }, "IX_NewConnectionContractor_NewConnectionID_IsDeleted");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.NewConnectionContractors)
                    .HasForeignKey(d => d.ContractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionContractor_Contractor");

                entity.HasOne(d => d.NewConnection)
                    .WithMany(p => p.NewConnectionContractors)
                    .HasForeignKey(d => d.NewConnectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionContractor_NewConnection");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.NewConnectionContractors)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionContractor_ApplicationStatus");
            });

            modelBuilder.Entity<NewConnectionContractorBackup8Nov19>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NewConnectionContractorBackup8Nov19");

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<NewConnectionContractorBackupDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NewConnectionContractorBackup_Deleted");

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<NewConnectionFavApplication>(entity =>
            {
                entity.HasKey(e => e.FavAppId)
                    .HasName("PK_NewConnectionFavApplication_FavAppID");

                entity.ToTable("NewConnectionFavApplication");

                entity.HasIndex(e => new { e.UserId, e.RoleId, e.IsDeleted }, "IX_NewConnectionFavApplication_Filter");

                entity.Property(e => e.FavAppId)
                    .HasColumnName("FavAppID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BackendAppId).HasColumnName("BackendAppID");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<NewConnectionLandlordTenant>(entity =>
            {
                entity.HasKey(e => e.NewConnectionId);

                entity.ToTable("NewConnectionLandlordTenant");

                entity.Property(e => e.NewConnectionId)
                    .ValueGeneratedNever()
                    .HasColumnName("NewConnectionID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LandLordNewConnectionId).HasColumnName("LandLordNewConnectionID");

                entity.Property(e => e.Tagging)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.NewConnection)
                    .WithOne(p => p.NewConnectionLandlordTenant)
                    .HasForeignKey<NewConnectionLandlordTenant>(d => d.NewConnectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionLandlordTenant");
            });

            modelBuilder.Entity<NewConnectionReworkInformation>(entity =>
            {
                entity.HasKey(e => e.NcreworkInfoId);

                entity.ToTable("NewConnectionReworkInformation");

                entity.HasIndex(e => e.NewConnectionId, "IX_NewConnectionReworkInformation_NewConnectionID");

                entity.Property(e => e.NcreworkInfoId).HasColumnName("NCReworkInfoID");

                entity.Property(e => e.ApplicantUserId).HasColumnName("ApplicantUserID");

                entity.Property(e => e.CarelineUserId).HasColumnName("CarelineUserID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ContractorUserId).HasColumnName("ContractorUserID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.HasOne(d => d.ApplicantUser)
                    .WithMany(p => p.NewConnectionReworkInformationApplicantUsers)
                    .HasForeignKey(d => d.ApplicantUserId)
                    .HasConstraintName("FK_NewConnectionReworkInformation_TrnUserApplicant");

                entity.HasOne(d => d.CarelineUser)
                    .WithMany(p => p.NewConnectionReworkInformationCarelineUsers)
                    .HasForeignKey(d => d.CarelineUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionReworkInformation_TrnUserCareline");

                entity.HasOne(d => d.ContractorUser)
                    .WithMany(p => p.NewConnectionReworkInformationContractorUsers)
                    .HasForeignKey(d => d.ContractorUserId)
                    .HasConstraintName("FK_NewConnectionReworkInformation_TrnUserContractor");

                entity.HasOne(d => d.NewConnection)
                    .WithMany(p => p.NewConnectionReworkInformations)
                    .HasForeignKey(d => d.NewConnectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionReworkInformation_NewConnection");

                entity.HasOne(d => d.ReworkPartyNavigation)
                    .WithMany(p => p.NewConnectionReworkInformationReworkPartyNavigations)
                    .HasForeignKey(d => d.ReworkParty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionReworkInformation_MasterLookupReworkParty");

                entity.HasOne(d => d.ReworkReason1Navigation)
                    .WithMany(p => p.NewConnectionReworkInformationReworkReason1Navigations)
                    .HasForeignKey(d => d.ReworkReason1)
                    .HasConstraintName("FK_NewConnectionReworkInformation_MasterLookupReason1");

                entity.HasOne(d => d.ReworkReason2Navigation)
                    .WithMany(p => p.NewConnectionReworkInformationReworkReason2Navigations)
                    .HasForeignKey(d => d.ReworkReason2)
                    .HasConstraintName("FK_NewConnectionReworkInformation_MasterLookupReason2");

                entity.HasOne(d => d.ReworkReason3Navigation)
                    .WithMany(p => p.NewConnectionReworkInformationReworkReason3Navigations)
                    .HasForeignKey(d => d.ReworkReason3)
                    .HasConstraintName("FK_NewConnectionReworkInformation_MasterLookupReason3");

                entity.HasOne(d => d.ReworkReason4Navigation)
                    .WithMany(p => p.NewConnectionReworkInformationReworkReason4Navigations)
                    .HasForeignKey(d => d.ReworkReason4)
                    .HasConstraintName("FK_NewConnectionReworkInformation_MasterLookupReason4");

                entity.HasOne(d => d.ReworkReason5Navigation)
                    .WithMany(p => p.NewConnectionReworkInformationReworkReason5Navigations)
                    .HasForeignKey(d => d.ReworkReason5)
                    .HasConstraintName("FK_NewConnectionReworkInformation_MasterLookupReason5");

                entity.HasOne(d => d.ReworkReason6Navigation)
                    .WithMany(p => p.NewConnectionReworkInformationReworkReason6Navigations)
                    .HasForeignKey(d => d.ReworkReason6)
                    .HasConstraintName("FK_NewConnectionReworkInformation_MasterLookupReason6");

                entity.HasOne(d => d.ReworkReason7Navigation)
                    .WithMany(p => p.NewConnectionReworkInformationReworkReason7Navigations)
                    .HasForeignKey(d => d.ReworkReason7)
                    .HasConstraintName("FK_NewConnectionReworkInformation_MasterLookupReason7");

                entity.HasOne(d => d.ReworkReason8Navigation)
                    .WithMany(p => p.NewConnectionReworkInformationReworkReason8Navigations)
                    .HasForeignKey(d => d.ReworkReason8)
                    .HasConstraintName("FK_NewConnectionReworkInformation_MasterLookupReason8");
            });

            modelBuilder.Entity<NewConnectionStatusLog>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("NewConnectionStatusLog");

                entity.HasIndex(e => new { e.NewConnectionId, e.StatusId }, "IX_NewConnectionStatusLog_NewConnectionID_StatusID");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.SnStatus).HasColumnName("SN_Status");

                entity.Property(e => e.SrStatus).HasColumnName("SR_Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<NewConnectionSubmitSystemMessage>(entity =>
            {
                entity.HasKey(e => e.NcsubmitSysMsgId);

                entity.ToTable("NewConnectionSubmitSystemMessage");

                entity.HasIndex(e => new { e.NewConnectionId, e.IsDeleted }, "IX_NewConnectionSubmitSystemMessage_NewConnectionID_IsDeleted");

                entity.Property(e => e.NcsubmitSysMsgId).HasColumnName("NCSubmitSysMsgID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.MessageType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.HasOne(d => d.NewConnection)
                    .WithMany(p => p.NewConnectionSubmitSystemMessages)
                    .HasForeignKey(d => d.NewConnectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionSubmitSystemMessage_NewConnection");
            });

            modelBuilder.Entity<NewConnectionTechnical>(entity =>
            {
                entity.HasKey(e => e.NewConnectionId)
                    .HasName("PK__NewConne__6E44CFC5208DA12B");

                entity.ToTable("NewConnectionTechnical");

                entity.HasIndex(e => new { e.ApplicationType, e.NewConnectionId }, "IX_NewConnectionTechnical_ApplicationType_NewConnectionID");

                entity.HasIndex(e => e.NewConnectionId, "NewConnection_NewConnectionTechnical");

                entity.Property(e => e.NewConnectionId)
                    .ValueGeneratedNever()
                    .HasColumnName("NewConnectionID");

                entity.Property(e => e.AdditionalMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Amps).HasColumnName("AMPS");

                entity.Property(e => e.ApplicationType).HasMaxLength(20);

                entity.Property(e => e.CodeGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CtRatio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CT_Ratio");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExistMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeterType).HasMaxLength(20);

                entity.Property(e => e.NewMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.NoOfFeeder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PowerConsumption).HasMaxLength(20);

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.TempSupplyDate).HasColumnType("datetime");

                entity.Property(e => e.TnbstationCode).HasColumnName("TNBStationCode");

                entity.Property(e => e.TotalLoadMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.VoltageLevel).HasMaxLength(20);

                entity.Property(e => e.WeldMaxDemand).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.NewConnection)
                    .WithOne(p => p.NewConnectionTechnical)
                    .HasForeignKey<NewConnectionTechnical>(d => d.NewConnectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewConnectionTechnical_NewConnection");
            });

            modelBuilder.Entity<NewlyBuiltSubmission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'Newly Built - Submission$'");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicantType).HasMaxLength(255);

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.ContractorId)
                    .HasMaxLength(255)
                    .HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FaxNo).HasMaxLength(255);

                entity.Property(e => e.FixedLineNo).HasMaxLength(255);

                entity.Property(e => e.IdentificationNo).HasMaxLength(255);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.IsSearchByCa).HasColumnName("IsSearchByCA");

                entity.Property(e => e.LoadType).HasMaxLength(255);

                entity.Property(e => e.MailArea).HasMaxLength(255);

                entity.Property(e => e.MailCity).HasMaxLength(255);

                entity.Property(e => e.MailHouseNo).HasMaxLength(255);

                entity.Property(e => e.MailState).HasMaxLength(255);

                entity.Property(e => e.MailStreet).HasMaxLength(255);

                entity.Property(e => e.MailType).HasMaxLength(255);

                entity.Property(e => e.MobileNo).HasMaxLength(255);

                entity.Property(e => e.MothersName).HasMaxLength(255);

                entity.Property(e => e.Name1).HasMaxLength(255);

                entity.Property(e => e.Name2).HasMaxLength(255);

                entity.Property(e => e.NextOfKinEmail).HasMaxLength(255);

                entity.Property(e => e.NextOfKinName2).HasMaxLength(255);

                entity.Property(e => e.NextOfKinPhoneNo).HasMaxLength(255);

                entity.Property(e => e.PremiseArea).HasMaxLength(255);

                entity.Property(e => e.PremiseCategory).HasMaxLength(255);

                entity.Property(e => e.PremiseCity).HasMaxLength(255);

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(255);

                entity.Property(e => e.PremiseState).HasMaxLength(255);

                entity.Property(e => e.PremiseStreet).HasMaxLength(255);

                entity.Property(e => e.PremiseType).HasMaxLength(255);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode).HasMaxLength(255);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<NotMigratedProjectParcel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NotMigrated_ProjectParcel$");

                entity.Property(e => e.BalanceInECibs)
                    .HasMaxLength(255)
                    .HasColumnName("Balance in eCIBS");

                entity.Property(e => e.DeveloperName)
                    .HasMaxLength(255)
                    .HasColumnName("Developer Name");

                entity.Property(e => e.FlPostcode).HasColumnName("FL: Postcode");

                entity.Property(e => e.FlState)
                    .HasMaxLength(255)
                    .HasColumnName("FL: State");

                entity.Property(e => e.FlTownArea)
                    .HasMaxLength(255)
                    .HasColumnName("FL: Town/Area");

                entity.Property(e => e.GroupNcNo).HasColumnName("Group NC No#");

                entity.Property(e => e.MaterialDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Material Description");

                entity.Property(e => e.MaximumDemandForMvLoadOnly)
                    .HasMaxLength(255)
                    .HasColumnName("Maximum Demand - for MV load only");

                entity.Property(e => e.MeterTypeForMvLoadOnly)
                    .HasMaxLength(255)
                    .HasColumnName("Meter Type- for MV load only");

                entity.Property(e => e.ParcelDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Parcel Description");

                entity.Property(e => e.ParcelId)
                    .HasMaxLength(255)
                    .HasColumnName("Parcel ID");

                entity.Property(e => e.PremiseDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Premise Description");

                entity.Property(e => e.ProjectCreatorEmail)
                    .HasMaxLength(255)
                    .HasColumnName("Project Creator (Email)");

                entity.Property(e => e.StationCode).HasColumnName("Station Code");

                entity.Property(e => e.TnbProjectId).HasColumnName("TNB Project ID");

                entity.Property(e => e.TotalNumberOfUnitEcibs)
                    .HasMaxLength(255)
                    .HasColumnName("Total Number of Unit (ECIBS)");

                entity.Property(e => e.TotalNumberOfUnitsNotSubmittedParcel).HasColumnName("Total number of units NOT SUBMITTED (Parcel)");

                entity.Property(e => e.TotalNumberOfUnitsParcel).HasColumnName("Total number of units (Parcel)");

                entity.Property(e => e.TotalNumberOfUnitsProject).HasColumnName("Total Number of Units (Project)");

                entity.Property(e => e.TotalUnitSubmittedEcibs)
                    .HasMaxLength(255)
                    .HasColumnName("Total Unit Submitted (ECIBS)");

                entity.Property(e => e.VoltageLevelForMvLoadOnly)
                    .HasMaxLength(255)
                    .HasColumnName("Voltage Level - for MV load only");
            });

            modelBuilder.Entity<OpowerTnbrecipient>(entity =>
            {
                entity.ToTable("OpowerTNBRecipient");

                entity.HasIndex(e => e.CreatedBy, "CreatedBy_IDX");

                entity.HasIndex(e => e.AccountNumber, "IX_OpowerTNBRecipient_AccountNumber");

                entity.HasIndex(e => e.LastModifiedBy, "LastModifiedBy_IDX");

                entity.HasIndex(e => e.LegacyCustomerNumber, "LegacyCustomerNumber_IDX");

                entity.HasIndex(e => e.LegacyStationCode, "LegacyStationCode_IDX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LegacyCustomerNumber).HasMaxLength(20);

                entity.Property(e => e.LegacyStationCode).HasMaxLength(20);
            });

            modelBuilder.Entity<Otp>(entity =>
            {
                entity.ToTable("Otp");

                entity.Property(e => e.OtpId)
                    .HasColumnName("OtpID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.ExpireDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNumber).HasMaxLength(20);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");
            });

            modelBuilder.Entity<OutBoundWebServiceLog>(entity =>
            {
                entity.ToTable("OutBoundWebServiceLog");

                entity.Property(e => e.OutBoundWebServiceLogId)
                    .ValueGeneratedNever()
                    .HasColumnName("OutBoundWebServiceLogID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.InputOutBoundWebServiceLogId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("InputOutBoundWebServiceLogID");

                entity.Property(e => e.IpAddress).HasMaxLength(25);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MethodName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentBlockedCa>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_PaymentBlockedCA_Guid");

                entity.ToTable("PaymentBlockedCA");

                entity.HasIndex(e => e.ContractAccountNo, "IX_PaymentBlockedCA_ContractAccountNo");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ContractAccountNo).HasMaxLength(250);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PaymentBlockedEmail>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_PaymentBlockedEmail_Guid");

                entity.ToTable("PaymentBlockedEmail");

                entity.HasIndex(e => e.Email, "IX_PaymentBlockedEmail_Email");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PaymentBlockedMobileNo>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_PaymentBlockedMobileNo_Guid");

                entity.ToTable("PaymentBlockedMobileNo");

                entity.HasIndex(e => e.MobileNo, "IX_PaymentBlockedMobileNo_MobileNo");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo).HasMaxLength(250);
            });

            modelBuilder.Entity<PaymentReceipt>(entity =>
            {
                entity.ToTable("PaymentReceipt");

                entity.HasIndex(e => e.AccountNo, "IX_PaymentReceipt_AccountNo");

                entity.HasIndex(e => e.GroupPaymentId, "IX_PaymentReceipt_GroupPaymentID");

                entity.HasIndex(e => e.ResTransactionStatus, "IX_PaymentReceipt_IsDeleted");

                entity.Property(e => e.PaymentReceiptId).HasColumnName("PaymentReceiptID");

                entity.Property(e => e.AccountNo).HasMaxLength(20);

                entity.Property(e => e.Browser).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalReferenceNo).HasMaxLength(16);

                entity.Property(e => e.GroupPaymentId).HasColumnName("GroupPaymentID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(100)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NextTryDate).HasColumnType("datetime");

                entity.Property(e => e.OneTimeRequeryDateTime).HasColumnType("datetime");

                entity.Property(e => e.OneTimeRequeryNextTry).HasColumnType("datetime");

                entity.Property(e => e.PaymentKey).HasMaxLength(4);

                entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");

                entity.Property(e => e.PgresponseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PGResponseDate");

                entity.Property(e => e.PremiseAddress).IsUnicode(false);

                entity.Property(e => e.ReferenceNo).HasMaxLength(16);

                entity.Property(e => e.RepostDate).HasColumnType("datetime");

                entity.Property(e => e.ReqAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ReqCustomerEmail)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReqCustomerMobileNo).HasMaxLength(30);

                entity.Property(e => e.ReqCustomerName)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.ReqDescription)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ReqPaymentMethod)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ReqTriggerUrl)
                    .IsRequired()
                    .HasColumnName("ReqTriggerURL");

                entity.Property(e => e.RequeryCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ResAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ResAuthCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResCardNo).HasMaxLength(20);

                entity.Property(e => e.ResCardType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ResCustomerName).HasMaxLength(120);

                entity.Property(e => e.ResErrorCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResErrorDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ResEui)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ResEUI");

                entity.Property(e => e.ResIsOnUs)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ResPaymentMethod)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ResTransactionId).HasColumnName("ResTransactionID");

                entity.Property(e => e.ResTransactionStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SocemailDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("SOCEmailDateTime");

                entity.Property(e => e.SocemailTriggered).HasColumnName("SOCEmailTriggered");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.PaymentReceipts)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentReceipt_PaymentStatus");
            });

            modelBuilder.Entity<PaymentReceiptBackup8Nov19>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PaymentReceiptBackup8Nov19");

                entity.Property(e => e.AccountNo).HasMaxLength(20);

                entity.Property(e => e.Browser).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupPaymentId).HasColumnName("GroupPaymentID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(100)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NextTryDate).HasColumnType("datetime");

                entity.Property(e => e.OneTimeRequeryDateTime).HasColumnType("datetime");

                entity.Property(e => e.OneTimeRequeryNextTry).HasColumnType("datetime");

                entity.Property(e => e.PaymentReceiptId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PaymentReceiptID");

                entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");

                entity.Property(e => e.PgresponseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PGResponseDate");

                entity.Property(e => e.PremiseAddress).IsUnicode(false);

                entity.Property(e => e.ReferenceNo).HasMaxLength(4000);

                entity.Property(e => e.RepostDate).HasColumnType("datetime");

                entity.Property(e => e.ReqAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ReqCustomerEmail)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReqCustomerMobileNo).HasMaxLength(30);

                entity.Property(e => e.ReqCustomerName)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.ReqDescription)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ReqPaymentMethod)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ReqTriggerUrl)
                    .IsRequired()
                    .HasColumnName("ReqTriggerURL");

                entity.Property(e => e.ResAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ResAuthCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResCardNo).HasMaxLength(20);

                entity.Property(e => e.ResCardType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ResCustomerName).HasMaxLength(120);

                entity.Property(e => e.ResErrorCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResErrorDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ResEui)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ResEUI");

                entity.Property(e => e.ResIsOnUs)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ResPaymentMethod)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ResTransactionId).HasColumnName("ResTransactionID");

                entity.Property(e => e.ResTransactionStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PaymentReceiptDetail>(entity =>
            {
                entity.ToTable("PaymentReceiptDetail");

                entity.HasIndex(e => e.AccountId, "IX_PaymentReceiptDetail_AccountID");

                entity.HasIndex(e => new { e.AccountNo, e.BcrmpaymentDocNo }, "IX_PaymentReceiptDetail_AccountNo_BCRMPaymentDocNo");

                entity.HasIndex(e => e.Cotid, "IX_PaymentReceiptDetail_COTID");

                entity.HasIndex(e => e.GreenTariffId, "IX_PaymentReceiptDetail_GreenTariffID");

                entity.HasIndex(e => e.GroupPaymentId, "IX_PaymentReceiptDetail_GroupPaymentID");

                entity.HasIndex(e => e.NewConnectionId, "IX_PaymentReceiptDetail_NewConnectionID");

                entity.HasIndex(e => e.ProjectId, "IX_PaymentReceiptDetail_ProjectID");

                entity.HasIndex(e => e.Reid, "IX_PaymentReceiptDetail_REID");

                entity.HasIndex(e => e.RevenueCode, "IX_PaymentReceiptDetail_RevenueCode");

                entity.HasIndex(e => e.RewiringId, "IX_PaymentReceiptDetail_RewiringID");

                entity.Property(e => e.PaymentReceiptDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("PaymentReceiptDetailID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountNo).HasMaxLength(20);

                entity.Property(e => e.Amount1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Amount2).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Amount3).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BackendAppId).HasColumnName("BackendAppID");

                entity.Property(e => e.BcrmpaymentDocNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BCRMPaymentDocNo");

                entity.Property(e => e.Cotid).HasColumnName("COTID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FavAppId).HasColumnName("FavAppID");

                entity.Property(e => e.GreenTariffId).HasColumnName("GreenTariffID");

                entity.Property(e => e.GroupPaymentId).HasColumnName("GroupPaymentID");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.OutstandingAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OwnerName).HasMaxLength(80);

                entity.Property(e => e.PaidAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Reid).HasColumnName("REID");

                entity.Property(e => e.ReturnCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RevenueCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RewiringId).HasColumnName("RewiringID");
            });

            modelBuilder.Entity<PaymentReceiptDetailBackup8Nov19>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PaymentReceiptDetailBackup8Nov19");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountNo).HasMaxLength(20);

                entity.Property(e => e.Amount1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Amount2).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Amount3).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BcrmpaymentDocNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BCRMPaymentDocNo");

                entity.Property(e => e.Cotid).HasColumnName("COTID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GreenTariffId).HasColumnName("GreenTariffID");

                entity.Property(e => e.GroupPaymentId).HasColumnName("GroupPaymentID");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.OutstandingAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OwnerName).HasMaxLength(80);

                entity.Property(e => e.PaidAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PaymentReceiptDetailId).HasColumnName("PaymentReceiptDetailID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Reid).HasColumnName("REID");

                entity.Property(e => e.ReturnCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RevenueCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RewiringId).HasColumnName("RewiringID");
            });

            modelBuilder.Entity<PaymentReceiptLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__PaymentR__5E5499A876F70C25");

                entity.ToTable("PaymentReceipt_Logs");

                entity.Property(e => e.LogId)
                    .HasColumnName("LogID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountNo).HasMaxLength(20);

                entity.Property(e => e.Browser).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupPaymentId).HasColumnName("GroupPaymentID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(100)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LogOperation)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LogTime).HasColumnType("datetime");

                entity.Property(e => e.NextTryDate).HasColumnType("datetime");

                entity.Property(e => e.OneTimeRequeryDateTime).HasColumnType("datetime");

                entity.Property(e => e.OneTimeRequeryNextTry).HasColumnType("datetime");

                entity.Property(e => e.PaymentReceiptId).HasColumnName("PaymentReceiptID");

                entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");

                entity.Property(e => e.PgresponseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PGResponseDate");

                entity.Property(e => e.PremiseAddress).IsUnicode(false);

                entity.Property(e => e.ReferenceNo).HasMaxLength(16);

                entity.Property(e => e.RepostDate).HasColumnType("datetime");

                entity.Property(e => e.ReqAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ReqCustomerEmail)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReqCustomerMobileNo).HasMaxLength(30);

                entity.Property(e => e.ReqCustomerName)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.ReqDescription)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ReqPaymentMethod)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ReqTriggerUrl)
                    .IsRequired()
                    .HasColumnName("ReqTriggerURL");

                entity.Property(e => e.ResAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ResAuthCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResCardNo).HasMaxLength(20);

                entity.Property(e => e.ResCardType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ResCustomerName).HasMaxLength(120);

                entity.Property(e => e.ResErrorCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResErrorDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ResEui)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ResEUI");

                entity.Property(e => e.ResIsOnUs)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ResPaymentMethod)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ResTransactionId).HasColumnName("ResTransactionID");

                entity.Property(e => e.ResTransactionStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PaymentReceiptQueue>(entity =>
            {
                entity.ToTable("PaymentReceiptQueue");

                entity.Property(e => e.PaymentReceiptQueueId)
                    .ValueGeneratedNever()
                    .HasColumnName("PaymentReceiptQueueID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NextTryDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentReceiptId).HasColumnName("PaymentReceiptID");

                entity.Property(e => e.SentDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PaymentReceiptTrace>(entity =>
            {
                entity.ToTable("PaymentReceiptTrace");

                entity.Property(e => e.PaymentReceiptTraceId)
                    .ValueGeneratedNever()
                    .HasColumnName("PaymentReceiptTraceID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NextTryDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentReceiptId).HasColumnName("PaymentReceiptID");

                entity.Property(e => e.ReturnCode).HasMaxLength(2);

                entity.Property(e => e.SentDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PaymentStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK_EBulkStatus");

                entity.ToTable("PaymentStatus");

                entity.Property(e => e.StatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("StatusID");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusCode).HasMaxLength(10);

                entity.Property(e => e.StatusDescription).HasMaxLength(30);
            });

            modelBuilder.Entity<PremiseTypeHeader>(entity =>
            {
                entity.ToTable("PremiseTypeHeader");

                entity.Property(e => e.PremiseTypeHeaderId)
                    .ValueGeneratedNever()
                    .HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.AdId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AD_ID")
                    .HasDefaultValueSql("('DM')")
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PremiseDesc).HasMaxLength(50);
            });

            modelBuilder.Entity<PremiseTypeItem>(entity =>
            {
                entity.HasKey(e => e.PremiseTypeItemCode)
                    .HasName("pk_premise_type_code");

                entity.ToTable("PremiseTypeItem");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ErmsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ERMS_Code");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PremiseDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.HasOne(d => d.PremiseTypeHeader)
                    .WithMany(p => p.PremiseTypeItems)
                    .HasForeignKey(d => d.PremiseTypeHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PremiseTypeItem_PremiseTypeHeader");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.HasIndex(e => e.UserId, "IX_Project");

                entity.HasIndex(e => e.ProjectName, "IX_Project_ProjectName");

                entity.HasIndex(e => e.TnbProjectId, "IX_Project_TNB_ProjectID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicationModuleId)
                    .HasColumnName("ApplicationModuleID")
                    .HasDefaultValueSql("((101010))");

                entity.Property(e => e.BillingEmail).HasMaxLength(241);

                entity.Property(e => e.BpNo)
                    .HasMaxLength(20)
                    .HasColumnName("BP_No");

                entity.Property(e => e.Bpbuilding)
                    .HasMaxLength(40)
                    .HasColumnName("BPBuilding");

                entity.Property(e => e.Bpcity)
                    .HasMaxLength(40)
                    .HasColumnName("BPCity");

                entity.Property(e => e.Bpcountry)
                    .HasMaxLength(3)
                    .HasColumnName("BPCountry");

                entity.Property(e => e.BpfaxNo)
                    .HasMaxLength(15)
                    .HasColumnName("BPFaxNo");

                entity.Property(e => e.BphouseNo)
                    .HasMaxLength(10)
                    .HasColumnName("BPHouseNo");

                entity.Property(e => e.BppostalCode)
                    .HasMaxLength(10)
                    .HasColumnName("BPPostalCode");

                entity.Property(e => e.BppropertyType)
                    .HasMaxLength(1)
                    .HasColumnName("BPPropertyType");

                entity.Property(e => e.Bpstate)
                    .HasMaxLength(3)
                    .HasColumnName("BPState");

                entity.Property(e => e.Bpstreet)
                    .HasMaxLength(60)
                    .HasColumnName("BPStreet");

                entity.Property(e => e.Bptown)
                    .HasMaxLength(60)
                    .HasColumnName("BPTown");

                entity.Property(e => e.BpunitNo)
                    .HasMaxLength(10)
                    .HasColumnName("BPUnitNo");

                entity.Property(e => e.CaNo)
                    .HasMaxLength(14)
                    .HasColumnName("CA_No");

                entity.Property(e => e.Cctotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CCTotal");

                entity.Property(e => e.CodeGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBpNo)
                    .HasMaxLength(20)
                    .HasColumnName("ContactBP_No");

                entity.Property(e => e.ContactPersonEmailAddress).HasMaxLength(240);

                entity.Property(e => e.ContactPersonMobileNo).HasMaxLength(20);

                entity.Property(e => e.ContactPersonName1).HasMaxLength(40);

                entity.Property(e => e.ContactPersonName2).HasMaxLength(40);

                entity.Property(e => e.ContactPersonPosition).HasMaxLength(20);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerBpNo)
                    .HasMaxLength(20)
                    .HasColumnName("CustomerBP_No");

                entity.Property(e => e.CustomerBpmismatchFlag).HasColumnName("CustomerBPMismatchFlag");

                entity.Property(e => e.CustomerDob)
                    .HasColumnType("date")
                    .HasColumnName("CustomerDOB");

                entity.Property(e => e.CustomerEmail).HasMaxLength(240);

                entity.Property(e => e.CustomerFaxNo).HasMaxLength(15);

                entity.Property(e => e.CustomerFixedLineNo).HasMaxLength(15);

                entity.Property(e => e.CustomerGivenTitleId).HasColumnName("CustomerGivenTitleID");

                entity.Property(e => e.CustomerIdentificationNo).HasMaxLength(20);

                entity.Property(e => e.CustomerIdentificationTypeId).HasColumnName("CustomerIdentificationTypeID");

                entity.Property(e => e.CustomerMobileNo).HasMaxLength(15);

                entity.Property(e => e.CustomerMothersName).HasMaxLength(40);

                entity.Property(e => e.CustomerName1).HasMaxLength(40);

                entity.Property(e => e.CustomerName2).HasMaxLength(40);

                entity.Property(e => e.CustomerPremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.CustomerPremiseCity).HasMaxLength(40);

                entity.Property(e => e.CustomerPremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.CustomerPremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.CustomerPremisePropertyType).HasMaxLength(1);

                entity.Property(e => e.CustomerPremiseState).HasMaxLength(20);

                entity.Property(e => e.CustomerPremiseStreet).HasMaxLength(60);

                entity.Property(e => e.CustomerPremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.CustomerPremiseTownArea).HasMaxLength(40);

                entity.Property(e => e.CustomerPremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.CustomerSalutationId).HasColumnName("CustomerSalutationID");

                entity.Property(e => e.DeclaredMd)
                    .HasMaxLength(20)
                    .HasColumnName("DeclaredMD");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EContractorId).HasColumnName("eContractorID");

                entity.Property(e => e.FixedLineNo).HasMaxLength(15);

                entity.Property(e => e.GeapplicationType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GEApplicationType");

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.IsAcknowledge).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsGeeligible).HasColumnName("IsGEEligible");

                entity.Property(e => e.IsParcelReduce).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSearchByCa).HasColumnName("IsSearchByCA");

                entity.Property(e => e.IsTnc)
                    .HasColumnName("IsTNC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.LoadType)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(1);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinEmail).HasMaxLength(240);

                entity.Property(e => e.NextOfKinName1).HasMaxLength(40);

                entity.Property(e => e.NextOfKinName2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinPhoneNo).HasMaxLength(15);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseOwnerAccountTypeId).HasColumnName("PremiseOwnerAccountTypeID");

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseSubStation).HasMaxLength(30);

                entity.Property(e => e.PremiseTown).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.ProformaInvNo).HasMaxLength(10);

                entity.Property(e => e.ProjectName).HasMaxLength(100);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([ProjectID],'PRJ-000-000-0000'))", false);

                entity.Property(e => e.RequiredDate).HasColumnType("date");

                entity.Property(e => e.SnNo)
                    .HasMaxLength(20)
                    .HasColumnName("SN_No");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.SrapplicationDetail).HasColumnName("SRApplicationDetail");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StationCodeErms)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("StationCodeERMS")
                    .IsFixedLength(true);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StreetlightSubCategoryCode).HasMaxLength(10);

                entity.Property(e => e.SupplyType).HasMaxLength(10);

                entity.Property(e => e.TnbProjectId)
                    .HasMaxLength(16)
                    .HasColumnName("TNB_ProjectID");

                entity.Property(e => e.TypeOfForm)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VoltageLevel).HasMaxLength(10);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_ApplicationStatus");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_TrnUser");
            });

            modelBuilder.Entity<ProjectAttachment>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("ProjectAttachment");

                entity.HasIndex(e => new { e.ProjectId, e.FileGroupId, e.IsDeleted }, "IX_ProjectAttachment_ProjectID_FileGroupID_IsDeleted");

                entity.Property(e => e.FileId)
                    .ValueGeneratedNever()
                    .HasColumnName("FileID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileGroupId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("FileGroupID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.File)
                    .WithOne(p => p.ProjectAttachment)
                    .HasForeignKey<ProjectAttachment>(d => d.FileId)
                    .HasConstraintName("FK_ProjectAttachment_ApplicationFileUpload");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectAttachments)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectAttachment_Project");
            });

            modelBuilder.Entity<ProjectAttachment18022021Bk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProjectAttachment_18022021_BK");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileGroupId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("FileGroupID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            });

            modelBuilder.Entity<ProjectCallLog>(entity =>
            {
                entity.ToTable("ProjectCallLog");

                entity.Property(e => e.ProjectCallLogId).HasColumnName("ProjectCallLogID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectCallLogs)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectCallLog_Project");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProjectCallLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectCallLog_TrnUser");
            });

            modelBuilder.Entity<ProjectCancelInformation>(entity =>
            {
                entity.HasKey(e => e.ProjectCancelInfoId);

                entity.ToTable("ProjectCancelInformation");

                entity.Property(e => e.ProjectCancelInfoId).HasColumnName("ProjectCancelInfoID");

                entity.Property(e => e.ApplicantUserId).HasColumnName("ApplicantUserID");

                entity.Property(e => e.CarelineUserId).HasColumnName("CarelineUserID");

                entity.Property(e => e.Comment).HasMaxLength(250);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.ApplicantUser)
                    .WithMany(p => p.ProjectCancelInformationApplicantUsers)
                    .HasForeignKey(d => d.ApplicantUserId)
                    .HasConstraintName("FK_ProjectCancelInformation_TrnUser");

                entity.HasOne(d => d.CarelineUser)
                    .WithMany(p => p.ProjectCancelInformationCarelineUsers)
                    .HasForeignKey(d => d.CarelineUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectCancelInformation_TrnUser1");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectCancelInformations)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectCancelInformation_Project");
            });

            modelBuilder.Entity<ProjectChangeLog>(entity =>
            {
                entity.HasKey(e => e.ProjectLogId)
                    .HasName("PK_ProjectChangeLog_ProjectLogID");

                entity.ToTable("ProjectChangeLog");

                entity.Property(e => e.ProjectLogId)
                    .HasColumnName("ProjectLogID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            });

            modelBuilder.Entity<ProjectConsultant>(entity =>
            {
                entity.HasKey(e => e.ConsultantId)
                    .HasName("PK_ProjectConsultant_1");

                entity.ToTable("ProjectConsultant");

                entity.HasIndex(e => e.ProjectId, "IX_ProjectConsultant_ProjectID");

                entity.Property(e => e.ConsultantId).HasColumnName("ConsultantID");

                entity.Property(e => e.Building).HasMaxLength(40);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.FixedLineNo)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.HouseNo).HasMaxLength(10);

                entity.Property(e => e.IdentificationNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.PropertyType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Town)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UnitNo).HasMaxLength(10);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectConsultants)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectConsultant_Project");
            });

            modelBuilder.Entity<ProjectContractor>(entity =>
            {
                entity.HasKey(e => e.ContractorId);

                entity.ToTable("ProjectContractor");

                entity.HasIndex(e => e.ProjectId, "IX_ProjectContractor_ProjectID");

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.Building).HasMaxLength(40);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.FixedLineNo)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.HouseNo).HasMaxLength(10);

                entity.Property(e => e.IdentificationNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.PropertyType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Town)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UnitNo).HasMaxLength(10);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectContractors)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectContractor_Project");
            });

            modelBuilder.Entity<ProjectFavApplication>(entity =>
            {
                entity.HasKey(e => e.FavAppId)
                    .HasName("PK_ProjectFavApplication_FavAppID");

                entity.ToTable("ProjectFavApplication");

                entity.HasIndex(e => new { e.UserId, e.RoleId, e.IsDeleted }, "IX_ProjectFavApplication_Filter");

                entity.Property(e => e.FavAppId)
                    .HasColumnName("FavAppID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BackendAppId).HasColumnName("BackendAppID");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ProjectParcel>(entity =>
            {
                entity.HasKey(e => e.ParcelId);

                entity.ToTable("ProjectParcel");

                entity.HasIndex(e => new { e.ProjectId, e.IsDeleted }, "IX_ProjectParcel_ProjectID_IsDeleted");

                entity.Property(e => e.ParcelId).HasColumnName("ParcelID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.IndicatorFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mdid).HasColumnName("MDID");

                entity.Property(e => e.MeterDeclared).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MeterType).HasMaxLength(20);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ServiceType).HasMaxLength(20);

                entity.Property(e => e.Sonumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SONumber");

                entity.Property(e => e.Sotype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SOType");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StreetlightSubCategoryCode).HasMaxLength(10);

                entity.Property(e => e.VoltageLevel).HasMaxLength(20);
            });

            modelBuilder.Entity<ProjectPic>(entity =>
            {
                entity.ToTable("ProjectPIC");

                entity.HasIndex(e => e.ProjectId, "IX_ProjectPIC_ProjectID");

                entity.HasIndex(e => e.UserId, "IX_ProjectPIC_UserID");

                entity.Property(e => e.ProjectPicId).HasColumnName("ProjectPIC_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(240);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.PhoneNo).HasMaxLength(15);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectPics)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectPIC_Project");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.ProjectPics)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectPIC_MasterLookup");
            });

            modelBuilder.Entity<ProjectReworkInformation>(entity =>
            {
                entity.HasKey(e => e.ProjectReworkInfoId);

                entity.ToTable("ProjectReworkInformation");

                entity.Property(e => e.ProjectReworkInfoId).HasColumnName("ProjectReworkInfoID");

                entity.Property(e => e.ApplicantUserId).HasColumnName("ApplicantUserID");

                entity.Property(e => e.CarelineUserId).HasColumnName("CarelineUserID");

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.ApplicantUser)
                    .WithMany(p => p.ProjectReworkInformationApplicantUsers)
                    .HasForeignKey(d => d.ApplicantUserId)
                    .HasConstraintName("FK_ProjectReworkInformation_TrnUser");

                entity.HasOne(d => d.CarelineUser)
                    .WithMany(p => p.ProjectReworkInformationCarelineUsers)
                    .HasForeignKey(d => d.CarelineUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectReworkInformation_TrnUser1");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectReworkInformations)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectReworkInformation_Project");

                entity.HasOne(d => d.ReworkPartyNavigation)
                    .WithMany(p => p.ProjectReworkInformations)
                    .HasForeignKey(d => d.ReworkParty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectReworkInformation_MasterLookup");
            });

            modelBuilder.Entity<ProjectStatusLog>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("ProjectStatusLog");

                entity.HasIndex(e => new { e.ProjectId, e.StatusId }, "IX_ProjectStatusLog_ProjectID_StatusID");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ProjectStatusMonitoring>(entity =>
            {
                entity.HasKey(e => e.ProjectStatusMonId);

                entity.ToTable("ProjectStatusMonitoring");

                entity.HasIndex(e => e.ProjectId, "IX_ProjectStatusMonitoring_ProjectID");

                entity.Property(e => e.ProjectStatusMonId).HasColumnName("ProjectStatusMonID");

                entity.Property(e => e.CompletedDate).HasColumnType("date");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LookupId).HasColumnName("LookupID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.TnbProjectId)
                    .HasMaxLength(16)
                    .HasColumnName("TNB_ProjectID");
            });

            modelBuilder.Entity<ProjectSubmitSystemMessage>(entity =>
            {
                entity.HasKey(e => e.PrjsubmitSysMsgId);

                entity.ToTable("ProjectSubmitSystemMessage");

                entity.Property(e => e.PrjsubmitSysMsgId).HasColumnName("PRJSubmitSysMsgID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.MessageType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            });

            modelBuilder.Entity<PurposeOfPremise>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PurposeOfPremise");

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PurposeDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PurposeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PurposeID");
            });

            modelBuilder.Entity<PwdManagement>(entity =>
            {
                entity.ToTable("PwdManagement");

                entity.HasIndex(e => e.UserId, "IX_PwdManagement_UserID");

                entity.HasIndex(e => new { e.UserId, e.ExpiryDate }, "IX_PwdManagement_UserID_ExpiryDate");

                entity.Property(e => e.PwdManagementId).HasColumnName("PwdManagementID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TempKey).IsRequired();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PwdManagements)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PwdManagement_UserID");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.Questions)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QuestionAnswer>(entity =>
            {
                entity.HasOne(d => d.AnswerSetNavigation)
                    .WithMany(p => p.QuestionAnswers)
                    .HasForeignKey(d => d.AnswerSet)
                    .HasConstraintName("FK_QuestionAnswers_AnswerSet");

                entity.HasOne(d => d.AnswerTypeNavigation)
                    .WithMany(p => p.QuestionAnswers)
                    .HasForeignKey(d => d.AnswerType)
                    .HasConstraintName("FK_QuestionAnswers_AnswerType");

                entity.HasOne(d => d.QuestionCategoryNavigation)
                    .WithMany(p => p.QuestionAnswers)
                    .HasForeignKey(d => d.QuestionCategory)
                    .HasConstraintName("FK_QuestionAnswers_QuestionCategory");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionAnswers)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_QuestionAnswers_QuestionId");
            });

            modelBuilder.Entity<QuestionCategory>(entity =>
            {
                entity.ToTable("QuestionCategory");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QuestionPrequesiteSet>(entity =>
            {
                entity.ToTable("QuestionPrequesiteSet");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AnswerValue).HasMaxLength(1000);

                entity.Property(e => e.QuestionDescription).HasMaxLength(1000);

                entity.HasOne(d => d.PreviousQuestion)
                    .WithMany(p => p.QuestionPrequesiteSetPreviousQuestions)
                    .HasForeignKey(d => d.PreviousQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionPrequesiteSet_PreviousQuestionId");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionPrequesiteSetQuestions)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionPrequesiteSet_QuestionId");
            });

            modelBuilder.Entity<RecontractManagement>(entity =>
            {
                entity.ToTable("REContractManagement");

                entity.Property(e => e.RecontractManagementId).HasColumnName("REContractManagementID");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.AuthEmail).HasMaxLength(50);

                entity.Property(e => e.AuthFaxNo).HasMaxLength(20);

                entity.Property(e => e.AuthMobileNo).HasMaxLength(20);

                entity.Property(e => e.AuthName).HasMaxLength(50);

                entity.Property(e => e.AuthName2).HasMaxLength(50);

                entity.Property(e => e.AuthOfficePhoneNo).HasMaxLength(20);

                entity.Property(e => e.AuthPosition).HasMaxLength(50);

                entity.Property(e => e.CabankAccountName)
                    .HasMaxLength(50)
                    .HasColumnName("CABankAccountName");

                entity.Property(e => e.CabankAccountNo)
                    .HasMaxLength(32)
                    .HasColumnName("CABankAccountNo");

                entity.Property(e => e.CabankCode)
                    .HasMaxLength(10)
                    .HasColumnName("CABankCode");

                entity.Property(e => e.CafiahAppNo)
                    .HasMaxLength(50)
                    .HasColumnName("CAFiahAppNo");

                entity.Property(e => e.CafiahPreFix)
                    .HasMaxLength(10)
                    .HasColumnName("CAFiahPreFix");

                entity.Property(e => e.Cagstno)
                    .HasMaxLength(12)
                    .HasColumnName("CAGSTNo");

                entity.Property(e => e.CagstvalidationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CAGSTValidationDate");

                entity.Property(e => e.ContractorName).HasMaxLength(50);

                entity.Property(e => e.ContractorRocno)
                    .HasMaxLength(14)
                    .HasColumnName("ContractorROCNo");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FaxNo).HasMaxLength(20);

                entity.Property(e => e.GenerationCapacityCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GivenTitleCode).HasMaxLength(50);

                entity.Property(e => e.GivenTitleId).HasColumnName("GivenTitleID");

                entity.Property(e => e.HomePhoneNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MailAddrTag).HasMaxLength(10);

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(50);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.MeterDetailsCtsize)
                    .HasMaxLength(25)
                    .HasColumnName("MeterDetailsCTSize");

                entity.Property(e => e.MeterDetailsVoltageId).HasColumnName("MeterDetailsVoltageID");

                entity.Property(e => e.MobileNo).HasMaxLength(20);

                entity.Property(e => e.MothersName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Name2).HasMaxLength(50);

                entity.Property(e => e.NetExportCapacityApprv).HasMaxLength(25);

                entity.Property(e => e.Nokemail)
                    .HasMaxLength(50)
                    .HasColumnName("NOKEmail");

                entity.Property(e => e.NokhomePhoneNo)
                    .HasMaxLength(20)
                    .HasColumnName("NOKHomePhoneNo");

                entity.Property(e => e.NokmobileNo)
                    .HasMaxLength(20)
                    .HasColumnName("NOKMobileNo");

                entity.Property(e => e.Nokname)
                    .HasMaxLength(50)
                    .HasColumnName("NOKName");

                entity.Property(e => e.Nokname2)
                    .HasMaxLength(50)
                    .HasColumnName("NOKName2");

                entity.Property(e => e.NokofficePhoneNo)
                    .HasMaxLength(20)
                    .HasColumnName("NOKOfficePhoneNo");

                entity.Property(e => e.PaymentRefStatus).HasMaxLength(10);

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(10);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(50);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.Recmguid)
                    .HasColumnName("RECMGuid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([REContractManagementID],'RE 000-000-0000'))", false);

                entity.Property(e => e.Rocno)
                    .HasMaxLength(14)
                    .HasColumnName("ROCNo");

                entity.Property(e => e.SalutationCode).HasMaxLength(50);

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.ServiceRequestNo).HasMaxLength(30);

                entity.Property(e => e.Sparea)
                    .HasMaxLength(50)
                    .HasColumnName("SPArea");

                entity.Property(e => e.Spbuilding)
                    .HasMaxLength(40)
                    .HasColumnName("SPBuilding");

                entity.Property(e => e.Spcity)
                    .HasMaxLength(50)
                    .HasColumnName("SPCity");

                entity.Property(e => e.Spemail)
                    .HasMaxLength(50)
                    .HasColumnName("SPEmail");

                entity.Property(e => e.SphouseNo)
                    .HasMaxLength(10)
                    .HasColumnName("SPHouseNo");

                entity.Property(e => e.SpmobileNo)
                    .HasMaxLength(20)
                    .HasColumnName("SPMobileNo");

                entity.Property(e => e.Spname)
                    .HasMaxLength(50)
                    .HasColumnName("SPName");

                entity.Property(e => e.SpofficePhoneNo)
                    .HasMaxLength(20)
                    .HasColumnName("SPOfficePhoneNo");

                entity.Property(e => e.SppostalCode)
                    .HasMaxLength(10)
                    .HasColumnName("SPPostalCode");

                entity.Property(e => e.Sprocno)
                    .HasMaxLength(14)
                    .HasColumnName("SPROCNo");

                entity.Property(e => e.Spstate)
                    .HasMaxLength(20)
                    .HasColumnName("SPState");

                entity.Property(e => e.Spstreet)
                    .HasMaxLength(60)
                    .HasColumnName("SPStreet");

                entity.Property(e => e.Sptype)
                    .HasMaxLength(25)
                    .HasColumnName("SPType");

                entity.Property(e => e.SpunitNo)
                    .HasMaxLength(10)
                    .HasColumnName("SPUnitNo");

                entity.Property(e => e.Status).HasMaxLength(30);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RecontractManagements)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REContractManagement_TrnUser");
            });

            modelBuilder.Entity<RecontractManagementAttachment>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.RecontractManagementId });

                entity.ToTable("REContractManagementAttachment");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.RecontractManagementId).HasColumnName("REContractManagementID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.RecontractManagementAttachments)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_REContractManagementAttachment_ApplicationFileUpload");

                entity.HasOne(d => d.RecontractManagement)
                    .WithMany(p => p.RecontractManagementAttachments)
                    .HasForeignKey(d => d.RecontractManagementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REContractManagementAttachment_REContractManagement");
            });

            modelBuilder.Entity<RecontractManagementFavApplication>(entity =>
            {
                entity.HasKey(e => e.FavAppId)
                    .HasName("PK_REContractManagementFavApplication_FavAppID");

                entity.ToTable("REContractManagementFavApplication");

                entity.HasIndex(e => new { e.UserId, e.RoleId, e.IsDeleted }, "IX_REContractManagementFavApplication_Filter");

                entity.Property(e => e.FavAppId)
                    .HasColumnName("FavAppID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BackendAppId).HasColumnName("BackendAppID");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<RetailDatum>(entity =>
            {
                entity.HasKey(e => e.RetailDataId);

                entity.Property(e => e.RetailDataId)
                    .HasColumnName("RetailDataID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('system')");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StateCode).HasMaxLength(10);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RetailData)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_RetailData_TrnUser");
            });

            modelBuilder.Entity<RetechStudyApplication>(entity =>
            {
                entity.ToTable("RETechStudyApplication");

                entity.Property(e => e.RetechStudyApplicationId).HasColumnName("RETechStudyApplicationID");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicationType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyForId)
                    .HasColumnName("ApplyForID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthEmail).HasMaxLength(50);

                entity.Property(e => e.AuthFaxNo).HasMaxLength(20);

                entity.Property(e => e.AuthMobileNo).HasMaxLength(20);

                entity.Property(e => e.AuthName).HasMaxLength(50);

                entity.Property(e => e.AuthName2).HasMaxLength(50);

                entity.Property(e => e.AuthOfficePhoneNo).HasMaxLength(20);

                entity.Property(e => e.AuthPosition).HasMaxLength(50);

                entity.Property(e => e.BatteryCapacity)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BatteryEnergyStorageSystem)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessArea).HasMaxLength(10);

                entity.Property(e => e.ConnectionPointName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContractAccountNo).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CtratingLowVoltage)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CTRatingLowVoltage");

                entity.Property(e => e.DaytimeLowest)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DaytimePeak)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EstimatedMonthlyGeneration)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExistingFiah)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ExistingFIAH");

                entity.Property(e => e.ExistingFiahcapacity)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ExistingFIAHCapacity");

                entity.Property(e => e.ExpectedAnnualEnergyGeneration).HasMaxLength(10);

                entity.Property(e => e.ExportDaytimeLowest)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExportDaytimePeak)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo).HasMaxLength(20);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FuseRatingLowVoltage)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenerationCapacityCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratorSubTransientReactance)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratorTransientReactance)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratorType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratorTypeOther)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GivenTitleCode).HasMaxLength(50);

                entity.Property(e => e.GivenTitleId).HasColumnName("GivenTitleID");

                entity.Property(e => e.Gpscoordinates)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GPSCoordinates");

                entity.Property(e => e.HomePhoneNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.Impedance)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InverterManufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InverterPowerFactor)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InverterPowerFactorLagging)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InverterPowerFactorLeading)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InverterType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MailAddrTag).HasMaxLength(10);

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(50);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.MaximumDemand)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MethodOfEarthing)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinPflagging)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MinPFLagging");

                entity.Property(e => e.MinPfleading)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MinPFLeading");

                entity.Property(e => e.MobileNo).HasMaxLength(20);

                entity.Property(e => e.MothersName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Name2).HasMaxLength(50);

                entity.Property(e => e.NeminstalledCapacity)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEMInstalledCapacity");

                entity.Property(e => e.NetExport).HasMaxLength(25);

                entity.Property(e => e.Nokemail)
                    .HasMaxLength(50)
                    .HasColumnName("NOKEmail");

                entity.Property(e => e.NokhomePhoneNo)
                    .HasMaxLength(20)
                    .HasColumnName("NOKHomePhoneNo");

                entity.Property(e => e.NokmobileNo)
                    .HasMaxLength(20)
                    .HasColumnName("NOKMobileNo");

                entity.Property(e => e.Nokname)
                    .HasMaxLength(50)
                    .HasColumnName("NOKName");

                entity.Property(e => e.Nokname2)
                    .HasMaxLength(50)
                    .HasColumnName("NOKName2");

                entity.Property(e => e.NokofficePhoneNo)
                    .HasMaxLength(20)
                    .HasColumnName("NOKOfficePhoneNo");

                entity.Property(e => e.NumberOfInverterInstalled)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OtherSubCategory).HasMaxLength(25);

                entity.Property(e => e.PaymentRefStatus).HasMaxLength(10);

                entity.Property(e => e.PersonInCharge)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(10);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(50);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.PvmoduleType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PVModuleType");

                entity.Property(e => e.RatedCapacity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RatedTerminalVoltage)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Rating)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RatingPf)
                    .HasMaxLength(20)
                    .HasColumnName("RatingPF");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([RETechStudyApplicationID],'RE 000-000-0000-TS'))", false);

                entity.Property(e => e.Resistance)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RetechStudyGuid)
                    .HasColumnName("RETechStudyGuid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Rocno)
                    .HasMaxLength(14)
                    .HasColumnName("ROCNo");

                entity.Property(e => e.SalutationCode).HasMaxLength(50);

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.ServiceNotificationNo).HasMaxLength(30);

                entity.Property(e => e.SignalStrength)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sparea)
                    .HasMaxLength(40)
                    .HasColumnName("SPArea");

                entity.Property(e => e.Spbuilding)
                    .HasMaxLength(40)
                    .HasColumnName("SPBuilding");

                entity.Property(e => e.Spcity)
                    .HasMaxLength(40)
                    .HasColumnName("SPCity");

                entity.Property(e => e.Spemail)
                    .HasMaxLength(50)
                    .HasColumnName("SPEMail");

                entity.Property(e => e.SpfaxNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SPFaxNo");

                entity.Property(e => e.SphouseNo)
                    .HasMaxLength(10)
                    .HasColumnName("SPHouseNo");

                entity.Property(e => e.SpmobileNo)
                    .HasMaxLength(20)
                    .HasColumnName("SPMobileNo");

                entity.Property(e => e.Spname)
                    .HasMaxLength(50)
                    .HasColumnName("SPName");

                entity.Property(e => e.SpofficePhoneNo)
                    .HasMaxLength(20)
                    .HasColumnName("SPOfficePhoneNo");

                entity.Property(e => e.SppostalCode)
                    .HasMaxLength(10)
                    .HasColumnName("SPPostalCode");

                entity.Property(e => e.Sprocno)
                    .HasMaxLength(14)
                    .HasColumnName("SPROCNo");

                entity.Property(e => e.Spstate)
                    .HasMaxLength(20)
                    .HasColumnName("SPState");

                entity.Property(e => e.Spstreet)
                    .HasMaxLength(60)
                    .HasColumnName("SPStreet");

                entity.Property(e => e.Sptype)
                    .HasMaxLength(25)
                    .HasColumnName("SPType");

                entity.Property(e => e.SpunitNo)
                    .HasMaxLength(10)
                    .HasColumnName("SPUnitNo");

                entity.Property(e => e.Status).HasMaxLength(30);

                entity.Property(e => e.TapRangeMax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TapRangeMin)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TapStep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TnbsubstationName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TNBSubstationName");

                entity.Property(e => e.TypeOfControl)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfStudy)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TypeOfSTudy");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VectorGroup)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.VoltageRatio)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RetechStudyApplications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETechStudyApplication_TrnUser");
            });

            modelBuilder.Entity<RetechStudyApplicationAttachment>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.RetechStudyApplicationId });

                entity.ToTable("RETechStudyApplicationAttachment");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.RetechStudyApplicationId).HasColumnName("RETechStudyApplicationID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.RetechStudyApplicationAttachments)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_RETechStudyApplicationAttachment_ApplicationFileUpload");

                entity.HasOne(d => d.RetechStudyApplication)
                    .WithMany(p => p.RetechStudyApplicationAttachments)
                    .HasForeignKey(d => d.RetechStudyApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETechStudyApplicationAttachment_RETechStudyApplication");
            });

            modelBuilder.Entity<RetechStudyApplicationAttachmentNew>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.RetechStudyApplicationId });

                entity.ToTable("RETechStudyApplicationAttachment_new");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.RetechStudyApplicationId).HasColumnName("RETechStudyApplicationID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.RetechStudyApplicationAttachmentNews)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_RETechStudyApplicationAttachment_ApplicationFileUpload_new");

                entity.HasOne(d => d.RetechStudyApplication)
                    .WithMany(p => p.RetechStudyApplicationAttachmentNews)
                    .HasForeignKey(d => d.RetechStudyApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETechStudyApplicationAttachment_RETechStudyApplication_new");
            });

            modelBuilder.Entity<RetechStudyApplicationNew>(entity =>
            {
                entity.HasKey(e => e.RetechStudyApplicationId);

                entity.ToTable("RETechStudyApplication_new");

                entity.Property(e => e.RetechStudyApplicationId).HasColumnName("RETechStudyApplicationID");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicationType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyForId).HasColumnName("ApplyForID");

                entity.Property(e => e.AuthEmail).HasMaxLength(50);

                entity.Property(e => e.AuthFaxNo).HasMaxLength(20);

                entity.Property(e => e.AuthMobileNo).HasMaxLength(20);

                entity.Property(e => e.AuthName).HasMaxLength(50);

                entity.Property(e => e.AuthName2).HasMaxLength(50);

                entity.Property(e => e.AuthOfficePhoneNo).HasMaxLength(20);

                entity.Property(e => e.AuthPosition).HasMaxLength(50);

                entity.Property(e => e.BatteryCapacity)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BatteryEnergyStorageSystem)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessArea).HasMaxLength(10);

                entity.Property(e => e.ConnectionPointName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContractAccountNo).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CtratingLowVoltage)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CTRatingLowVoltage");

                entity.Property(e => e.DaytimeLowest)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DaytimePeak)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EstimatedMonthlyGeneration)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExistingFiah)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ExistingFIAH");

                entity.Property(e => e.ExistingFiahcapacity)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ExistingFIAHCapacity");

                entity.Property(e => e.ExpectedAnnualEnergyGeneration).HasMaxLength(10);

                entity.Property(e => e.ExportDaytimeLowest)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExportDaytimePeak)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo).HasMaxLength(20);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FuseRatingLowVoltage)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenerationCapacityCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratorSubTransientReactance)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratorTransientReactance)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratorType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratorTypeOther)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GivenTitleCode).HasMaxLength(50);

                entity.Property(e => e.GivenTitleId).HasColumnName("GivenTitleID");

                entity.Property(e => e.Gpscoordinates)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GPSCoordinates");

                entity.Property(e => e.HomePhoneNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.Impedance)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InverterManufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InverterPowerFactor)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InverterPowerFactorLagging)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InverterPowerFactorLeading)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InverterType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MailAddrTag).HasMaxLength(10);

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(50);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.MaximumDemand)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MethodOfEarthing)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinPflagging)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MinPFLagging");

                entity.Property(e => e.MinPfleading)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MinPFLeading");

                entity.Property(e => e.MobileNo).HasMaxLength(20);

                entity.Property(e => e.MothersName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Name2).HasMaxLength(50);

                entity.Property(e => e.NeminstalledCapacity)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEMInstalledCapacity");

                entity.Property(e => e.NetExport).HasMaxLength(25);

                entity.Property(e => e.Nokemail)
                    .HasMaxLength(50)
                    .HasColumnName("NOKEmail");

                entity.Property(e => e.NokhomePhoneNo)
                    .HasMaxLength(20)
                    .HasColumnName("NOKHomePhoneNo");

                entity.Property(e => e.NokmobileNo)
                    .HasMaxLength(20)
                    .HasColumnName("NOKMobileNo");

                entity.Property(e => e.Nokname)
                    .HasMaxLength(50)
                    .HasColumnName("NOKName");

                entity.Property(e => e.Nokname2)
                    .HasMaxLength(50)
                    .HasColumnName("NOKName2");

                entity.Property(e => e.NokofficePhoneNo)
                    .HasMaxLength(20)
                    .HasColumnName("NOKOfficePhoneNo");

                entity.Property(e => e.NumberOfInverterInstalled)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OtherSubCategory).HasMaxLength(25);

                entity.Property(e => e.PaymentRefStatus).HasMaxLength(10);

                entity.Property(e => e.PersonInCharge)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(10);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(50);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.PvmoduleType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PVModuleType");

                entity.Property(e => e.RatedCapacity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RatedTerminalVoltage)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Rating)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RatingPf)
                    .HasMaxLength(20)
                    .HasColumnName("RatingPF");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([RETechStudyApplicationID],'RE 000-000-0000-TS'))", false);

                entity.Property(e => e.Resistance)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RetechStudyGuid)
                    .HasColumnName("RETechStudyGuid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Rocno)
                    .HasMaxLength(14)
                    .HasColumnName("ROCNo");

                entity.Property(e => e.SalutationCode).HasMaxLength(50);

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.ServiceNotificationNo).HasMaxLength(30);

                entity.Property(e => e.SignalStrength)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sparea)
                    .HasMaxLength(40)
                    .HasColumnName("SPArea");

                entity.Property(e => e.Spbuilding)
                    .HasMaxLength(40)
                    .HasColumnName("SPBuilding");

                entity.Property(e => e.Spcity)
                    .HasMaxLength(40)
                    .HasColumnName("SPCity");

                entity.Property(e => e.Spemail)
                    .HasMaxLength(50)
                    .HasColumnName("SPEMail");

                entity.Property(e => e.SpfaxNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SPFaxNo");

                entity.Property(e => e.SphouseNo)
                    .HasMaxLength(10)
                    .HasColumnName("SPHouseNo");

                entity.Property(e => e.SpmobileNo)
                    .HasMaxLength(20)
                    .HasColumnName("SPMobileNo");

                entity.Property(e => e.Spname)
                    .HasMaxLength(50)
                    .HasColumnName("SPName");

                entity.Property(e => e.SpofficePhoneNo)
                    .HasMaxLength(20)
                    .HasColumnName("SPOfficePhoneNo");

                entity.Property(e => e.SppostalCode)
                    .HasMaxLength(10)
                    .HasColumnName("SPPostalCode");

                entity.Property(e => e.Sprocno)
                    .HasMaxLength(14)
                    .HasColumnName("SPROCNo");

                entity.Property(e => e.Spstate)
                    .HasMaxLength(20)
                    .HasColumnName("SPState");

                entity.Property(e => e.Spstreet)
                    .HasMaxLength(60)
                    .HasColumnName("SPStreet");

                entity.Property(e => e.Sptype)
                    .HasMaxLength(25)
                    .HasColumnName("SPType");

                entity.Property(e => e.SpunitNo)
                    .HasMaxLength(10)
                    .HasColumnName("SPUnitNo");

                entity.Property(e => e.Status).HasMaxLength(30);

                entity.Property(e => e.TapRangeMax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TapRangeMin)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TapStep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TnbsubstationName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TNBSubstationName");

                entity.Property(e => e.TypeOfControl)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfStudy)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TypeOfSTudy");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VectorGroup)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.VoltageRatio)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RetechStudyApplicationNews)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETechStudyApplication_TrnUser_new");
            });

            modelBuilder.Entity<RetechStudyFavApplication>(entity =>
            {
                entity.HasKey(e => e.FavAppId)
                    .HasName("PK_RETechStudyFavApplication_FavAppID");

                entity.ToTable("RETechStudyFavApplication");

                entity.HasIndex(e => new { e.UserId, e.RoleId, e.IsDeleted }, "IX_RETechStudyFavApplication_Filter");

                entity.Property(e => e.FavAppId)
                    .HasColumnName("FavAppID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BackendAppId).HasColumnName("BackendAppID");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Rewiring>(entity =>
            {
                entity.ToTable("Rewiring");

                entity.HasIndex(e => e.ContractAccountNo, "IX_Rewiring_CA_NO");

                entity.HasIndex(e => e.LastModifiedDate, "IX_Rewiring_LastModifiedDate");

                entity.HasIndex(e => e.StatusId, "IX_Rewiring_StatusID");

                entity.Property(e => e.RewiringId).HasColumnName("RewiringID");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicantType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationModuleId)
                    .HasColumnName("ApplicationModuleID")
                    .HasDefaultValueSql("((101008))");

                entity.Property(e => e.BillingEmail).HasMaxLength(241);

                entity.Property(e => e.BpNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BP_No");

                entity.Property(e => e.ContactPersonBpNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ContactPerson_BP_No");

                entity.Property(e => e.ContactPersonName1).HasMaxLength(40);

                entity.Property(e => e.ContactPersonName2).HasMaxLength(40);

                entity.Property(e => e.ContactPersonPosition).HasMaxLength(20);

                entity.Property(e => e.ContractAccountNo).HasMaxLength(14);

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(240);

                entity.Property(e => e.FaxNo).HasMaxLength(30);

                entity.Property(e => e.FixedLineNo).HasMaxLength(30);

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadChangeType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LoadType).HasMaxLength(7);

                entity.Property(e => e.MailAddrTag).HasMaxLength(10);

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(10);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.MobileNo).HasMaxLength(30);

                entity.Property(e => e.MothersName).HasMaxLength(40);

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.NewPremiseTypeHeaderId).HasColumnName("NewPremiseTypeHeaderID");

                entity.Property(e => e.NextOfKinEmail).HasMaxLength(241);

                entity.Property(e => e.NextOfKinName1).HasMaxLength(40);

                entity.Property(e => e.NextOfKinName2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinPhoneNo).HasMaxLength(30);

                entity.Property(e => e.PaymentFlag).HasMaxLength(50);

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseCurrentMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(10);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.PremiseVoltageLevel).HasMaxLength(20);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([RewiringID],'RW-000-000-0000'))", false);

                entity.Property(e => e.RegisterGroup).HasMaxLength(40);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.SnNo)
                    .HasMaxLength(20)
                    .HasColumnName("SN_No");

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.SrapplicationDetail).HasColumnName("SRApplicationDetail");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TariffRate).HasMaxLength(20);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<RewiringApplicationStatus>(entity =>
            {
                entity.HasKey(e => e.ApplicationStatusId);

                entity.ToTable("RewiringApplicationStatus");

                entity.Property(e => e.ApplicationStatusId).HasColumnName("ApplicationStatusID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DisplayText).HasMaxLength(30);

                entity.Property(e => e.RewiringId).HasColumnName("RewiringID");

                entity.Property(e => e.StatusCode).HasMaxLength(10);

                entity.Property(e => e.StatusDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusFor)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusText).HasMaxLength(30);

                entity.HasOne(d => d.Rewiring)
                    .WithMany(p => p.RewiringApplicationStatuses)
                    .HasForeignKey(d => d.RewiringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RewiringApplicationStatus_Rewiring");
            });

            modelBuilder.Entity<RewiringAttachment>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.RewiringId });

                entity.ToTable("RewiringAttachment");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.RewiringId).HasColumnName("RewiringID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileCode).HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UploadedBy)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.File)
                    .WithMany(p => p.RewiringAttachments)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_RewiringAttachment_ApplicationFileUpload");

                entity.HasOne(d => d.Rewiring)
                    .WithMany(p => p.RewiringAttachments)
                    .HasForeignKey(d => d.RewiringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RewiringAttachment_Rewiring");
            });

            modelBuilder.Entity<RewiringBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RewiringBackup");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicantType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.BpNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BP_No");

                entity.Property(e => e.ContactPersonBpNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ContactPerson_BP_No");

                entity.Property(e => e.ContactPersonName1).HasMaxLength(40);

                entity.Property(e => e.ContactPersonName2).HasMaxLength(40);

                entity.Property(e => e.ContactPersonPosition).HasMaxLength(20);

                entity.Property(e => e.ContractAccountNo).HasMaxLength(14);

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(240);

                entity.Property(e => e.FaxNo).HasMaxLength(30);

                entity.Property(e => e.FixedLineNo).HasMaxLength(30);

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadChangeType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LoadType).HasMaxLength(7);

                entity.Property(e => e.MailAddrTag).HasMaxLength(10);

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(10);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.MobileNo).HasMaxLength(30);

                entity.Property(e => e.MothersName).HasMaxLength(40);

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.NewPremiseTypeHeaderId).HasColumnName("NewPremiseTypeHeaderID");

                entity.Property(e => e.NextOfKinEmail).HasMaxLength(241);

                entity.Property(e => e.NextOfKinName1).HasMaxLength(40);

                entity.Property(e => e.NextOfKinName2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinPhoneNo).HasMaxLength(30);

                entity.Property(e => e.PaymentFlag).HasMaxLength(50);

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseCurrentMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(10);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.PremiseVoltageLevel).HasMaxLength(20);

                entity.Property(e => e.ReferenceNo).HasMaxLength(4000);

                entity.Property(e => e.RegisterGroup).HasMaxLength(40);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.RewiringId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RewiringID");

                entity.Property(e => e.SnNo)
                    .HasMaxLength(20)
                    .HasColumnName("SN_No");

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TariffRate).HasMaxLength(20);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<RewiringBackup8Nov19>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RewiringBackup8Nov19");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ApplicantType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.BpNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BP_No");

                entity.Property(e => e.ContactPersonBpNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ContactPerson_BP_No");

                entity.Property(e => e.ContactPersonName1).HasMaxLength(40);

                entity.Property(e => e.ContactPersonName2).HasMaxLength(40);

                entity.Property(e => e.ContactPersonPosition).HasMaxLength(20);

                entity.Property(e => e.ContractAccountNo).HasMaxLength(14);

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(240);

                entity.Property(e => e.FaxNo).HasMaxLength(30);

                entity.Property(e => e.FixedLineNo).HasMaxLength(30);

                entity.Property(e => e.IdentificationNo).HasMaxLength(20);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("IdentificationTypeID");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadChangeType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LoadType).HasMaxLength(7);

                entity.Property(e => e.MailAddrTag).HasMaxLength(10);

                entity.Property(e => e.MailArea).HasMaxLength(40);

                entity.Property(e => e.MailBuilding).HasMaxLength(40);

                entity.Property(e => e.MailCity).HasMaxLength(40);

                entity.Property(e => e.MailHouseNo).HasMaxLength(10);

                entity.Property(e => e.MailPostalCode).HasMaxLength(10);

                entity.Property(e => e.MailState).HasMaxLength(20);

                entity.Property(e => e.MailStreet).HasMaxLength(60);

                entity.Property(e => e.MailType).HasMaxLength(10);

                entity.Property(e => e.MailUnitNo).HasMaxLength(10);

                entity.Property(e => e.MobileNo).HasMaxLength(30);

                entity.Property(e => e.MothersName).HasMaxLength(40);

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.NewPremiseTypeHeaderId).HasColumnName("NewPremiseTypeHeaderID");

                entity.Property(e => e.NextOfKinEmail).HasMaxLength(241);

                entity.Property(e => e.NextOfKinName1).HasMaxLength(40);

                entity.Property(e => e.NextOfKinName2).HasMaxLength(40);

                entity.Property(e => e.NextOfKinPhoneNo).HasMaxLength(30);

                entity.Property(e => e.PaymentFlag).HasMaxLength(50);

                entity.Property(e => e.PremiseArea).HasMaxLength(40);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremiseCurrentMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PremiseHouseNo).HasMaxLength(10);

                entity.Property(e => e.PremiseNo).HasMaxLength(10);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(60);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(10);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.PremiseVoltageLevel).HasMaxLength(20);

                entity.Property(e => e.ReferenceNo).HasMaxLength(4000);

                entity.Property(e => e.RegisterGroup).HasMaxLength(40);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.RewiringId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RewiringID");

                entity.Property(e => e.SnNo)
                    .HasMaxLength(20)
                    .HasColumnName("SN_No");

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TariffRate).HasMaxLength(20);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<RewiringContractor>(entity =>
            {
                entity.ToTable("RewiringContractor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RewiringId).HasColumnName("RewiringID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.RewiringContractors)
                    .HasForeignKey(d => d.ContractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RewiringContractor_Contractor");

                entity.HasOne(d => d.Rewiring)
                    .WithMany(p => p.RewiringContractors)
                    .HasForeignKey(d => d.RewiringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RewiringContractor_Rewiring");
            });

            modelBuilder.Entity<RewiringContractorBackup8Nov19>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RewiringContractorBackup8Nov19");

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RewiringId).HasColumnName("RewiringID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<RewiringContractorBackupDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RewiringContractorBackup_Deleted");

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RewiringId).HasColumnName("RewiringID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<RewiringStatusLog>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("RewiringStatusLog");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.RewiringId).HasColumnName("RewiringID");

                entity.Property(e => e.SnStatus).HasColumnName("SN_Status");

                entity.Property(e => e.SrStatus).HasColumnName("SR_Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<RewiringTechnical>(entity =>
            {
                entity.HasKey(e => e.RewiringId);

                entity.ToTable("RewiringTechnical");

                entity.Property(e => e.RewiringId)
                    .ValueGeneratedNever()
                    .HasColumnName("RewiringID");

                entity.Property(e => e.AdditionalMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Amps).HasColumnName("AMPS");

                entity.Property(e => e.ApplicationType).HasMaxLength(20);

                entity.Property(e => e.CodeGroup).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CtRatio)
                    .HasMaxLength(50)
                    .HasColumnName("CT_Ratio");

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExistMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.MeterType).HasMaxLength(20);

                entity.Property(e => e.NewMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.NoOfFeeder).HasMaxLength(50);

                entity.Property(e => e.PowerConsumption).HasMaxLength(20);

                entity.Property(e => e.TnbstationCode).HasColumnName("TNBStationCode");

                entity.Property(e => e.TotalLoadMaxDemand).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.VoltageLevel).HasMaxLength(20);

                entity.Property(e => e.WeldMaxDemand).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.Rewiring)
                    .WithOne(p => p.RewiringTechnical)
                    .HasForeignKey<RewiringTechnical>(d => d.RewiringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RewiringTechnical_Rewiring");
            });

            modelBuilder.Entity<Salutation>(entity =>
            {
                entity.ToTable("Salutation");

                entity.Property(e => e.SalutationId)
                    .ValueGeneratedNever()
                    .HasColumnName("SalutationID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceCode).HasMaxLength(50);

                entity.Property(e => e.SalutationDesc).HasMaxLength(50);
            });

            modelBuilder.Entity<Sapmodule>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PK_SAPModule_ModuleID");

                entity.ToTable("SAPModule");

                entity.Property(e => e.ModuleId)
                    .ValueGeneratedNever()
                    .HasColumnName("ModuleID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShortFormCode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SchemeTypeMapping>(entity =>
            {
                entity.HasKey(e => e.TariffSchemeId)
                    .HasName("PK__SchemeTy__9B1B3E53DCD46679");

                entity.ToTable("SchemeTypeMapping");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('system')");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('system')");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SchemeLongDescription)
                    .HasColumnType("text")
                    .HasColumnName("Scheme_LongDescription");

                entity.Property(e => e.SchemeShortDescription)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("Scheme_ShortDescription");

                entity.Property(e => e.SchemeType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Sheet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet1$");

                entity.Property(e => e.Ca).HasColumnName("CA");
            });

            modelBuilder.Entity<Smr>(entity =>
            {
                entity.ToTable("SMR");

                entity.Property(e => e.Smrid).HasColumnName("SMRID");

                entity.Property(e => e.ApplicationModuleId)
                    .HasColumnName("ApplicationModuleID")
                    .HasDefaultValueSql("((101016))");

                entity.Property(e => e.ContractAccountNo)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(240);

                entity.Property(e => e.IdentificationNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Name2).HasMaxLength(40);

                entity.Property(e => e.PremiseArea).HasMaxLength(100);

                entity.Property(e => e.PremiseBuilding).HasMaxLength(40);

                entity.Property(e => e.PremiseCity).HasMaxLength(40);

                entity.Property(e => e.PremisePostalCode).HasMaxLength(10);

                entity.Property(e => e.PremiseState).HasMaxLength(20);

                entity.Property(e => e.PremiseStreet).HasMaxLength(100);

                entity.Property(e => e.PremiseStreetCode).HasMaxLength(40);

                entity.Property(e => e.PremiseType).HasMaxLength(20);

                entity.Property(e => e.PremiseUnitNo).HasMaxLength(10);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([SMRID],'SMR-000-000-0000'))", false);

                entity.Property(e => e.SmrentryMode)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnName("SMREntryMode");

                entity.Property(e => e.SrNo)
                    .HasMaxLength(20)
                    .HasColumnName("SR_No");

                entity.Property(e => e.SrapplicationDetail).HasColumnName("SRApplicationDetail");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Smrattachment>(entity =>
            {
                entity.HasKey(e => new { e.Smrid, e.FileId });

                entity.ToTable("SMRAttachment");

                entity.Property(e => e.Smrid).HasColumnName("SMRID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Smr)
                    .WithMany(p => p.Smrattachments)
                    .HasForeignKey(d => d.Smrid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMRAttachment_SMR");
            });

            modelBuilder.Entity<SmrfavApplication>(entity =>
            {
                entity.HasKey(e => e.FavAppId)
                    .HasName("PK_SMRFavApplication_FavAppID");

                entity.ToTable("SMRFavApplication");

                entity.HasIndex(e => new { e.UserId, e.RoleId, e.IsDeleted }, "IX_SMRFavApplication_Filter");

                entity.Property(e => e.FavAppId)
                    .HasColumnName("FavAppID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BackendAppId).HasColumnName("BackendAppID");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<SmrstatusLog>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("SMRStatusLog");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Smrid).HasColumnName("SMRID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<SmsTemplate>(entity =>
            {
                entity.ToTable("SmsTemplate");

                entity.Property(e => e.SmsTemplateId)
                    .HasColumnName("SmsTemplateID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SmsContent).HasMaxLength(500);

                entity.Property(e => e.SmsTemplateKey)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmsTraceLog>(entity =>
            {
                entity.ToTable("SmsTraceLog");

                entity.Property(e => e.SmsTraceLogId)
                    .HasColumnName("SmsTraceLogID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CharType).HasMaxLength(5);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Receiver).HasMaxLength(20);

                entity.Property(e => e.ResponseStatus).HasMaxLength(20);

                entity.Property(e => e.Sender).HasMaxLength(20);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.Url).HasMaxLength(500);
            });

            modelBuilder.Entity<SspApplicationPremiseType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ssp_Application_PremiseType");

                entity.Property(e => e.PremiseActivity)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PremiseType).HasMaxLength(50);

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SspTargetBulk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SSP_TARGET_bulk$");

                entity.Property(e => e.BpName)
                    .HasMaxLength(255)
                    .HasColumnName("BP Name");

                entity.Property(e => e.NewKey)
                    .HasMaxLength(255)
                    .HasColumnName("New Key");

                entity.Property(e => e.OldKey).HasColumnName("Old Key");

                entity.Property(e => e.SmtpAddr)
                    .HasMaxLength(255)
                    .HasColumnName("SMTP_ADDR");
            });

            modelBuilder.Entity<Sspnotification>(entity =>
            {
                entity.HasKey(e => e.NotificationId)
                    .HasName("PK_SmartMeterNotification");

                entity.ToTable("SSPNotification");

                entity.Property(e => e.NotificationId)
                    .ValueGeneratedNever()
                    .HasColumnName("NotificationID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationModuleId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ApplicationModuleID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TemplateID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Sspnotifications)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SmartMeterNotification_TrnUser");
            });

            modelBuilder.Entity<SspnotificationQueue>(entity =>
            {
                entity.HasKey(e => e.SmartMeterQueueId)
                    .HasName("PK_SmartMeterNotificationQueue");

                entity.ToTable("SSPNotificationQueue");

                entity.Property(e => e.SmartMeterQueueId)
                    .ValueGeneratedNever()
                    .HasColumnName("SmartMeterQueueID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TemplateID");
            });

            modelBuilder.Entity<SspnotificationTrace>(entity =>
            {
                entity.HasKey(e => e.SmartMeterTraceId)
                    .HasName("PK_SmartMeterNotificationTrace");

                entity.ToTable("SSPNotificationTrace");

                entity.Property(e => e.SmartMeterTraceId)
                    .ValueGeneratedNever()
                    .HasColumnName("SmartMeterTraceID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TemplateID");
            });

            modelBuilder.Entity<Ssprole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("pk_role_id");

                entity.ToTable("SSPRole");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleDescription).HasMaxLength(25);

                entity.Property(e => e.RoleName).HasMaxLength(25);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StateCode).HasMaxLength(50);

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StstateIdref).HasColumnName("STStateIDRef");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Country_CountryID_State_CountryID");
            });

            modelBuilder.Entity<StbandarSource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STBandarSource");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KodSingkatan)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StbandarId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STBandarID");
            });

            modelBuilder.Entity<Stcategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STCategory");

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StcategoryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STCategoryID");
            });

            modelBuilder.Entity<Stcity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STCity");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShortFormCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StcityId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STCityID");
            });

            modelBuilder.Entity<Stcontractor>(entity =>
            {
                entity.ToTable("STContractor");

                entity.HasIndex(e => e.RegistrationNumber, "IX_STContractor_RegistrationNumber");

                entity.Property(e => e.StcontractorId).HasColumnName("STContractorID");

                entity.Property(e => e.CodeCategory)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCodeS)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.EcibscontractorId).HasColumnName("ECIBSContractorID");

                entity.Property(e => e.EcibssyncStatus).HasColumnName("ECIBSSyncStatus");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FaxS)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MailingAddress1S)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress2S)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress3S)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumberS)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PosCodeS)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.RegistrationNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<StcontractorSource>(entity =>
            {
                entity.HasKey(e => e.StcontractorId);

                entity.ToTable("STContractorSource");

                entity.Property(e => e.StcontractorId).HasColumnName("STContractorID");

                entity.Property(e => e.Alamat1D)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Alamat1S)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Alamat2D)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Alamat2S)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Alamat3D)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Alamat3S)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EcibscontractorId).HasColumnName("ECIBSContractorID");

                entity.Property(e => e.EcibssyncStatus).HasColumnName("ECIBSSyncStatus");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FaxD)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FaxS)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KodKategori)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KodNegaraD)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.KodNegaraS)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nama)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoDaftar)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PoskodD)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PoskodS)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TarikhCetak).HasColumnType("datetime");

                entity.Property(e => e.TarikhJana).HasColumnType("datetime");

                entity.Property(e => e.TarikhMula).HasColumnType("datetime");

                entity.Property(e => e.TarikhTamat).HasColumnType("datetime");

                entity.Property(e => e.TelefonD)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonS)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Stcountry>(entity =>
            {
                entity.ToTable("STCountry");

                entity.Property(e => e.StcountryId).HasColumnName("STCountryID");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StintegrationLog>(entity =>
            {
                entity.ToTable("STIntegrationLog");

                entity.Property(e => e.StintegrationLogId).HasColumnName("STIntegrationLogID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<StkategoriSource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STKategoriSource");

                entity.Property(e => e.KodKategori)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nama)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StkategoriId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STKategoriID");
            });

            modelBuilder.Entity<StnegaraSource>(entity =>
            {
                entity.HasKey(e => e.StnegaraId);

                entity.ToTable("STNegaraSource");

                entity.Property(e => e.StnegaraId).HasColumnName("STNegaraID");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KodNegara)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StnegeriSource>(entity =>
            {
                entity.HasKey(e => e.StnegeriId);

                entity.ToTable("STNegeriSource");

                entity.Property(e => e.StnegeriId).HasColumnName("STNegeriID");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KodNegara)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StreetlightSubCategory>(entity =>
            {
                entity.HasKey(e => e.StreetlightSubCategoryCode)
                    .HasName("pk_strsubcat_code");

                entity.ToTable("StreetlightSubCategory");

                entity.Property(e => e.StreetlightSubCategoryCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PremiseTypeHeaderId).HasColumnName("PremiseTypeHeaderID");

                entity.Property(e => e.PremiseTypeItemCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StreetlightSubCategoryDesc)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Ststate>(entity =>
            {
                entity.ToTable("STState");

                entity.Property(e => e.StstateId).HasColumnName("STStateID");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubModule>(entity =>
            {
                entity.ToTable("SubModule");

                entity.Property(e => e.SubModuleId).HasColumnName("SubModuleID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.SubModuleName).HasMaxLength(50);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.SubModules)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("fk_ModuleID");
            });

            modelBuilder.Entity<SurveyDetail>(entity =>
            {
                entity.ToTable("SurveyDetail");

                entity.HasIndex(e => e.SurveyId, "IX_SurveyDetail_SurveyID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveyDetails)
                    .HasForeignKey(d => d.SurveyId)
                    .HasConstraintName("FK_SurveyDetails_SurveyHdr");
            });

            modelBuilder.Entity<SurveyHeader>(entity =>
            {
                entity.HasKey(e => e.SurveyId)
                    .HasName("PK_SurveyHdr");

                entity.ToTable("SurveyHeader");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewConnectionId).HasColumnName("NewConnectionID");

                entity.Property(e => e.RewiringId).HasColumnName("RewiringID");

                entity.Property(e => e.SentOn).HasColumnType("datetime");

                entity.Property(e => e.SubmitedOn).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<SurveyResult>(entity =>
            {
                entity.Property(e => e.AnswerValue)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionCategoryValue)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionValue)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemConfig>(entity =>
            {
                entity.ToTable("SystemConfig");

                entity.Property(e => e.SystemConfigId)
                    .HasColumnName("SystemConfigID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Area).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(14);

                entity.Property(e => e.Key).IsRequired();

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SystemConfigBackup8Nov19>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SystemConfigBackup8Nov19");

                entity.Property(e => e.Area).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(14);

                entity.Property(e => e.Key).IsRequired();

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SystemConfigId).HasColumnName("SystemConfigID");
            });

            modelBuilder.Entity<TechnologyCategory>(entity =>
            {
                entity.HasKey(e => e.TechCategoryId);

                entity.ToTable("TechnologyCategory");

                entity.Property(e => e.TechCategoryId).HasColumnName("TechCategoryID");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.CategoryCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TechnologyGenerationCapacity>(entity =>
            {
                entity.HasKey(e => e.TechGenCapacityId);

                entity.ToTable("TechnologyGenerationCapacity");

                entity.Property(e => e.TechGenCapacityId).HasColumnName("TechGenCapacityID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.GenerationCapacity)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.GenerationCapacityCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RefCode).HasMaxLength(10);

                entity.Property(e => e.TechSubCategoryId).HasColumnName("TechSubCategoryID");

                entity.HasOne(d => d.TechSubCategory)
                    .WithMany(p => p.TechnologyGenerationCapacities)
                    .HasForeignKey(d => d.TechSubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TechnologySubCategory_TechSubCategoryID_TechnologyGenerationCapacity_TechSubCategoryID");
            });

            modelBuilder.Entity<TechnologySubCategory>(entity =>
            {
                entity.HasKey(e => e.TechSubCategoryId);

                entity.ToTable("TechnologySubCategory");

                entity.Property(e => e.TechSubCategoryId).HasColumnName("TechSubCategoryID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubCategory).HasMaxLength(25);

                entity.Property(e => e.TechCategoryId).HasColumnName("TechCategoryID");

                entity.HasOne(d => d.TechCategory)
                    .WithMany(p => p.TechnologySubCategories)
                    .HasForeignKey(d => d.TechCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TechnologyCategory_TechnologyCategoryID_TechnologySubCategory_TechnologyCategoryID");
            });

            modelBuilder.Entity<Testapp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testapp");

                entity.Property(e => e.BillNotificationOutboundTable)
                    .HasColumnType("xml")
                    .HasColumnName("BillNotificationOutbound_table");
            });

            modelBuilder.Entity<Testxml>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testxml");

                entity.Property(e => e.Data)
                    .HasColumnType("xml")
                    .HasColumnName("data");
            });

            modelBuilder.Entity<Tnbstation>(entity =>
            {
                entity.HasKey(e => e.StationId);

                entity.ToTable("TNBStation");

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Address3).HasMaxLength(100);

                entity.Property(e => e.BorderRegion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.ContactNo).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(10);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.FaxNo).HasMaxLength(50);

                entity.Property(e => e.HouseNo).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostalCode).HasMaxLength(20);

                entity.Property(e => e.ProjectPlannerEmail).HasMaxLength(500);

                entity.Property(e => e.Region).HasMaxLength(10);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StationName).HasMaxLength(50);

                entity.Property(e => e.Street1).HasMaxLength(500);

                entity.Property(e => e.Street2).HasMaxLength(500);

                entity.Property(e => e.TelephoneNo).HasMaxLength(50);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Tnbstations)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_TNBStation_State");
            });

            modelBuilder.Entity<TrnAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("pk_account_id");

                entity.ToTable("TrnAccount");

                entity.HasIndex(e => e.UserId, "IX_TrnAccount");

                entity.HasIndex(e => new { e.UserId, e.AccountNumber, e.IsDeleted }, "IX_TrnAccount_UserID_AccountNo_IsDeleted");

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountCategory)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCategoryId)
                    .HasColumnName("AccountCategoryID")
                    .HasComputedColumnSql("(case when [AccountCategory]='Utility Account' then (1) when [AccountCategory]='FIAH Account' then (2) else (99) end)", true);

                entity.Property(e => e.AccountDescription).HasMaxLength(100);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.Amsid)
                    .HasMaxLength(10)
                    .HasColumnName("AMSID");

                entity.Property(e => e.Area)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Building)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(40);

                entity.Property(e => e.ContactNo).HasMaxLength(15);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.HouseNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificationNo).HasMaxLength(50);

                entity.Property(e => e.IsApplyEbilling).HasColumnName("IsApplyEBilling");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('W')")
                    .IsFixedLength(true);

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.MotherName).HasMaxLength(50);

                entity.Property(e => e.OwnerName).HasMaxLength(80);

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Roc).HasColumnName("ROC");

                entity.Property(e => e.State).HasMaxLength(40);

                entity.Property(e => e.Street)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UnitNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.TrnAccounts)
                    .HasForeignKey(d => d.AccountTypeId)
                    .HasConstraintName("fk_AccountAccTypeID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TrnAccounts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_AccountUserID");
            });

            modelBuilder.Entity<TrnAccount20190624Deleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TrnAccount_20190624_Deleted");

                entity.Property(e => e.AccountCategory)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCategoryId).HasColumnName("AccountCategoryID");

                entity.Property(e => e.AccountDescription).HasMaxLength(100);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.Amsid)
                    .HasMaxLength(10)
                    .HasColumnName("AMSID");

                entity.Property(e => e.Area)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AverageBillAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.Building)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(40);

                entity.Property(e => e.ContactNo).HasMaxLength(15);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentCharges).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.HouseNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificationNo).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastPaymentAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastPaymentDate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.MotherName).HasMaxLength(50);

                entity.Property(e => e.OutstandingCharges).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OwnerName).HasMaxLength(80);

                entity.Property(e => e.PaymentDueDate).HasColumnType("datetime");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Roc).HasColumnName("ROC");

                entity.Property(e => e.State).HasMaxLength(40);

                entity.Property(e => e.Street)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmtPayable).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TrnAccountActivityLog>(entity =>
            {
                entity.HasKey(e => e.ActivityLogId);

                entity.ToTable("TrnAccountActivityLog");

                entity.Property(e => e.ActivityLogId)
                    .ValueGeneratedNever()
                    .HasColumnName("ActivityLogID");

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsApplyEbilling).HasColumnName("IsApplyEBilling");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TrnAccountDeltaLog>(entity =>
            {
                entity.ToTable("TrnAccountDeltaLog");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccountCategory)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCategoryId).HasColumnName("AccountCategoryID");

                entity.Property(e => e.AccountDescription).HasMaxLength(100);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.Amsid)
                    .HasMaxLength(10)
                    .HasColumnName("AMSID");

                entity.Property(e => e.Area)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Building)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(40);

                entity.Property(e => e.ContactNo).HasMaxLength(15);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Crudindicator)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CRUDIndicator");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.HouseNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificationNo).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LogCreatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('System (Trigger)')");

                entity.Property(e => e.LogCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.MotherName).HasMaxLength(50);

                entity.Property(e => e.OwnerName).HasMaxLength(80);

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedToBcrm)
                    .HasColumnName("PostedToBCRM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostedToBcrmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("PostedToBCRMDate");

                entity.Property(e => e.Roc).HasColumnName("ROC");

                entity.Property(e => e.State).HasMaxLength(40);

                entity.Property(e => e.Street)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UnitNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TrnAccountDummyDeleted>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK__TrnAccou__349DA58660D8083B");

                entity.ToTable("TrnAccount_dummy_Deleted");

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountCategory)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCategoryId)
                    .HasColumnName("AccountCategoryID")
                    .HasComputedColumnSql("(case when [AccountCategory]='Utility Account' then (1) when [AccountCategory]='FIAH Account' then (2) else (99) end)", true);

                entity.Property(e => e.AccountDescription).HasMaxLength(100);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.Area)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AverageBillAmt)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.Building)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(40);

                entity.Property(e => e.ContactNo).HasMaxLength(15);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentCharges)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.HouseNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificationNo).HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastPaymentAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastPaymentDate)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.MotherName).HasMaxLength(50);

                entity.Property(e => e.OutstandingCharges)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OwnerName).HasMaxLength(80);

                entity.Property(e => e.PaymentDueDate).HasColumnType("datetime");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Roc).HasColumnName("ROC");

                entity.Property(e => e.State).HasMaxLength(40);

                entity.Property(e => e.Street)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmtPayable)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TrnAccountPre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TrnAccountPre");

                entity.Property(e => e.AccountCategory)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCategoryId)
                    .HasColumnName("AccountCategoryID")
                    .HasComputedColumnSql("(case when [AccountCategory]='Utility Account' then (1) when [AccountCategory]='FIAH Account' then (2) else (99) end)", true);

                entity.Property(e => e.AccountDescription).HasMaxLength(100);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.Amsid)
                    .HasMaxLength(10)
                    .HasColumnName("AMSID");

                entity.Property(e => e.Area)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Building)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(40);

                entity.Property(e => e.ContactNo).HasMaxLength(15);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.HouseNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificationNo).HasMaxLength(50);

                entity.Property(e => e.IsApplyEbilling).HasColumnName("IsApplyEBilling");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.MotherName).HasMaxLength(50);

                entity.Property(e => e.OwnerName).HasMaxLength(80);

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Roc).HasColumnName("ROC");

                entity.Property(e => e.State).HasMaxLength(40);

                entity.Property(e => e.Street)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UnitNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail).HasMaxLength(100);
            });

            modelBuilder.Entity<TrnSubModuleRole>(entity =>
            {
                entity.HasKey(e => e.SubModuleRoleId)
                    .HasName("pk_sub_module_role_id");

                entity.ToTable("TrnSubModuleRole");

                entity.Property(e => e.SubModuleRoleId).HasColumnName("SubModuleRoleID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SubModuleId).HasColumnName("SubModuleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TrnSubModuleRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("fk_SubModuleRoleID");

                entity.HasOne(d => d.SubModule)
                    .WithMany(p => p.TrnSubModuleRoles)
                    .HasForeignKey(d => d.SubModuleId)
                    .HasConstraintName("fk_SubModuleID");
            });

            modelBuilder.Entity<TrnSubModuleRoleBackup8Nov19>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TrnSubModuleRoleBackup8Nov19");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SubModuleId).HasColumnName("SubModuleID");

                entity.Property(e => e.SubModuleRoleId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SubModuleRoleID");
            });

            modelBuilder.Entity<TrnUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("pk_user_id");

                entity.ToTable("TrnUser");

                entity.HasIndex(e => e.UserName, "IX_TrnUser");

                entity.HasIndex(e => new { e.Email, e.IsDeleted }, "IX_TrnUser_Email_IsDeleted");

                entity.HasIndex(e => new { e.UserName, e.IsLockOut }, "IX_TrnUser_UserName_IsLockOut");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActivationExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(25);

                entity.Property(e => e.CommId).HasColumnName("CommID");

                entity.Property(e => e.Country).HasMaxLength(25);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.FixedLineNo).HasMaxLength(15);

                entity.Property(e => e.IdentificationNo).HasMaxLength(50);

                entity.Property(e => e.IsPhoneVerified).HasColumnName("isPhoneVerified");

                entity.Property(e => e.IsPreRegistered).HasColumnName("isPreRegistered");

                entity.Property(e => e.KinContactNo).HasMaxLength(15);

                entity.Property(e => e.KinName).HasMaxLength(50);

                entity.Property(e => e.LastLoginFromMobile).HasColumnType("datetime");

                entity.Property(e => e.LastLoginFromWeb).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MaidenName).HasMaxLength(50);

                entity.Property(e => e.MailingAddr1).HasMaxLength(25);

                entity.Property(e => e.MailingAddr2).HasMaxLength(25);

                entity.Property(e => e.MailingAddr3).HasMaxLength(25);

                entity.Property(e => e.MailingAddrState).HasMaxLength(25);

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.RegistrationSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Salt).HasMaxLength(50);

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.DefaultHomePageNavigation)
                    .WithMany(p => p.TrnUsers)
                    .HasForeignKey(d => d.DefaultHomePage)
                    .HasConstraintName("fk_DefaultHomePageId");

                entity.HasOne(d => d.Salutation)
                    .WithMany(p => p.TrnUsers)
                    .HasForeignKey(d => d.SalutationId)
                    .HasConstraintName("fk_SalutationId");
            });

            modelBuilder.Entity<TrnUser20200605>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TrnUser_20200605");

                entity.Property(e => e.ActivationExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(25);

                entity.Property(e => e.CommId).HasColumnName("CommID");

                entity.Property(e => e.Country).HasMaxLength(25);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.FixedLineNo).HasMaxLength(15);

                entity.Property(e => e.IdentificationNo).HasMaxLength(50);

                entity.Property(e => e.IsPhoneVerified).HasColumnName("isPhoneVerified");

                entity.Property(e => e.KinContactNo).HasMaxLength(15);

                entity.Property(e => e.KinName).HasMaxLength(50);

                entity.Property(e => e.LastLoginFromMobile).HasColumnType("datetime");

                entity.Property(e => e.LastLoginFromWeb).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MaidenName).HasMaxLength(50);

                entity.Property(e => e.MailingAddr1).HasMaxLength(25);

                entity.Property(e => e.MailingAddr2).HasMaxLength(25);

                entity.Property(e => e.MailingAddr3).HasMaxLength(25);

                entity.Property(e => e.MailingAddrState).HasMaxLength(25);

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.RegistrationSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Salt).HasMaxLength(50);

                entity.Property(e => e.SalutationId).HasColumnName("SalutationID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TrnUserLoginHistory>(entity =>
            {
                entity.ToTable("TrnUserLoginHistory");

                entity.HasIndex(e => e.UserId, "IX_TrnUserLoginHistory_UserID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoginFrom).HasMaxLength(10);

                entity.Property(e => e.LoginOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TrnUserMobileHistory>(entity =>
            {
                entity.ToTable("TrnUserMobileHistory");

                entity.Property(e => e.TrnUserMobileHistoryId)
                    .HasColumnName("TrnUserMobileHistoryID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileNumber).HasMaxLength(20);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TrnUserSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK_SessionID");

                entity.ToTable("TrnUserSession");

                entity.HasIndex(e => new { e.UserName, e.Token }, "IX_TrnUserSession_UserName_Token");

                entity.Property(e => e.SessionId)
                    .ValueGeneratedNever()
                    .HasColumnName("SessionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Signature)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserListProdRoleSeparationDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserList-PROD-RoleSeparation_Deleted");

                entity.Property(e => e.Ca).HasColumnName("CA");

                entity.Property(e => e.Causername).HasColumnName("CAUsername");

                entity.Property(e => e.Coa).HasColumnName("COA");

                entity.Property(e => e.Coausername).HasColumnName("COAUsername");

                entity.Property(e => e.Contractor)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cot).HasColumnName("COT");

                entity.Property(e => e.Cotusername).HasColumnName("COTUsername");

                entity.Property(e => e.Ncusername).HasColumnName("NCUsername");

                entity.Property(e => e.Role)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Smr).HasColumnName("SMR");

                entity.Property(e => e.Smrusername).HasColumnName("SMRUsername");
            });

            modelBuilder.Entity<UserSurveyDetail>(entity =>
            {
                entity.ToTable("UserSurveyDetail");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SurveyId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SurveyID");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.UserSurveyDetails)
                    .HasForeignKey(d => d.SurveyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogoutSurveyDetail_LogoutSurveyHeader");
            });

            modelBuilder.Entity<UserSurveyHeader>(entity =>
            {
                entity.HasKey(e => e.SurveyId)
                    .HasName("PK_LogoutSurveyHeader");

                entity.ToTable("UserSurveyHeader");

                entity.Property(e => e.SurveyId)
                    .HasMaxLength(50)
                    .HasColumnName("SurveyID");

                entity.Property(e => e.CampaignId)
                    .HasMaxLength(50)
                    .HasColumnName("CampaignID");

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StaffId)
                    .HasMaxLength(50)
                    .HasColumnName("StaffID");

                entity.Property(e => e.UserEmail).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Voltage>(entity =>
            {
                entity.ToTable("Voltage");

                entity.Property(e => e.VoltageId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.VoltageClass)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.VoltageLevel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoltageNumberBcrm)
                    .HasMaxLength(2)
                    .HasColumnName("VoltageNumberBCRM");

                entity.Property(e => e.VoltageType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Walkthrough>(entity =>
            {
                entity.ToTable("Walkthrough");

                entity.Property(e => e.WalkthroughId).HasColumnName("WalkthroughID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WltysentEmailLog>(entity =>
            {
                entity.ToTable("WLTYSentEmailLog");

                entity.Property(e => e.EmailSentOn).HasColumnType("datetime");

                entity.Property(e => e.EmailSentTo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NextEmailSendDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
