using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TS.DataAccess
{
    public class EnterpriseDAL
    {
        private static readonly Database database;
        static EnterpriseDAL()
        {
            database = DatabaseFactory.CreateDatabase();
        }

        public List<T> GetDatasetfromStoreProcedure<T>(string query, CommandType type)
        {
            List<T> result = new List<T>();
            using (var con = database.CreateConnection())
            {
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandType = type;
                    cmd.CommandText = query;

                    using (SqlDataReader dr = cmd.ExecuteReader() as SqlDataReader)
                    {
                        while (dr.Read())
                        {
                            
                        }
                    }
                }
            }
            return result;
        }
    }
}