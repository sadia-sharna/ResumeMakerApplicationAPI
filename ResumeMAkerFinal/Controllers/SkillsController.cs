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
    [RoutePrefix("api/Skills")]
    public class SkillsController : ApiController
    {

        [HttpPost]
        [Route("Post")]

        public HttpResponseMessage Post([FromBody]skillsTable skills)
        {

            try
            {
                using (ResumeMakerDatabaseEntities entities = new ResumeMakerDatabaseEntities())
                {
                    //string json = JsonConvert.SerializeObject(skills);
                    entities.skillsTables.Add(skills);
                    var result = entities.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, skills);
                    //return Request.CreateResponse(HttpStatusCode.OK, json);
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        public List<toolsExpertiseLevel> Get()
        {
            ResumeMakerDatabaseEntities entities = new ResumeMakerDatabaseEntities();
            var tools = (from c in entities.toolsExpertiseLevels select c).ToList();
            return tools;

        }
        [HttpGet]
        [Route("skills")]
        public List<skillsSetTable> skills()
        {
            ResumeMakerDatabaseEntities entities = new ResumeMakerDatabaseEntities();
            var skillList = (from c in entities.skillsSetTables select c).ToList();
            return skillList;

        }
    }
}
