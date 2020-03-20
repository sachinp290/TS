using System.Collections.Generic;

namespace TS.DataAccess
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        List<T> Get();
        void Delete(int id);
        void Update(T item);
    }
}
