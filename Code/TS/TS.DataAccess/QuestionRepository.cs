using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TS.Entities;

namespace TS.DataAccess
{
    public class QuestionRepository : IRepository<Question>
    {
        public Question Get(int id)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", id));
            var dt = EnterpriseDAO.Get("GetQuestions", System.Data.CommandType.StoredProcedure, pars);
            return DataHelper.DataTableToObjects<Question>(dt, ToObject).FirstOrDefault();
        }

        public List<Question> Get()
        {
            var dt = EnterpriseDAO.Get("GetQuestions", System.Data.CommandType.StoredProcedure, null);
            return DataHelper.DataTableToObjects<Question>(dt, ToObject);
        }

        public void Update(Question item)
        {
            EnterpriseDAO.Update("UpdateQuestion", System.Data.CommandType.StoredProcedure, DataHelper.GetParamsForQuestion(item));
        }

        public void Delete(int id)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", id));
            EnterpriseDAO.Delete("DeleteQuestion", System.Data.CommandType.StoredProcedure, pars);
        }
        
        private Question ToObject(System.Data.DataRow row)
        {
            TS.Entities.Question item = new TS.Entities.Question();
            item.ID = Convert.ToInt32(row["ID"]);
            item.ComplexityID = Convert.ToInt32(row["ComplexityID"]);
            item.CorrectAnswer = Convert.ToString(row["CorrectAnswer"]);
            item.IsReady = Convert.ToBoolean(row["IsReady"]);
            item.Language = Convert.ToString(row["Language"]);
            item.Option1 = Convert.ToString(row["Option1"]);
            item.Option2 = Convert.ToString(row["Option2"]);
            item.Option3 = Convert.ToString(row["Option3"]);
            item.Option4 = Convert.ToString(row["Option4"]);
            item.Reason = Convert.ToString(row["Reason"]);
            item.Text = Convert.ToString(row["Text"]);
            item.TopicID = Convert.ToInt32(row["TopicID"]);
            item.TopicName= Convert.ToString(row["TopicName"]);
            item.ComplexityName = Convert.ToString(row["ComplexityName"]);
            return item;
        }
    }
}
