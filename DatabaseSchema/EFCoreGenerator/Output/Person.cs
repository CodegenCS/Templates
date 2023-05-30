using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public partial class Person
    {
        public Person()
        {
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
            Customer = new HashSet<Customer>();
            EmailAddress = new HashSet<EmailAddress>();
            Employee = new HashSet<Employee>();
            Password = new HashSet<Password>();
            PersonCreditCard = new HashSet<PersonCreditCard>();
            PersonPhone = new HashSet<PersonPhone>();
        }
        public int BusinessEntityId { get; set; }
        public string PersonType { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public string AdditionalContactInfo { get; set; }
        public string Demographics { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<EmailAddress> EmailAddress { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Password> Password { get; set; }
        public virtual ICollection<PersonCreditCard> PersonCreditCard { get; set; }
        public virtual ICollection<PersonPhone> PersonPhone { get; set; }
    }
}