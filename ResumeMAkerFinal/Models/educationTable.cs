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
    
    public partial class educationTable
    {
        public int education_id { get; set; }
        public int resume_id { get; set; }
        public int exam_id { get; set; }
        public string institute_name { get; set; }
        public Nullable<double> result { get; set; }
        public Nullable<int> graduation_year { get; set; }
    
        public virtual examTable examTable { get; set; }
        public virtual profileTable profileTable { get; set; }
    }
}
