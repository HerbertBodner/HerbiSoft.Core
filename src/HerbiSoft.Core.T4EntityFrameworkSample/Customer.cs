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
    
    public partial class Customer
    {
        public Customer()
        {
            this.CustomerAssignment = new HashSet<CustomerAssignment>();
        }
    
        public System.Guid ID { get; set; }
        public bool IsDisabled { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public string CreatedUser { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public string ModifiedUser { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Server { get; set; }
        public string DB { get; set; }
        public string ReferenceDB { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string License { get; set; }
    
        public virtual ICollection<CustomerAssignment> CustomerAssignment { get; set; }
    }
}
