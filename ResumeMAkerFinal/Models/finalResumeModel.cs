using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeMAkerFinal.Models
{
    public class finalResumeModel
    {
        public int ressume_id { get; set; }
        public string name { get; set; }
        public Nullable<int> phone { get; set; }
        public string email { get; set; }
        public string linkedin { get; set; }
        public string github { get; set; }
        public string profile_descr { get; set; }
        public List<SkillVM> skills { get; set; }
        public List<EducationVM> education { get; set; }
        public List<ReferenceVM> reference { get; set; }
        public List<ExtracurricularVM> extraCurricular { get; set; }


    }

    public class SkillVM
    {       
        public string toolname { get; set; }
        public string expertise { get; set; }
    }

    public class EducationVM
    {
        public string exam_name { get; set; }
        public string institute_name { get; set; }
        public Nullable<double> result { get; set; }
        public Nullable<int> graduation_year { get; set; }
      
        
    }

    public class ReferenceVM
    {
       
        public string teacher_name { get; set; }
        public string teacher_email { get; set; }
        public Nullable<int> teacher_phone { get; set; }

    }
    public class ExtracurricularVM
    {
       
        public string activity { get; set; }
    }
}