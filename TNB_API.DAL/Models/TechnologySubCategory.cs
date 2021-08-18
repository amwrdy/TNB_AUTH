using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class TechnologySubCategory
    {
        public TechnologySubCategory()
        {
            TechnologyGenerationCapacities = new HashSet<TechnologyGenerationCapacity>();
        }

        public int TechSubCategoryId { get; set; }
        public int TechCategoryId { get; set; }
        public string SubCategory { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual TechnologyCategory TechCategory { get; set; }
        public virtual ICollection<TechnologyGenerationCapacity> TechnologyGenerationCapacities { get; set; }
    }
}
