using System;
using System.Collections.Generic;

namespace clearviewoptical.DB
{
    public partial class ProductSubFeatureLine
    {
        public long Id { get; set; }
        public string ProductSubFeature { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ProductId { get; set; }

        public virtual ProductFeatureLine Product { get; set; }
    }
}
