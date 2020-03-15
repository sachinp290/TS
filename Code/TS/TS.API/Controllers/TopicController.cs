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
    public class TopicController : ApiController
    {
        // GET: api/Topic
        public IEnumerable<Topic> Get()
        {
            ITopicService service = new TopicService();
            return service.GetTopics();
        }

        // GET: api/Topic/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Topic
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Topic/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Topic/5
        public void Delete(int id)
        {
        }
    }
}
