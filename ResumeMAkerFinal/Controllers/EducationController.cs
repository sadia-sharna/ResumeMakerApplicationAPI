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
    [RoutePrefix("api/Education")]
    public class EducationController : ApiController
    {

        [HttpPost]
        [Route("Post")]



        public HttpResponseMessage Post([FromBody]educationTable education)
        {
            
            try
            {
                using (ResumeMakerDatabaseEntities entities = new ResumeMakerDatabaseEntities())
                {
                    
                    entities.educationTables.Add(education);
                    var result = entities.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, education);
                }
            
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        public List<examTable> Get()
        {
            ResumeMakerDatabaseEntities entities = new ResumeMakerDatabaseEntities();
            var examList = (from c in entities.examTables select c).ToList();
            return examList;

        }
    }
}
