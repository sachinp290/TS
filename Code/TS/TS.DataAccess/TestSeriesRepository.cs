using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TS.Entities;

namespace TS.DataAccess
{
    public class TestSeriesRepository : IRepository<TestSeries>
    {
        public TestSeries Get(int id)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", id));
            var dt = EnterpriseDAO.Get("GetTestSerieses", System.Data.CommandType.StoredProcedure, pars);
            return DataHelper.DataTableToObjects<TestSeries>(dt, ToObject).FirstOrDefault();
        }

        public List<TestSeries> Get()
        {
            var dt = EnterpriseDAO.Get("GetTestSerieses", System.Data.CommandType.StoredProcedure, null);
            return DataHelper.DataTableToObjects<TestSeries>(dt, ToObject);
        }

        public void Delete(int id)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", id));
            EnterpriseDAO.Delete("DeleteTestSeries", System.Data.CommandType.StoredProcedure, pars);
        }

        public void Update(TestSeries item)
        {
            EnterpriseDAO.Update("UpdateTestSeries", System.Data.CommandType.StoredProcedure, DataHelper.GetParamsForTestSeries(item));
        }

        private TestSeries ToObject(System.Data.DataRow row)
        {
            TS.Entities.TestSeries item = new TS.Entities.TestSeries();
            item.ID = Convert.ToInt32(row["ID"]);
            item.Name = Convert.ToString(row["Name"]);
            item.TestConfigurationID = Convert.ToInt32(row["TestConfigurationID"]);
            item.TestConfigurationName = Convert.ToString(row["TestConfigurationName"]);
            DateTime generatedDate = DateTime.MinValue;
            if (DateTime.TryParse(Convert.ToString(row["GeneratedDate"]), out generatedDate))
                item.GeneratedDate = generatedDate;
            DateTime startDate = DateTime.MinValue;
            if (DateTime.TryParse(Convert.ToString(row["StartDate"]), out startDate))
                item.StartDate = startDate;
            item.IsReady = Convert.ToBoolean(row["IsReady"]);
            return item;
        }
    }
}
