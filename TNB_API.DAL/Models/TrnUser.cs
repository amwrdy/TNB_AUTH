using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class TrnUser
    {
        public TrnUser()
        {
            AsrcancelInformationApplicantUsers = new HashSet<AsrcancelInformation>();
            AsrcancelInformationCarelineUsers = new HashSet<AsrcancelInformation>();
            AsrlogActionCarelineUsers = new HashSet<AsrlogAction>();
            AsrlogActionRetailDataUsers = new HashSet<AsrlogAction>();
            CallLogs = new HashSet<CallLog>();
            Contractors = new HashSet<Contractor>();
            CotcallLogs = new HashSet<CotcallLog>();
            CotcancelInformationCarelineUsers = new HashSet<CotcancelInformation>();
            CotcancelInformationExistingOwnerUsers = new HashSet<CotcancelInformation>();
            CotcancelInformationNewOwnerUsers = new HashSet<CotcancelInformation>();
            Developers = new HashSet<Developer>();
            Individuals = new HashSet<Individual>();
            LnkUserRoles = new HashSet<LnkUserRole>();
            NewConnectionCallLogs = new HashSet<NewConnectionCallLog>();
            NewConnectionCancelInformationApplicantUsers = new HashSet<NewConnectionCancelInformation>();
            NewConnectionCancelInformationCarelineUsers = new HashSet<NewConnectionCancelInformation>();
            NewConnectionCancelInformationContractorUsers = new HashSet<NewConnectionCancelInformation>();
            NewConnectionReworkInformationApplicantUsers = new HashSet<NewConnectionReworkInformation>();
            NewConnectionReworkInformationCarelineUsers = new HashSet<NewConnectionReworkInformation>();
            NewConnectionReworkInformationContractorUsers = new HashSet<NewConnectionReworkInformation>();
            NewConnections = new HashSet<NewConnection>();
            ProjectCallLogs = new HashSet<ProjectCallLog>();
            ProjectCancelInformationApplicantUsers = new HashSet<ProjectCancelInformation>();
            ProjectCancelInformationCarelineUsers = new HashSet<ProjectCancelInformation>();
            ProjectReworkInformationApplicantUsers = new HashSet<ProjectReworkInformation>();
            ProjectReworkInformationCarelineUsers = new HashSet<ProjectReworkInformation>();
            Projects = new HashSet<Project>();
            PwdManagements = new HashSet<PwdManagement>();
            RecontractManagements = new HashSet<RecontractManagement>();
            RetailData = new HashSet<RetailDatum>();
            RetechStudyApplicationNews = new HashSet<RetechStudyApplicationNew>();
            RetechStudyApplications = new HashSet<RetechStudyApplication>();
            Sspnotifications = new HashSet<Sspnotification>();
            TrnAccounts = new HashSet<TrnAccount>();
        }

        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Salt { get; set; }
        public int? SalutationId { get; set; }
        public int? IdentificationType { get; set; }
        public string IdentificationNo { get; set; }
        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public string MobileNo { get; set; }
        public string FixedLineNo { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }
        public string MaidenName { get; set; }
        public string KinName { get; set; }
        public string KinContactNo { get; set; }
        public int? CommId { get; set; }
        public string MailingAddr1 { get; set; }
        public string MailingAddr2 { get; set; }
        public string MailingAddr3 { get; set; }
        public string MailingAddrState { get; set; }
        public string City { get; set; }
        public int? Postcode { get; set; }
        public string Country { get; set; }
        public int? DefaultHomePage { get; set; }
        public bool IsLockOut { get; set; }
        public int? PasswordAttempt { get; set; }
        public string RegistrationSource { get; set; }
        public DateTime? LastLoginFromWeb { get; set; }
        public DateTime? LastLoginFromMobile { get; set; }
        public DateTime? ActivationExpiryDate { get; set; }
        public bool IsNotified { get; set; }
        public bool IsActivated { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public bool? IsPhoneVerified { get; set; }
        public bool IsPswdLocked { get; set; }
        public bool? IsPreRegistered { get; set; }
        public bool? IsWhitelist { get; set; }

        public virtual SubModule DefaultHomePageNavigation { get; set; }
        public virtual Salutation Salutation { get; set; }
        public virtual ICollection<AsrcancelInformation> AsrcancelInformationApplicantUsers { get; set; }
        public virtual ICollection<AsrcancelInformation> AsrcancelInformationCarelineUsers { get; set; }
        public virtual ICollection<AsrlogAction> AsrlogActionCarelineUsers { get; set; }
        public virtual ICollection<AsrlogAction> AsrlogActionRetailDataUsers { get; set; }
        public virtual ICollection<CallLog> CallLogs { get; set; }
        public virtual ICollection<Contractor> Contractors { get; set; }
        public virtual ICollection<CotcallLog> CotcallLogs { get; set; }
        public virtual ICollection<CotcancelInformation> CotcancelInformationCarelineUsers { get; set; }
        public virtual ICollection<CotcancelInformation> CotcancelInformationExistingOwnerUsers { get; set; }
        public virtual ICollection<CotcancelInformation> CotcancelInformationNewOwnerUsers { get; set; }
        public virtual ICollection<Developer> Developers { get; set; }
        public virtual ICollection<Individual> Individuals { get; set; }
        public virtual ICollection<LnkUserRole> LnkUserRoles { get; set; }
        public virtual ICollection<NewConnectionCallLog> NewConnectionCallLogs { get; set; }
        public virtual ICollection<NewConnectionCancelInformation> NewConnectionCancelInformationApplicantUsers { get; set; }
        public virtual ICollection<NewConnectionCancelInformation> NewConnectionCancelInformationCarelineUsers { get; set; }
        public virtual ICollection<NewConnectionCancelInformation> NewConnectionCancelInformationContractorUsers { get; set; }
        public virtual ICollection<NewConnectionReworkInformation> NewConnectionReworkInformationApplicantUsers { get; set; }
        public virtual ICollection<NewConnectionReworkInformation> NewConnectionReworkInformationCarelineUsers { get; set; }
        public virtual ICollection<NewConnectionReworkInformation> NewConnectionReworkInformationContractorUsers { get; set; }
        public virtual ICollection<NewConnection> NewConnections { get; set; }
        public virtual ICollection<ProjectCallLog> ProjectCallLogs { get; set; }
        public virtual ICollection<ProjectCancelInformation> ProjectCancelInformationApplicantUsers { get; set; }
        public virtual ICollection<ProjectCancelInformation> ProjectCancelInformationCarelineUsers { get; set; }
        public virtual ICollection<ProjectReworkInformation> ProjectReworkInformationApplicantUsers { get; set; }
        public virtual ICollection<ProjectReworkInformation> ProjectReworkInformationCarelineUsers { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<PwdManagement> PwdManagements { get; set; }
        public virtual ICollection<RecontractManagement> RecontractManagements { get; set; }
        public virtual ICollection<RetailDatum> RetailData { get; set; }
        public virtual ICollection<RetechStudyApplicationNew> RetechStudyApplicationNews { get; set; }
        public virtual ICollection<RetechStudyApplication> RetechStudyApplications { get; set; }
        public virtual ICollection<Sspnotification> Sspnotifications { get; set; }
        public virtual ICollection<TrnAccount> TrnAccounts { get; set; }
    }
}
