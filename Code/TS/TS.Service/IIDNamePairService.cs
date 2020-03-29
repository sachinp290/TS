using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Entities;

namespace TS.Service
{
   public interface IIDNamePairService
    {
       List<IDNamePair> Get(string tableName);
    }
}
