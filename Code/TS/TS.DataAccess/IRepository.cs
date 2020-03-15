using System.Collections.Generic;

namespace TS.DataAccess
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        List<T> Get();
        int Add(T item);
        void Edit(T item);
        void Delete(int id);
    }
}
