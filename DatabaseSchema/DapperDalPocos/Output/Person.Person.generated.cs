﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by dotnet-codegencs tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MyNamespace
{
    [Table("Person", Schema = "Person")]
    public partial class Person
    {
        #region Members
        [Key]
        public int BusinessEntityId { get; set; }

        public string AdditionalContactInfo { get; set; }

        public string Demographics { get; set; }

        public int EmailPromotion { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool NameStyle { get; set; }

        public string PersonType { get; set; }

        public Guid Rowguid { get; set; }

        public string Suffix { get; set; }

        public string Title { get; set; }
        #endregion Members

        #region Equals/GetHashCode
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            Person other = obj as Person;
            if (other == null) return false;

            if (AdditionalContactInfo != other.AdditionalContactInfo)
                return false;
            if (BusinessEntityId != other.BusinessEntityId)
                return false;
            if (Demographics != other.Demographics)
                return false;
            if (EmailPromotion != other.EmailPromotion)
                return false;
            if (FirstName != other.FirstName)
                return false;
            if (LastName != other.LastName)
                return false;
            if (MiddleName != other.MiddleName)
                return false;
            if (ModifiedDate != other.ModifiedDate)
                return false;
            if (NameStyle != other.NameStyle)
                return false;
            if (PersonType != other.PersonType)
                return false;
            if (Rowguid != other.Rowguid)
                return false;
            if (Suffix != other.Suffix)
                return false;
            if (Title != other.Title)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (AdditionalContactInfo == null ? 0 : AdditionalContactInfo.GetHashCode());
                hash = hash * 23 + (BusinessEntityId == default(int) ? 0 : BusinessEntityId.GetHashCode());
                hash = hash * 23 + (Demographics == null ? 0 : Demographics.GetHashCode());
                hash = hash * 23 + (EmailPromotion == default(int) ? 0 : EmailPromotion.GetHashCode());
                hash = hash * 23 + (FirstName == null ? 0 : FirstName.GetHashCode());
                hash = hash * 23 + (LastName == null ? 0 : LastName.GetHashCode());
                hash = hash * 23 + (MiddleName == null ? 0 : MiddleName.GetHashCode());
                hash = hash * 23 + (ModifiedDate == default(DateTime) ? 0 : ModifiedDate.GetHashCode());
                hash = hash * 23 + (NameStyle == default(bool) ? 0 : NameStyle.GetHashCode());
                hash = hash * 23 + (PersonType == null ? 0 : PersonType.GetHashCode());
                hash = hash * 23 + (Rowguid == default(Guid) ? 0 : Rowguid.GetHashCode());
                hash = hash * 23 + (Suffix == null ? 0 : Suffix.GetHashCode());
                hash = hash * 23 + (Title == null ? 0 : Title.GetHashCode());
                return hash;
            }
        }
        public static bool operator ==(Person left, Person right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !Equals(left, right);
        }
        #endregion Equals/GetHashCode
    }
}
