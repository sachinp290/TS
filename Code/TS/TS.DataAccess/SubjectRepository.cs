using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TS.Entities;

namespace TS.DataAccess
{
    public class SubjectRepository : IRepository<Subject>, ISubjectRepository
    {
        public Subject Get(int id)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", id));
            var dt = EnterpriseDAO.Get("GetSubjects", System.Data.CommandType.StoredProcedure, pars);
            return DataHelper.DataTableToObjects<Subject>(dt, ToObject).FirstOrDefault();
        }

        public List<Subject> Get()
        {
            var dt = EnterpriseDAO.Get("GetSubjects", System.Data.CommandType.StoredProcedure, null);
            return DataHelper.DataTableToObjects<Subject>(dt, ToObject);
        }

        public void Update(Subject item)
        {
            EnterpriseDAO.Update("UpdateSubject", System.Data.CommandType.StoredProcedure, DataHelper.GetParamsForSubject(item));
        }

        public void Delete(int id)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", id));
            EnterpriseDAO.Delete("DeleteSubject", System.Data.CommandType.StoredProcedure, pars);
        }
        
        private Subject ToObject(System.Data.DataRow row)
        {
            TS.Entities.Subject sub = new TS.Entities.Subject();
            sub.ID = Convert.ToInt32(row["ID"]);
            sub.Name = Convert.ToString(row["Name"]);
            return sub;
        }
    }
}