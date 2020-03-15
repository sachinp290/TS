using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.DataAccess;

namespace TS.Service
{
    public class SubjectService : ISubjectService
    {
        IRepository<TS.Entities.Subject> repo;
        public SubjectService()
        {
            repo = new SubjectRepository();
        }
        public List<Entities.Subject> GetSubjects()
        {
            return repo.Get();
        }
    }
}
