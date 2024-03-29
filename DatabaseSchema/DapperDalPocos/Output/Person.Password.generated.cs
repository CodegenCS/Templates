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
    [Table("Password", Schema = "Person")]
    public partial class Password
    {
        #region Members
        [Key]
        public int BusinessEntityId { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

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
            Password other = obj as Password;
            if (other == null) return false;

            if (BusinessEntityId != other.BusinessEntityId)
                return false;
            if (ModifiedDate != other.ModifiedDate)
                return false;
            if (PasswordHash != other.PasswordHash)
                return false;
            if (PasswordSalt != other.PasswordSalt)
                return false;
            if (Rowguid != other.Rowguid)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (BusinessEntityId == default(int) ? 0 : BusinessEntityId.GetHashCode());
                hash = hash * 23 + (ModifiedDate == default(DateTime) ? 0 : ModifiedDate.GetHashCode());
                hash = hash * 23 + (PasswordHash == null ? 0 : PasswordHash.GetHashCode());
                hash = hash * 23 + (PasswordSalt == null ? 0 : PasswordSalt.GetHashCode());
                hash = hash * 23 + (Rowguid == default(Guid) ? 0 : Rowguid.GetHashCode());
                return hash;
            }
        }
        public static bool operator ==(Password left, Password right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Password left, Password right)
        {
            return !Equals(left, right);
        }
        #endregion Equals/GetHashCode
    }
}
