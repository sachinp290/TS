using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TS.Entities;

namespace TS.DataAccess
{
    public class TopicRepository : IRepository<Topic>
    {
        public Topic Get(int id)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", id));
            var dt = EnterpriseDAO.Get("GetTopics", System.Data.CommandType.StoredProcedure, pars);
            return DataHelper.DataTableToObjects<Topic>(dt, ToObject).FirstOrDefault();
        }

        public List<Topic> Get()
        {
            var dt = EnterpriseDAO.Get("GetTopics", System.Data.CommandType.StoredProcedure, null);
            return DataHelper.DataTableToObjects<Topic>(dt, ToObject);
        }

        public void Update(Topic item)
        {
            EnterpriseDAO.Update("UpdateTopic", System.Data.CommandType.StoredProcedure, DataHelper.GetParamsForTopic(item));
        }

        public void Delete(int id)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", id));
            EnterpriseDAO.Delete("DeleteTopic", System.Data.CommandType.StoredProcedure, pars);
        }

        private Topic ToObject(System.Data.DataRow row)
        {
            TS.Entities.Topic sub = new TS.Entities.Topic();
            sub.ID = Convert.ToInt32(row["ID"]);
            sub.Name = Convert.ToString(row["Name"]);
            sub.SubjectID = Convert.ToInt32(row["SubjectID"]);
            sub.SubjectName = Convert.ToString(row["SubjectName"]);
            return sub;
        }
    }
}
