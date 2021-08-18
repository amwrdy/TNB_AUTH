using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class UserListProdRoleSeparationDeleted
    {
        public Guid Ncusername { get; set; }
        public int? NewConnection { get; set; }
        public Guid? Cotusername { get; set; }
        public int? Cot { get; set; }
        public Guid? Coausername { get; set; }
        public int? Coa { get; set; }
        public Guid? ProjectUsername { get; set; }
        public int? Project { get; set; }
        public Guid? RewiringUsername { get; set; }
        public int? Rewiring { get; set; }
        public Guid? MerdeakIncentiveUsername { get; set; }
        public int? MerdekaIncentive { get; set; }
        public Guid? Smrusername { get; set; }
        public int? Smr { get; set; }
        public Guid? Causername { get; set; }
        public int? Ca { get; set; }
        public Guid? ContractorUsername { get; set; }
        public string Contractor { get; set; }
        public string Role { get; set; }
    }
}
