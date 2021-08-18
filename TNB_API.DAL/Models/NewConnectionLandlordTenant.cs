using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class NewConnectionLandlordTenant
    {
        public int NewConnectionId { get; set; }
        public string Tagging { get; set; }
        public int LandLordNewConnectionId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual NewConnection NewConnection { get; set; }
    }
}
