using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class TechnologyCategory
    {
        public TechnologyCategory()
        {
            TechnologySubCategories = new HashSet<TechnologySubCategory>();
        }

        public int TechCategoryId { get; set; }
        public string Category { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string CategoryCode { get; set; }

        public virtual ICollection<TechnologySubCategory> TechnologySubCategories { get; set; }
    }
}
