using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MasterLookup
    {
        public MasterLookup()
        {
            NewConnectionReworkInformationReworkPartyNavigations = new HashSet<NewConnectionReworkInformation>();
            NewConnectionReworkInformationReworkReason1Navigations = new HashSet<NewConnectionReworkInformation>();
            NewConnectionReworkInformationReworkReason2Navigations = new HashSet<NewConnectionReworkInformation>();
            NewConnectionReworkInformationReworkReason3Navigations = new HashSet<NewConnectionReworkInformation>();
            NewConnectionReworkInformationReworkReason4Navigations = new HashSet<NewConnectionReworkInformation>();
            NewConnectionReworkInformationReworkReason5Navigations = new HashSet<NewConnectionReworkInformation>();
            NewConnectionReworkInformationReworkReason6Navigations = new HashSet<NewConnectionReworkInformation>();
            NewConnectionReworkInformationReworkReason7Navigations = new HashSet<NewConnectionReworkInformation>();
            NewConnectionReworkInformationReworkReason8Navigations = new HashSet<NewConnectionReworkInformation>();
            ProjectPics = new HashSet<ProjectPic>();
            ProjectReworkInformations = new HashSet<ProjectReworkInformation>();
        }

        public int LookupId { get; set; }
        public string Area { get; set; }
        public string Lookup { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public bool? Enabled { get; set; }
        public int? Sequence { get; set; }

        public virtual ICollection<NewConnectionReworkInformation> NewConnectionReworkInformationReworkPartyNavigations { get; set; }
        public virtual ICollection<NewConnectionReworkInformation> NewConnectionReworkInformationReworkReason1Navigations { get; set; }
        public virtual ICollection<NewConnectionReworkInformation> NewConnectionReworkInformationReworkReason2Navigations { get; set; }
        public virtual ICollection<NewConnectionReworkInformation> NewConnectionReworkInformationReworkReason3Navigations { get; set; }
        public virtual ICollection<NewConnectionReworkInformation> NewConnectionReworkInformationReworkReason4Navigations { get; set; }
        public virtual ICollection<NewConnectionReworkInformation> NewConnectionReworkInformationReworkReason5Navigations { get; set; }
        public virtual ICollection<NewConnectionReworkInformation> NewConnectionReworkInformationReworkReason6Navigations { get; set; }
        public virtual ICollection<NewConnectionReworkInformation> NewConnectionReworkInformationReworkReason7Navigations { get; set; }
        public virtual ICollection<NewConnectionReworkInformation> NewConnectionReworkInformationReworkReason8Navigations { get; set; }
        public virtual ICollection<ProjectPic> ProjectPics { get; set; }
        public virtual ICollection<ProjectReworkInformation> ProjectReworkInformations { get; set; }
    }
}
