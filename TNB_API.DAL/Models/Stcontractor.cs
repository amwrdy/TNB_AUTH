using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Stcontractor
    {
        public Stcontractor()
        {
            Contractors = new HashSet<Contractor>();
        }

        public long StcontractorId { get; set; }
        public long? CompanyKey { get; set; }
        public string RegistrationNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MailingAddress1S { get; set; }
        public string MailingAddress2S { get; set; }
        public string MailingAddress3S { get; set; }
        public string PosCodeS { get; set; }
        public int? CityCodeS { get; set; }
        public int StateCodeS { get; set; }
        public string CountryCodeS { get; set; }
        public string MobileNumberS { get; set; }
        public string FaxS { get; set; }
        public string CodeCategory { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? GeneratedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public long? EcibscontractorId { get; set; }
        public int? EcibssyncStatus { get; set; }
        public DateTime? PrintDate { get; set; }

        public virtual ICollection<Contractor> Contractors { get; set; }
    }
}
