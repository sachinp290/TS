using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Entities;

namespace TS.DataAccess
{
    public interface IIDNamePairRepository
    {
        List<IDNamePair> Get(string tableName);
    }
}
