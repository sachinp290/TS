using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TS.Entities;

namespace TS.DataAccess
{
    public interface ITestSubjectRepository
    {
        List<TestSubject> Get(int testID);
        void Add(TestSubject item);
        void Delete(int id);
    }

    public class TestSubjectRepository : ITestSubjectRepository
    {
        public List<TestSubject> Get(int testid)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("testID", testid));
            var dt = EnterpriseDAO.Get("GetTestSubjects", System.Data.CommandType.StoredProcedure, pars);
            return DataHelper.DataTableToObjects<TestSubject>(dt, ToObject);
        }

        private TestSubject ToObject(System.Data.DataRow row)
        {
            TS.Entities.TestSubject sub = new TS.Entities.TestSubject();
            sub.ID = Convert.ToInt32(row["ID"]);
            sub.SubjectName = Convert.ToString(row["SubjectName"]);
            sub.SubjectID = Convert.ToInt32(row["SubjectID"]);
            sub.TestID = Convert.ToInt32(row["TestID"]);
            sub.Weightage = Convert.ToInt32(row["Weightage"]);
            return sub;
        }

        public void Add(TestSubject item)
        {
            EnterpriseDAO.Update("AddTestSubject", System.Data.CommandType.StoredProcedure, DataHelper.GetParamsForTestSubject(item));
        }


        public void Delete(int id)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", id));
            EnterpriseDAO.Delete("DeleteTestSubject", System.Data.CommandType.StoredProcedure, pars);
        }
    }
}
