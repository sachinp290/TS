using System.Collections.Generic;
using TS.DataAccess;

namespace TS.Service
{
    public class IDNamePairService : IIDNamePairService
    {
        IIDNamePairRepository repo;
        public IDNamePairService()
        {
            repo = new IDNamePairRepository();
        }
        public List<Entities.IDNamePair> Get(string tableName)
        {
            return repo.Get(tableName);
        }
    }
}
