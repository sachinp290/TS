using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Entities;

namespace TS.DataAccess
{
    public class DataHelper
    {
        public static List<TS.Entities.Subject> DataTableToStudents(System.Data.DataTable dt)
        {
            var result = new List<TS.Entities.Subject>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (System.Data.DataRow dr in dt.Rows)
                    result.Add(ToSubject(dr));
            }
            return result;
        }

        private static TS.Entities.Subject ToSubject(System.Data.DataRow row)
        {
            TS.Entities.Subject sub = new TS.Entities.Subject();
            sub.ID = Convert.ToInt32(row["ID"]);
            sub.Name = Convert.ToString(row["Name"]);
            return sub;
        }

        public static List<SqlParameter> GetParamsForSubject(Subject item)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", item.ID));
            pars.Add(new SqlParameter("name", item.Name));
            return pars;
        }


        public static List<Entities.Topic> DataTableToTopics(System.Data.DataTable dt)
        {
            var result = new List<TS.Entities.Topic>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (System.Data.DataRow dr in dt.Rows)
                    result.Add(ToTopic(dr));
            }
            return result;
        }

        private static TS.Entities.Topic ToTopic(System.Data.DataRow row)
        {
            TS.Entities.Topic sub = new TS.Entities.Topic();
            sub.ID = Convert.ToInt32(row["ID"]);
            sub.Name = Convert.ToString(row["Name"]);
            sub.SubjectID = Convert.ToInt32(row["SubjectID"]);
            sub.SubjectName = Convert.ToString(row["SubjectName"]);
            return sub;
        }

        internal static List<SqlParameter> GetParamsForTopic(Topic item)
        {
            List<SqlParameter> pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("id", item.ID));
            pars.Add(new SqlParameter("name", item.Name));
            pars.Add(new SqlParameter("subjectid", item.SubjectID));
            return pars;
        }
    }
}
