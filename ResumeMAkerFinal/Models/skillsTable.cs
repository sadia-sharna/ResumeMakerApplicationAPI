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
    
    public partial class skillsTable
    {
        public int skill_id { get; set; }
        public int resume_id { get; set; }
        public int s_id { get; set; }
        public int toolsExpertId { get; set; }
    
        public virtual profileTable profileTable { get; set; }
        public virtual skillsSetTable skillsSetTable { get; set; }
        public virtual toolsExpertiseLevel toolsExpertiseLevel { get; set; }
    }
}
