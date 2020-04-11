using System.Collections.Generic;
using TS.DataAccess;
using TS.Entities;

namespace TS.Service
{
    public interface ITestSubjectService
    {
        List<TestSubject> Get(int testID);
        void Add(TestSubject item);
        void Delete(int id);
    }
    public class TestSubjectService : ITestSubjectService
    {
        ITestSubjectRepository repo;
        public TestSubjectService()
        {
            repo = new TestSubjectRepository();
        }
        public List<TestSubject> Get(int testID)
        {
            return repo.Get(testID);
        }


        public void Add(TestSubject item)
        {
            repo.Add(item);
        }


        public void Delete(int id)
        {
            repo.Delete(id);
        }
    }
}
