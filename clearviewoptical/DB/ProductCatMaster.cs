using System;
using System.Collections.Generic;

namespace clearviewoptical.DB
{
    public partial class ProductCatMaster
    {
        public ProductCatMaster()
        {
            ProductMaster = new HashSet<ProductMaster>();
        }

        public long Id { get; set; }
        public string ProductcatName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<ProductMaster> ProductMaster { get; set; }
    }
}
