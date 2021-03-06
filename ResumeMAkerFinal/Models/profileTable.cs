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
    
    public partial class profileTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public profileTable()
        {
            this.educationTables = new HashSet<educationTable>();
            this.extraCurricularTables = new HashSet<extraCurricularTable>();
            this.referenceTables = new HashSet<referenceTable>();
            this.skillsTables = new HashSet<skillsTable>();
        }
    
        public int ressume_id { get; set; }
        public string name { get; set; }
        public Nullable<int> phone { get; set; }
        public string email { get; set; }
        public string linkedin { get; set; }
        public string github { get; set; }
        public string profile_descr { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<educationTable> educationTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<extraCurricularTable> extraCurricularTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<referenceTable> referenceTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<skillsTable> skillsTables { get; set; }
    }
}
