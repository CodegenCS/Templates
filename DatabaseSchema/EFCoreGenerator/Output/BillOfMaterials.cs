﻿using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public partial class BillOfMaterials
    {
        public int BillOfMaterialsId { get; set; }
        public int? ProductAssemblyId { get; set; }
        public int ComponentId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string UnitMeasureCode { get; set; }
        public short BomLevel { get; set; }
        public decimal PerAssemblyQty { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Product Component { get; set; }
        public virtual Product ProductAssembly { get; set; }
        public virtual UnitMeasure UnitMeasureCode1 { get; set; }
    }
}