using System.Web.Http;
using TS.Entities;
using TS.Service;

namespace TS.API.Controllers
{
    public class TopicController : ApiController
    {
        // GET: api/Topic
        public IHttpActionResult Get()
        {
            ITopicService service = new TopicService();
            var items = service.GetTopics();
            if (items.Count == 0)
            {
                return NotFound();
            }
            return Ok(items);
        }

        // GET: api/Topic/5
        public IHttpActionResult Get(int id)
        {
            ITopicService service = new TopicService();
            var item = service.GetTopic(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // POST: api/Topic
        public void Post([FromBody]Topic value)
        {
            ITopicService service = new TopicService();
            service.UpdateTopic(value);
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
