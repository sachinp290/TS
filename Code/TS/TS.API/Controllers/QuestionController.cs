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
            IQuestionService service = new QuestionService();
            var items = service.GetQuestions();

            if (items.Count == 0)
            {
                return NotFound();
            }
            return Ok(items);
        }

        // GET: api/Question/5
        public IHttpActionResult Get(int id)
        {
            IQuestionService service = new QuestionService();
            var item = service.GetQuestion(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // POST: api/Question
        public IHttpActionResult Post([FromBody]Question value)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            IQuestionService service = new QuestionService();
            service.UpdateQuestion(value);
            return Ok();
        }

        // DELETE: api/Question/5
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid id");
            IQuestionService service = new QuestionService();
            service.DeleteQuestion(id);
            return Ok();
        }
    }
}
