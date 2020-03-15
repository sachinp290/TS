using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TS.Entities;

namespace TS.DataAccess
{
    public class EnterpriseDAO
    {
        private static readonly Database database;
        static EnterpriseDAO()
        {
            database = DatabaseFactory.CreateDatabase();
        }

        public static List<Subject> GetFromStoreProcedure(string storeProcedureName)
        {
            List<Subject> result = new List<Subject>();
            using (var con = database.CreateConnection())
            {
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = storeProcedureName;

                    using (SqlDataReader dr = cmd.ExecuteReader() as SqlDataReader)
                    {
                        result.Add(new Subject(dr));

                    }
                }
            }
            return result;
        }


    }
}