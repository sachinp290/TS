using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.DataAccess;
using TS.Entities;

namespace TS.Service
{
    public class TopicService : ITopicService
    {
        IRepository<TS.Entities.Topic> repo;
        public TopicService()
        {
            repo = new TopicRepository();
        }
        public List<Entities.Topic> GetTopics()
        {
            return repo.Get();
        }

        public Entities.Topic GetTopic(int id)
        {
            return repo.Get(id);
        }

        public void UpdateTopic(Topic item)
        {
            repo.Update(item);
        }

        public void DeleteTopic(int id)
        {
            repo.Delete(id);
        }
    }
}
