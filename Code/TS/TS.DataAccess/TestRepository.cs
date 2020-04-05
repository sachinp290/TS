using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TS.Entities;

namespace TS.DataAccess
{
    public class TestRepository : IRepository<Test>
    {
        public Test Get(int id)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", id));
            var dt = EnterpriseDAO.Get("GetTests", System.Data.CommandType.StoredProcedure, pars);
            return DataHelper.DataTableToObjects<Test>(dt, ToObject).FirstOrDefault();
        }

        public List<Test> Get()
        {
            var dt = EnterpriseDAO.Get("GetTests", System.Data.CommandType.StoredProcedure, null);
            return DataHelper.DataTableToObjects<Test>(dt, ToObject);
        }

        public void Delete(int id)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", id));
            EnterpriseDAO.Delete("DeleteTest", System.Data.CommandType.StoredProcedure, pars);
        }

        public void Update(Test item)
        {
            EnterpriseDAO.Update("UpdateTest", System.Data.CommandType.StoredProcedure, DataHelper.GetParamsForTest(item));
        }

        private Test ToObject(System.Data.DataRow row)
        {
            TS.Entities.Test item = new TS.Entities.Test();
            item.ID = Convert.ToInt32(row["ID"]);
            item.TestConfigurationID = Convert.ToInt32(row["TestConfigurationID"]);
            item.TestConfigurationName = Convert.ToString(row["TestConfigurationName"]);
            DateTime generatedDate = DateTime.MinValue;
            if (DateTime.TryParse(Convert.ToString(row["GeneratedDate"]), out generatedDate))
                item.GeneratedDate = generatedDate;
            DateTime startDate = DateTime.MinValue;
            if (DateTime.TryParse(Convert.ToString(row["StartDate"]), out startDate))
                item.StartDate = startDate;
            DateTime endDate = DateTime.MinValue;
            if (DateTime.TryParse(Convert.ToString(row["EndDate"]), out endDate))
                item.EndDate = endDate;
            item.IsReady = Convert.ToBoolean(row["IsReady"]);
            return item;
        }
    }
}
