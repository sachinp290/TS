using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", id));
            var dt = EnterpriseDAO.Get("GetTopics", System.Data.CommandType.StoredProcedure, pars);
            return DataHelper.DataTableToTopics(dt).FirstOrDefault();
        }

        public List<Topic> Get()
        {
            var dt = EnterpriseDAO.Get("GetTopics", System.Data.CommandType.StoredProcedure, null);
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


        public void Update(Topic item)
        {
            EnterpriseDAO.Update("UpdateTopic", System.Data.CommandType.StoredProcedure, DataHelper.GetParamsForTopic(item));
        }
    }
}
