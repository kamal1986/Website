using System;
using System.Collections.Generic;

namespace clearviewoptical.DB
{
    public partial class ProductFeatureLine
    {
        public ProductFeatureLine()
        {
            ProductSubFeatureLine = new HashSet<ProductSubFeatureLine>();
        }

        public long Id { get; set; }
        public long? ProductSubId { get; set; }
        public string FeatureLine { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }
        public long? ProductId { get; set; }

        public virtual ProductMaster Product { get; set; }
        public virtual ICollection<ProductSubFeatureLine> ProductSubFeatureLine { get; set; }
    }
}
