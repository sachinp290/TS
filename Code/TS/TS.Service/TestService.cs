using System.Collections.Generic;
using TS.DataAccess;
using TS.Entities;

namespace TS.Service
{
    public class TestService : IService<Test>
    {
        IRepository<TS.Entities.Test> repo;
        public TestService()
        {
            repo = new TestRepository();
        }
        public Test Get(int id)
        {
            return repo.Get(id);
        }

        public List<Test> Get()
        {
            return repo.Get();
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }

        public void Update(Test item)
        {
            repo.Update(item);
        }
    }
}
