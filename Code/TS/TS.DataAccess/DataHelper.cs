using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TS.Entities;

namespace TS.DataAccess
{
    public class DataHelper
    {
        public static List<T> DataTableToObjects<T>(System.Data.DataTable dt, Func<System.Data.DataRow, T> ToObject)
        {
            var result = new List<T>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (System.Data.DataRow dr in dt.Rows)
                    result.Add(ToObject(dr));
            }
            return result;
        }

        public static List<SqlParameter> GetParamsForSubject(Subject item)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", item.ID));
            pars.Add(new SqlParameter("name", item.Name));
            return pars;
        }

        public static List<SqlParameter> GetParamsForTopic(Topic item)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", item.ID));
            pars.Add(new SqlParameter("name", item.Name));
            pars.Add(new SqlParameter("subjectid", item.SubjectID));
            return pars;
        }

        internal static List<SqlParameter> GetParamsForQuestion(Question item)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", item.ID));
            pars.Add(new SqlParameter("topicid", item.TopicID));
            pars.Add(new SqlParameter("text", item.Text));
            pars.Add(new SqlParameter("option1", item.Option1));
            pars.Add(new SqlParameter("option2", item.Option2));
            pars.Add(new SqlParameter("option3", item.Option3));
            pars.Add(new SqlParameter("option4", item.Option4));
            pars.Add(new SqlParameter("complexityid", item.ComplexityID));
            pars.Add(new SqlParameter("correctanswer", item.CorrectAnswer));
            pars.Add(new SqlParameter("isready", item.IsReady));
            pars.Add(new SqlParameter("language", item.Language));
            pars.Add(new SqlParameter("reason", item.Reason));
            return pars;
        }

        internal static List<SqlParameter> GetParamsForTestConfiguration(TestConfiguration item)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", item.ID));
            pars.Add(new SqlParameter("complexityid", item.ComplexityID));
            pars.Add(new SqlParameter("correctanswerstopass", item.CorrectAnswersToPass));
            pars.Add(new SqlParameter("nooftotalquestions", item.NoOfTotalQuestions));
            pars.Add(new SqlParameter("noofquestions", item.NoOfQuestions));
            pars.Add(new SqlParameter("totalmarks", item.TotalMarks));
            pars.Add(new SqlParameter("totaltime", item.TotalTime));
            return pars;
        }
    }
}
