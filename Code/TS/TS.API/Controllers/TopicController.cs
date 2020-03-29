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
            IService<Topic> service = new TopicService();
            var items = service.Get();

            if (items.Count == 0)
            {
                return NotFound();
            }
            return Ok(items);
        }

        // GET: api/Topic/5
        public IHttpActionResult Get(int id)
        {
            IService<Topic> service = new TopicService();
            var item = service.Get(id);
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

            IService<Topic>  service = new TopicService();
            service.Update(value);
            return Ok();
        }

        // DELETE: api/Topic/5
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid id");
            IService<Topic> service = new TopicService();
            service.Delete(id);
            return Ok();
        }
    }
}
