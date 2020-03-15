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
    public class SubjectController : ApiController
    {
        // GET: api/Subject
        public IEnumerable<Subject> Get()
        {
            ISubjectService service = new SubjectService();
            return service.GetSubjects();
        }

        // GET: api/Subject/5
        public Subject Get(int id)
        {
            ISubjectService service = new SubjectService();
            return service.GetSubject(id);
        }

        // POST: api/Subject
        public void Post([FromBody]Subject value)
        {
            ISubjectService service = new SubjectService();
            service.UpdateSubject(value);
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
