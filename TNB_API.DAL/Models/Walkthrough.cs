using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Walkthrough
    {
        public int WalkthroughId { get; set; }
        public string Description { get; set; }
        public int Category { get; set; }
        public bool? IsFirstTime { get; set; }
        public Guid UserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
