using System.Collections.Generic;
using TS.DataAccess;
using TS.Entities;

namespace TS.Service
{
   public class QuestionService : IService<Question>
    {
        IRepository<TS.Entities.Question> repo;
        public QuestionService()
        {
            repo = new QuestionRepository();
        }
        public List<Entities.Question> Get()
        {
            return repo.Get();
        }

        public Entities.Question Get(int id)
        {
            return repo.Get(id);
        }

        public void Update(Entities.Question item)
        {
            repo.Update(item);
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }
    }
}
