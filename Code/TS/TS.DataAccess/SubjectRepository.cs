using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public List<Subject> Get()
        {
            return EnterpriseDAO.GetFromStoreProcedure("GetSubjects");
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