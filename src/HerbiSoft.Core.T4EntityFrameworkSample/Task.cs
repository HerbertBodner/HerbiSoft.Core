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
    
    public partial class Task
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> ParentID { get; set; }
        public bool IsDisabled { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public string CreatedUser { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public string ModifiedUser { get; set; }
        public long UniqueKey { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> Finish { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
    }
}
