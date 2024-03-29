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
    [Table("PurchaseOrderHeader", Schema = "Purchasing")]
    public partial class PurchaseOrderHeader
    {
        #region Members
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchaseOrderId { get; set; }

        public int EmployeeId { get; set; }

        public decimal Freight { get; set; }

        public DateTime ModifiedDate { get; set; }

        public DateTime OrderDate { get; set; }

        public byte RevisionNumber { get; set; }

        public DateTime? ShipDate { get; set; }

        public int ShipMethodId { get; set; }

        public byte Status { get; set; }

        public decimal SubTotal { get; set; }

        public decimal TaxAmt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal TotalDue { get; set; }

        public int VendorId { get; set; }
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
            PurchaseOrderHeader other = obj as PurchaseOrderHeader;
            if (other == null) return false;

            if (EmployeeId != other.EmployeeId)
                return false;
            if (Freight != other.Freight)
                return false;
            if (ModifiedDate != other.ModifiedDate)
                return false;
            if (OrderDate != other.OrderDate)
                return false;
            if (RevisionNumber != other.RevisionNumber)
                return false;
            if (ShipDate != other.ShipDate)
                return false;
            if (ShipMethodId != other.ShipMethodId)
                return false;
            if (Status != other.Status)
                return false;
            if (SubTotal != other.SubTotal)
                return false;
            if (TaxAmt != other.TaxAmt)
                return false;
            if (TotalDue != other.TotalDue)
                return false;
            if (VendorId != other.VendorId)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (EmployeeId == default(int) ? 0 : EmployeeId.GetHashCode());
                hash = hash * 23 + (Freight == default(decimal) ? 0 : Freight.GetHashCode());
                hash = hash * 23 + (ModifiedDate == default(DateTime) ? 0 : ModifiedDate.GetHashCode());
                hash = hash * 23 + (OrderDate == default(DateTime) ? 0 : OrderDate.GetHashCode());
                hash = hash * 23 + (RevisionNumber == default(byte) ? 0 : RevisionNumber.GetHashCode());
                hash = hash * 23 + (ShipDate == null ? 0 : ShipDate.GetHashCode());
                hash = hash * 23 + (ShipMethodId == default(int) ? 0 : ShipMethodId.GetHashCode());
                hash = hash * 23 + (Status == default(byte) ? 0 : Status.GetHashCode());
                hash = hash * 23 + (SubTotal == default(decimal) ? 0 : SubTotal.GetHashCode());
                hash = hash * 23 + (TaxAmt == default(decimal) ? 0 : TaxAmt.GetHashCode());
                hash = hash * 23 + (TotalDue == default(decimal) ? 0 : TotalDue.GetHashCode());
                hash = hash * 23 + (VendorId == default(int) ? 0 : VendorId.GetHashCode());
                return hash;
            }
        }
        public static bool operator ==(PurchaseOrderHeader left, PurchaseOrderHeader right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PurchaseOrderHeader left, PurchaseOrderHeader right)
        {
            return !Equals(left, right);
        }
        #endregion Equals/GetHashCode
    }
}
