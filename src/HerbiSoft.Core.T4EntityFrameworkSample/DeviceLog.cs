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
    
    public partial class DeviceLog
    {
        public System.Guid ID { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public string CreatedUser { get; set; }
        public System.Guid DeviceID { get; set; }
        public int Type { get; set; }
        public Nullable<System.DateTime> Executed { get; set; }
        public bool Successfully { get; set; }
        public string Result { get; set; }
    
        public virtual Device Device { get; set; }
    }
}
