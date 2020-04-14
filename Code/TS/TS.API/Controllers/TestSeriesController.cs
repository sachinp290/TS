using System.Web.Http;
using TS.Entities;
using TS.Service;

namespace TS.API.Controllers
{
    [Authorize]
    public class TestSeriesController : ApiController
    {
        public IHttpActionResult Get()
        {
            IService<TestSeries> service = new TestSeriesService();
            var items = service.Get();

            if (items.Count == 0)
            {
                return NotFound();
            }
            return Ok(items);
        }

        // GET: api/TestSeries/5
        public IHttpActionResult Get(int id)
        {
            IService<TestSeries> service = new TestSeriesService();
            var item = service.Get(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // POST: api/TestSeries
        public IHttpActionResult Post([FromBody]TestSeries value)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            IService<TestSeries> service = new TestSeriesService();
            service.Update(value);
            return Ok();
        }

        // DELETE: api/TestSeries/5
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid id");
            IService<TestSeries> service = new TestSeriesService();
            service.Delete(id);
            return Ok();
        }
    }
}
