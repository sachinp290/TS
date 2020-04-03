using System;
using System.Collections.Generic;
using TS.Entities;

namespace TS.DataAccess
{
    public class IDNamePairRepository : IIDNamePairRepository
    {
        public List<Entities.IDNamePair> Get(string tableName)
        {
            var dt = EnterpriseDAO.Get("select * from " + tableName, System.Data.CommandType.Text, null);
            return DataHelper.DataTableToObjects<IDNamePair>(dt, ToObject);
        }

        private IDNamePair ToObject(System.Data.DataRow row)
        {
            TS.Entities.IDNamePair item = new TS.Entities.IDNamePair();
            item.ID = Convert.ToInt32(row["ID"]);
            item.Name = Convert.ToString(row["Name"]);
            return item;
        }
    }
}
