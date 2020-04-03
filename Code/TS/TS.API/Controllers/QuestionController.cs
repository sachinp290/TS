using System.Web.Http;
using TS.Entities;
using TS.Service;

namespace TS.API.Controllers
{
    public class QuestionController : ApiController
    {
        // GET: api/Question
        public IHttpActionResult Get()
        {
            IService<Question> service = new QuestionService();
            var items = service.Get();
            return Ok(items);
        }

        // GET: api/Question/5
        public IHttpActionResult Get(int id)
        {
            IService<Question> service = new QuestionService();
            var item = service.Get(id);
            return Ok(item);
        }

        // POST: api/Question
        public IHttpActionResult Post([FromBody]Question value)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            IService<Question> service = new QuestionService();
            service.Update(value);
            return Ok();
        }

        // DELETE: api/Question/5
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid id");
            IService<Question> service = new QuestionService();
            service.Delete(id);
            return Ok();
        }
    }
}
