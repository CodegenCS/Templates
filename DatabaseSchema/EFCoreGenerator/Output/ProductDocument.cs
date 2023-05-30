using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public partial class ProductDocument
    {
        public int ProductId { get; set; }
        public Microsoft.SqlServer.Types.SqlHierarchyId DocumentNode { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Document DocumentNode1 { get; set; }
        public virtual Product Product { get; set; }
    }
}