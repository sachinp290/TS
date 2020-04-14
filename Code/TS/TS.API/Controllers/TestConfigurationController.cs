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
    [Authorize]
    public class TestConfigurationController : ApiController
    {
        // GET: api/TestConfiguration
        public IHttpActionResult Get()
        {
            IService<TestConfiguration> service = new TestConfigurationService();
            var items = service.Get();
            return Ok(items);
        }

        // GET: api/TestConfiguration/5
        public IHttpActionResult Get(int id)
        {
            IService<TestConfiguration> service = new TestConfigurationService();
            var item = service.Get(id);
            return Ok(item);
        }

        // POST: api/TestConfiguration
        public IHttpActionResult Post([FromBody]TestConfiguration value)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            IService<TestConfiguration> service = new TestConfigurationService();
            service.Update(value);
            return Ok();
        }

        // DELETE: api/TestConfiguration/5
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid id");
            IService<TestConfiguration> service = new TestConfigurationService();
            service.Delete(id);
            return Ok();
        }
    }
}
