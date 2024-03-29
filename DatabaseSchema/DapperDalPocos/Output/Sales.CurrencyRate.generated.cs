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
    [Table("CurrencyRate", Schema = "Sales")]
    public partial class CurrencyRate
    {
        #region Members
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CurrencyRateId { get; set; }

        public decimal AverageRate { get; set; }

        public DateTime CurrencyRateDate { get; set; }

        public decimal EndOfDayRate { get; set; }

        public string FromCurrencyCode { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string ToCurrencyCode { get; set; }
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
            CurrencyRate other = obj as CurrencyRate;
            if (other == null) return false;

            if (AverageRate != other.AverageRate)
                return false;
            if (CurrencyRateDate != other.CurrencyRateDate)
                return false;
            if (EndOfDayRate != other.EndOfDayRate)
                return false;
            if (FromCurrencyCode != other.FromCurrencyCode)
                return false;
            if (ModifiedDate != other.ModifiedDate)
                return false;
            if (ToCurrencyCode != other.ToCurrencyCode)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (AverageRate == default(decimal) ? 0 : AverageRate.GetHashCode());
                hash = hash * 23 + (CurrencyRateDate == default(DateTime) ? 0 : CurrencyRateDate.GetHashCode());
                hash = hash * 23 + (EndOfDayRate == default(decimal) ? 0 : EndOfDayRate.GetHashCode());
                hash = hash * 23 + (FromCurrencyCode == null ? 0 : FromCurrencyCode.GetHashCode());
                hash = hash * 23 + (ModifiedDate == default(DateTime) ? 0 : ModifiedDate.GetHashCode());
                hash = hash * 23 + (ToCurrencyCode == null ? 0 : ToCurrencyCode.GetHashCode());
                return hash;
            }
        }
        public static bool operator ==(CurrencyRate left, CurrencyRate right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CurrencyRate left, CurrencyRate right)
        {
            return !Equals(left, right);
        }
        #endregion Equals/GetHashCode
    }
}
