using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public partial class Currency
    {
        public Currency()
        {
            CountryRegionCurrency = new HashSet<CountryRegionCurrency>();
            CurrencyRate = new HashSet<CurrencyRate>();
            CurrencyRate2 = new HashSet<CurrencyRate>();
        }
        public string CurrencyCode { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrency { get; set; }
        public virtual ICollection<CurrencyRate> CurrencyRate { get; set; }
        public virtual ICollection<CurrencyRate> CurrencyRate2 { get; set; }
    }
}