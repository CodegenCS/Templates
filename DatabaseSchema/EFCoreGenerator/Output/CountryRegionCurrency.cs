using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public partial class CountryRegionCurrency
    {
        public string CountryRegionCode { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual CountryRegion CountryRegionCode1 { get; set; }
        public virtual Currency CurrencyCode1 { get; set; }
    }
}