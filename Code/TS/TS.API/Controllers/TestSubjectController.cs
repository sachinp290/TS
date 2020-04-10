using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TS.Entities;
using TS.Service;

namespace TS.API.Controllers
{
    public class TestSubjectController : ApiController
    {
        // GET: api/TestSubject
        public IHttpActionResult Get(int id)
        {
            ITestSubjectService service = new TestSubjectService();
            var items = service.Get(id);
            return Ok(items);
        }

        // POST: api/Topic
        public IHttpActionResult Post([FromBody]TestSubject value)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            ITestSubjectService service = new TestSubjectService();
            service.Add(value);
            return Ok();
        }
    }
}
