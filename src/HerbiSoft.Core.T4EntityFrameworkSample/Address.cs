//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HerbiSoft.Core.T4EntityFrameworkSample
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public Address()
        {
            this.AddressAssignment = new HashSet<AddressAssignment>();
            this.AddressPolicyAssignment = new HashSet<AddressPolicyAssignment>();
            this.BreakAssignment = new HashSet<BreakAssignment>();
            this.RoundAssignment = new HashSet<RoundAssignment>();
        }
    
        public System.Guid ID { get; set; }
        public bool IsDisabled { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public string CreatedUser { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public string ModifiedUser { get; set; }
        public int RealType { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public int Number { get; set; }
        public bool IsActive { get; set; }
        public string Street { get; set; }
        public string HouseNo { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string Homepage { get; set; }
        public int Color { get; set; }
        public string Description { get; set; }
        public decimal MaxHoursInGraph { get; set; }
        public decimal MaxCountInGraph { get; set; }
    
        public virtual ICollection<AddressAssignment> AddressAssignment { get; set; }
        public virtual ICollection<AddressPolicyAssignment> AddressPolicyAssignment { get; set; }
        public virtual Area Area { get; set; }
        public virtual ICollection<BreakAssignment> BreakAssignment { get; set; }
        public virtual Company Company { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Organisation Organisation { get; set; }
        public virtual ICollection<RoundAssignment> RoundAssignment { get; set; }
    }
}
