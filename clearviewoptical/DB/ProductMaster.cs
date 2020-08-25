using System;
using System.Collections.Generic;

namespace clearviewoptical.DB
{
    public partial class ProductMaster
    {
        public ProductMaster()
        {
            ProductFeatureLine = new HashSet<ProductFeatureLine>();
        }

        public long Id { get; set; }
        public string ProductName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public long? ProductCat { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }

        public virtual ProductCatMaster ProductCatNavigation { get; set; }
        public virtual ICollection<ProductFeatureLine> ProductFeatureLine { get; set; }
    }
}
