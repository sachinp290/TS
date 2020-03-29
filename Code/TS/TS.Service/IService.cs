using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Service
{
    public interface IService<T> where T : class
    {
        T Get(int id);
        List<T> Get();
        void Delete(int id);
        void Update(T item);
    }
}