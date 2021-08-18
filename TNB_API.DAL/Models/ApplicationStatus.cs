using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class ApplicationStatus
    {
        public ApplicationStatus()
        {
            AddressSearchRequests = new HashSet<AddressSearchRequest>();
            ApplicationStatusTrackers = new HashSet<ApplicationStatusTracker>();
            AsrlogActions = new HashSet<AsrlogAction>();
            AsrstatusLogs = new HashSet<AsrstatusLog>();
            CoaapplicationStatuses = new HashSet<CoaapplicationStatus>();
            CotapplicationStatuses = new HashSet<CotapplicationStatus>();
            Cotapplications = new HashSet<Cotapplication>();
            CotstatusLogs = new HashSet<CotstatusLog>();
            MerdekaIncentives = new HashSet<MerdekaIncentive>();
            NewConnectionApplicationStatuses = new HashSet<NewConnectionApplicationStatus>();
            NewConnectionContractors = new HashSet<NewConnectionContractor>();
            NewConnections = new HashSet<NewConnection>();
            Projects = new HashSet<Project>();
        }

        public int StatusId { get; set; }
        public string Status { get; set; }
        public string StatusCode { get; set; }
        public string StatusProfile { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<AddressSearchRequest> AddressSearchRequests { get; set; }
        public virtual ICollection<ApplicationStatusTracker> ApplicationStatusTrackers { get; set; }
        public virtual ICollection<AsrlogAction> AsrlogActions { get; set; }
        public virtual ICollection<AsrstatusLog> AsrstatusLogs { get; set; }
        public virtual ICollection<CoaapplicationStatus> CoaapplicationStatuses { get; set; }
        public virtual ICollection<CotapplicationStatus> CotapplicationStatuses { get; set; }
        public virtual ICollection<Cotapplication> Cotapplications { get; set; }
        public virtual ICollection<CotstatusLog> CotstatusLogs { get; set; }
        public virtual ICollection<MerdekaIncentive> MerdekaIncentives { get; set; }
        public virtual ICollection<NewConnectionApplicationStatus> NewConnectionApplicationStatuses { get; set; }
        public virtual ICollection<NewConnectionContractor> NewConnectionContractors { get; set; }
        public virtual ICollection<NewConnection> NewConnections { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
