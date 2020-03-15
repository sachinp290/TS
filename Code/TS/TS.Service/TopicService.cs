using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.DataAccess;

namespace TS.Service
{
   public class TopicService:ITopicService
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
    }
}
