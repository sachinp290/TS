using System.Collections.Generic;
using TS.Entities;

namespace TS.Service
{
   public interface IQuestionService
    {
        List<Question> GetQuestions();
        Question GetQuestion(int id);
        void UpdateQuestion(Question item);
        void DeleteQuestion(int id);
    }
}
