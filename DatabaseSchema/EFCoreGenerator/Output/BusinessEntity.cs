using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public partial class BusinessEntity
    {
        public BusinessEntity()
        {
            BusinessEntityAddress = new HashSet<BusinessEntityAddress>();
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
            Person = new HashSet<Person>();
            Store = new HashSet<Store>();
            Vendor = new HashSet<Vendor>();
        }
        public int BusinessEntityId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
        public virtual ICollection<Person> Person { get; set; }
        public virtual ICollection<Store> Store { get; set; }
        public virtual ICollection<Vendor> Vendor { get; set; }
    }
}