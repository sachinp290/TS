﻿using System;
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
            var dt = EnterpriseDAO.Get("GetSubjects", System.Data.CommandType.StoredProcedure);
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