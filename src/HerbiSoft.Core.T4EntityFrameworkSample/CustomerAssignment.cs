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
    
    public partial class CustomerAssignment
    {
        public System.Guid ID { get; set; }
        public bool IsDisabled { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public string CreatedUser { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public string ModifiedUser { get; set; }
        public System.Guid CustomerID { get; set; }
        public System.Guid UserID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual User1 User1 { get; set; }
    }
}
