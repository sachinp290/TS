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
        public IHttpActionResult Post([FromBody]Topic value)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            ITopicService service = new TopicService();
            service.UpdateTopic(value);
            return Ok();
        }

        // DELETE: api/Topic/5
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid id");
            ITopicService service = new TopicService();
            service.DeleteTopic(id);
            return Ok();
        }
    }
}
