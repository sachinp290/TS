using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TS.Service;

namespace TS.API.Controllers
{
    public class ComplexityController : ApiController
    {
        // GET: api/Question
        public IHttpActionResult Get()
        {
            IIDNamePairService service = new IDNamePairService();
            var items = service.Get("Complexity");
            return Ok(items);
        }

    }
}
