using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public partial class UnitMeasure
    {
        public UnitMeasure()
        {
            BillOfMaterials = new HashSet<BillOfMaterials>();
            Product = new HashSet<Product>();
            Product2 = new HashSet<Product>();
            ProductVendor = new HashSet<ProductVendor>();
        }
        public string UnitMeasureCode { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<BillOfMaterials> BillOfMaterials { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<Product> Product2 { get; set; }
        public virtual ICollection<ProductVendor> ProductVendor { get; set; }
    }
}