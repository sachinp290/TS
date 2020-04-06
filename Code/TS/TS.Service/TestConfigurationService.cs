using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.DataAccess;
using TS.Entities;

namespace TS.Service
{
   public class TestConfigurationService: IService<TestConfiguration>
    {
       IRepository<TS.Entities.TestConfiguration> repo;
       public TestConfigurationService()
        {
            repo = new TestConfigurationRepository();
        }

        public TestConfiguration Get(int id)
        {
            return repo.Get(id);
        }

        public List<TestConfiguration> Get()
        {
            return repo.Get();
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }

        public void Update(TestConfiguration item)
        {
            repo.Update(item);
        }
    }
}
