using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TS.Service;

namespace TS.API.Controllers
{
    public class IDNamePairController : ApiController
    {
        // GET: api/Question
        public IHttpActionResult Get(string tableName)
        {
            IIDNamePairService service = new IDNamePairService();
            var items = service.Get(tableName);
            return Ok(items);
        }

    }
}
