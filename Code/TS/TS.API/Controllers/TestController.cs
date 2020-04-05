using System.Web.Http;
using TS.Entities;
using TS.Service;

namespace TS.API.Controllers
{
    public class TestController : ApiController
    {
        public IHttpActionResult Get()
        {
            IService<Test> service = new TestService();
            var items = service.Get();

            if (items.Count == 0)
            {
                return NotFound();
            }
            return Ok(items);
        }

        // GET: api/Test/5
        public IHttpActionResult Get(int id)
        {
            IService<Test> service = new TestService();
            var item = service.Get(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // POST: api/Test
        public IHttpActionResult Post([FromBody]Test value)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            IService<Test> service = new TestService();
            service.Update(value);
            return Ok();
        }

        // DELETE: api/Test/5
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid id");
            IService<Test> service = new TestService();
            service.Delete(id);
            return Ok();
        }
    }
}
