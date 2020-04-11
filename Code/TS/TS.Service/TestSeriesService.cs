using System.Collections.Generic;
using TS.DataAccess;
using TS.Entities;

namespace TS.Service
{
    public class TestSeriesService : IService<TestSeries>
    {
        IRepository<TS.Entities.TestSeries> repo;
        public TestSeriesService()
        {
            repo = new TestSeriesRepository();
        }
        public TestSeries Get(int id)
        {
            return repo.Get(id);
        }

        public List<TestSeries> Get()
        {
            return repo.Get();
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }

        public void Update(TestSeries item)
        {
            repo.Update(item);
        }
    }
}
