using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.DataAccess;
using TS.Entities;

namespace TS.Service
{
    public class TopicService : IService<Topic>
    {
        IRepository<TS.Entities.Topic> repo;
        public TopicService()
        {
            repo = new TopicRepository();
        }
        public List<Entities.Topic> Get()
        {
            return repo.Get();
        }

        public Entities.Topic Get(int id)
        {
            return repo.Get(id);
        }

        public void Update(Topic item)
        {
            repo.Update(item);
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }
    }
}
