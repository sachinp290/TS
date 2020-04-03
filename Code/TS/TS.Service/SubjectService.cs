using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.DataAccess;
using TS.Entities;

namespace TS.Service
{
    public class SubjectService : IService<Subject>
    {
        IRepository<TS.Entities.Subject> repo;
        public SubjectService()
        {
            repo = new SubjectRepository();
        }
        public List<Entities.Subject> Get()
        {
            return repo.Get();
        }

        public Entities.Subject Get(int id)
        {
            return repo.Get(id);
        }

        public void Update(Subject item)
        {
            repo.Update(item);
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }
    }
}
