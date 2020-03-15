using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return DataHelper.DataTableToStudents(dt).FirstOrDefault();
        }

        public List<Subject> Get()
        {
            var dt = EnterpriseDAO.Get("GetSubjects", System.Data.CommandType.StoredProcedure, null);
            return DataHelper.DataTableToStudents(dt);
        }

        public int Add(Subject item)
        {
            throw new NotImplementedException();
        }

        public void Edit(Subject item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}