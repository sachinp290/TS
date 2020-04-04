using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TS.Entities;

namespace TS.DataAccess
{
    public class TestConfigurationRepository : IRepository<TestConfiguration>
    {
        public TestConfiguration Get(int id)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", id));
            var dt = EnterpriseDAO.Get("GetTestConfigurations", System.Data.CommandType.StoredProcedure, pars);
            return DataHelper.DataTableToObjects<TestConfiguration>(dt, ToObject).FirstOrDefault();
        }

        public List<TestConfiguration> Get()
        {
            var dt = EnterpriseDAO.Get("GetTestConfigurations", System.Data.CommandType.StoredProcedure, null);
            return DataHelper.DataTableToObjects<TestConfiguration>(dt, ToObject);
        }

        public void Delete(int id)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", id));
            EnterpriseDAO.Delete("DeleteTestConfiguration", System.Data.CommandType.StoredProcedure, pars);
        }

        public void Update(TestConfiguration item)
        {
            EnterpriseDAO.Update("UpdateTestConfiguration", System.Data.CommandType.StoredProcedure, DataHelper.GetParamsForTestConfiguration(item));
        }
        private TestConfiguration ToObject(System.Data.DataRow row)
        {
            TS.Entities.TestConfiguration item = new TS.Entities.TestConfiguration();
            item.ID = Convert.ToInt32(row["ID"]);
            item.ComplexityID = Convert.ToInt32(row["ComplexityID"]);
            item.ComplexityName = Convert.ToString(row["ComplexityName"]);
            item.TestTypeID = Convert.ToInt32(row["TestTypeID"]);
            item.TestTypeName = Convert.ToString(row["TestTypeName"]);
            item.TotalTime = Convert.ToInt32(row["TotalTime"]);
            item.TotalMarks = Convert.ToInt32(row["TotalMarks"]);
            item.NoOfTotalQuestions = Convert.ToInt32(row["NoOfTotalQuestions"]);
            item.NoOfQuestions = Convert.ToInt32(row["NoOfQuestions"]);
            item.Name = Convert.ToString(row["Name"]);
            item.CorrectAnswersToPass = Convert.ToInt32(row["CorrectAnswersToPass"]);
            return item;
        }
    }
}
