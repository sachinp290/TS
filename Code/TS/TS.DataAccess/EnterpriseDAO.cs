using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
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
            DatabaseProviderFactory factory = new DatabaseProviderFactory(new SystemConfigurationSource(false).GetSection);
            DatabaseFactory.SetDatabaseProviderFactory(factory, false);
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
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader() as SqlDataReader)
                    {
                        while (dr.Read())
                            result.Add(new Subject(dr));
                    }
                    con.Close();
                }
            }
            return result;
        }


    }
}