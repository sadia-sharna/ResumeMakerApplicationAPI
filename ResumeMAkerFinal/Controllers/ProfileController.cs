using Newtonsoft.Json;
using ResumeMAkerFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace ResumeMAkerFinal.Controllers
{
    [RoutePrefix("api/Profile")]

    public class ProfileController : ApiController
    {

        [HttpPost]       
        public finalResumeModel Resume([FromBody]int profileid)
        {
            ResumeMakerDatabaseEntities entities = new ResumeMakerDatabaseEntities();
            finalResumeModel resumeViewModel = (from c in entities.profileTables
                                                where c.ressume_id == profileid
                                                select new finalResumeModel
                                                {
                                                    name = c.name,
                                                    email = c.email,
                                                    github =c.github,
                                                    phone = c.phone,
                                                    linkedin = c.linkedin,
                                                    profile_descr=c.profile_descr
                                                }).FirstOrDefault();

            resumeViewModel.skills = (from c in entities.profileTables
                                      where c.ressume_id == profileid
                                      join d in entities.skillsTables on c.ressume_id equals d.resume_id
                                      join e in entities.skillsSetTables on d.s_id equals e.s_id
                                      join f in entities.toolsExpertiseLevels on d.toolsExpertId equals f.toolsExpertId
                                      where c.ressume_id == profileid
                                      select new SkillVM
                                      {
                                          toolname = e.tools,
                                          expertise = f.expertise
                                      }).ToList();


            resumeViewModel.education = (from c in entities.profileTables
                                         where c.ressume_id == profileid
                                         join d in entities.educationTables on c.ressume_id equals d.resume_id
                                         join e in entities.examTables on d.exam_id equals e.exam_id
                                         select new EducationVM
                                         {
                                             exam_name = e.exam_name,
                                             institute_name = d.institute_name,
                                             result = d.result,
                                             graduation_year = d.graduation_year
                                         }
                                         ).ToList();
            resumeViewModel.reference = (from c in entities.profileTables
                                         where c.ressume_id == profileid
                                         join d in entities.referenceTables on c.ressume_id equals d.resume_id
                                         select new ReferenceVM
                                         {
                                             teacher_name = d.teacher_name,
                                             teacher_email = d.teacher_email,
                                             teacher_phone = d.teacher_phone
                                            
                                         }
                                        ).ToList();


            resumeViewModel.extraCurricular = (from c in entities.profileTables
                                         where c.ressume_id == profileid
                                         join d in entities.extraCurricularTables on c.ressume_id equals d.resume_id
                                         select new ExtracurricularVM
                                         {
                                             activity = d.activity
                                           

                                         }
                                       ).ToList();

            return resumeViewModel;


           
        

    }

        [HttpPost]
        [Route("Post")]
        public HttpResponseMessage Post([FromBody]profileTable profile)
        {

            try
            {
                using (ResumeMakerDatabaseEntities entities = new ResumeMakerDatabaseEntities())
                {
                    

                    entities.profileTables.Add(profile);
                    // string json = JsonConvert.SerializeObject(profile);
                    var result = entities.SaveChanges();
                    //  return Request.CreateResponse(HttpStatusCode.OK, json);
                    return Request.CreateResponse(HttpStatusCode.OK, profile);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        // GET api/values
        
        public profileTable Get()
        {
            ResumeMakerDatabaseEntities entities = new ResumeMakerDatabaseEntities();
            var resumeViewModel = (from c in entities.profileTables select c).ToList().OrderByDescending(x => x.ressume_id).FirstOrDefault();
            return resumeViewModel;

        }


    }
}
