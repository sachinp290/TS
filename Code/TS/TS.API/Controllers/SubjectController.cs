using System.Web.Http;
using TS.Entities;
using TS.Service;

namespace TS.API.Controllers
{
    public class SubjectController : ApiController
    {
        // GET: api/Subject
        public IHttpActionResult Get()
        {
            ISubjectService service = new SubjectService();
            var items = service.GetSubjects();

            if (items.Count == 0)
            {
                return NotFound();
            }
            return Ok(items);
        }

        // GET: api/Subject/5
        public IHttpActionResult Get(int id)
        {
            ISubjectService service = new SubjectService();
            var item = service.GetSubject(id);
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

            ISubjectService service = new SubjectService();
            service.UpdateSubject(value);
            return Ok();
        }


        // PUT: api/Subject/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Subject/5
        public void Delete(int id)
        {
        }
    }
}
