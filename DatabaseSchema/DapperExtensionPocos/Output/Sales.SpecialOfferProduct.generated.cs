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
    [Table("SpecialOfferProduct", Schema = "Sales")]
    public partial class SpecialOfferProduct
    {
        #region Members
        [Key]
        public int SpecialOfferId { get; set; }

        [Key]
        public int ProductId { get; set; }

        public DateTime ModifiedDate { get; set; }

        public Guid Rowguid { get; set; }
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
            SpecialOfferProduct other = obj as SpecialOfferProduct;
            if (other == null) return false;

            if (ModifiedDate != other.ModifiedDate)
                return false;
            if (ProductId != other.ProductId)
                return false;
            if (Rowguid != other.Rowguid)
                return false;
            if (SpecialOfferId != other.SpecialOfferId)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (ModifiedDate == default(DateTime) ? 0 : ModifiedDate.GetHashCode());
                hash = hash * 23 + (ProductId == default(int) ? 0 : ProductId.GetHashCode());
                hash = hash * 23 + (Rowguid == default(Guid) ? 0 : Rowguid.GetHashCode());
                hash = hash * 23 + (SpecialOfferId == default(int) ? 0 : SpecialOfferId.GetHashCode());
                return hash;
            }
        }
        public static bool operator ==(SpecialOfferProduct left, SpecialOfferProduct right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SpecialOfferProduct left, SpecialOfferProduct right)
        {
            return !Equals(left, right);
        }
        #endregion Equals/GetHashCode
    }
}
