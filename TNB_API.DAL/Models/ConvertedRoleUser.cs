using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class ConvertedRoleUser
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int LoginCount { get; set; }
    }
}
