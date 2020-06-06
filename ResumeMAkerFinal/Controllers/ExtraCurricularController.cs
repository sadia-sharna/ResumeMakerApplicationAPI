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
    [RoutePrefix("api/extraCurricular")]
    public class ExtraCurricularController : ApiController
    {
        [HttpPost]
        [Route("Post")]
        public HttpResponseMessage Post([FromBody]extraCurricularTable extraCurricular)
        {
           
            try
            {
                using (ResumeMakerDatabaseEntities entities = new ResumeMakerDatabaseEntities())
                {
                   
                    //string json = JsonConvert.SerializeObject(extraCurricular);
                    entities.extraCurricularTables.Add(extraCurricular);
                    var result = entities.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, extraCurricular);
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
