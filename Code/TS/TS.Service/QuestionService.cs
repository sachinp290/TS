using System.Collections.Generic;
using TS.DataAccess;

namespace TS.Service
{
   public class QuestionService : IQuestionService
    {
        IRepository<TS.Entities.Question> repo;
        public QuestionService()
        {
            repo = new QuestionRepository();
        }
        public List<Entities.Question> GetQuestions()
        {
            return repo.Get();
        }

        public Entities.Question GetQuestion(int id)
        {
            return repo.Get(id);
        }

        public void UpdateQuestion(Entities.Question item)
        {
            repo.Update(item);
        }

        public void DeleteQuestion(int id)
        {
            repo.Delete(id);
        }
    }
}
