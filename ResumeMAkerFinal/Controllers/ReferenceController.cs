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
    [RoutePrefix("api/Reference")]
    public class ReferenceController : ApiController
    {
        [HttpPost]
        [Route("Post")]
        public HttpResponseMessage Post([FromBody]referenceTable reference)
        {

            try
            {
                using (ResumeMakerDatabaseEntities entities = new ResumeMakerDatabaseEntities())
                {
                    //string json = JsonConvert.SerializeObject(reference);
                    entities.referenceTables.Add(reference);
                    var result = entities.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, reference);
                    // return Request.CreateResponse(HttpStatusCode.OK, json);
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}

