using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class NewConnectionAssignment
    {
        public Guid Guid { get; set; }
        public int? NewConnectionId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Action { get; set; }
    }
}
