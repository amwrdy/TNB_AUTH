using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            MerdekaIncentives = new HashSet<MerdekaIncentive>();
            NewConnections = new HashSet<NewConnection>();
            TrnAccounts = new HashSet<TrnAccount>();
        }

        public int AccountTypeId { get; set; }
        public string AccountTypeDesc { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<MerdekaIncentive> MerdekaIncentives { get; set; }
        public virtual ICollection<NewConnection> NewConnections { get; set; }
        public virtual ICollection<TrnAccount> TrnAccounts { get; set; }
    }
}
