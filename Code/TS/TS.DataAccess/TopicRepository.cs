﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Entities;

namespace TS.DataAccess
{
   public class TopicRepository:ITopicRepository, IRepository<Topic>
    {
        public Topic Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Topic> Get()
        {
            var dt = EnterpriseDAO.Get("GetTopics", System.Data.CommandType.StoredProcedure);
            return DataHelper.DataTableToTopics(dt);
        }

        public int Add(Topic item)
        {
            throw new NotImplementedException();
        }

        public void Edit(Topic item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
