//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResumeMAkerFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class extraCurricularTable
    {
        public int extraCrId { get; set; }
        public int resume_id { get; set; }
        public string activity { get; set; }
    
        public virtual profileTable profileTable { get; set; }
    }
}
