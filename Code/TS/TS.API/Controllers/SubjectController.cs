using System.Web.Http;
using TS.Entities;
using TS.Service;

namespace TS.API.Controllers
{
    [Authorize]
    public class SubjectController : ApiController
    {
        // GET: api/Subject
        public IHttpActionResult Get()
        {
            IService<Subject> service = new SubjectService();
            var items = service.Get();

            if (items.Count == 0)
            {
                return NotFound();
            }
            return Ok(items);
        }

        // GET: api/Subject/5
        public IHttpActionResult Get(int id)
        {
            IService<Subject> service = new SubjectService();
            var item = service.Get(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // POST: api/Subject
        public IHttpActionResult Post([FromBody]Subject value)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            IService<Subject> service = new SubjectService();
            service.Update(value);
            return Ok();
        }

        // DELETE: api/Subject/5
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid id");
            IService<Subject> service = new SubjectService();
            service.Delete(id);
            return Ok();
        }
    }
}
