using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeMAkerFinal.Models
{
    public class resumeViewModel
    {
        //profile table
        public int ressume_id { get; set; }
        public string name { get; set; }
        public Nullable<int> phone { get; set; }
        public string email { get; set; }
        public string linkedin { get; set; }
        public string github { get; set; }
        public string profile_descr { get; set; }

        //education table
        public int education_id { get; set; }
        public int resume_id { get; set; }
        public int exam_id { get; set; }
        public string institute_name { get; set; }
        public Nullable<double> result { get; set; }
        public Nullable<int> graduation_year { get; set; }

        public virtual examTable examTable { get; set; }
        public virtual profileTable profileTable { get; set; }


        //exam table
        public string exam_name { get; set; }

        public virtual ICollection<educationTable> educationTables { get; set; }


        //Extracurricular table
        public int extraCrId { get; set; }    
        public string activity { get; set; }

      
        //Reference table
        public int r_id { get; set; }
        public string teacher_name { get; set; }
        public string teacher_email { get; set; }
        public Nullable<int> teacher_phone { get; set; }

        //Skills table
        public int skill_id { get; set; }
        public int s_id { get; set; }
        public int toolsExpertId { get; set; }

        public virtual skillsSetTable skillsSetTable { get; set; }
        public virtual toolsExpertiseLevel toolsExpertiseLevel { get; set; }

        //SkillsSet table
        public string tools { get; set; }
        public virtual ICollection<skillsTable> skillsTables { get; set; }

        //toolsExpertiseLevel table
        public string expertise { get; set; }
  
    }
  

}