using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigSalutationLookup
    {
        public short? SalutationId { get; set; }
        public string Salutation { get; set; }
        public string Sspsalutation { get; set; }
    }
}
