using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TS.DataAccess
{
    public class EnterpriseDAO
    {
        private static readonly Database database;
        static EnterpriseDAO()
        {
            database = DatabaseFactory.CreateDatabase();
        }

        public DataTable GetDataTablefromStoreProcedure<T>(string query, CommandType type)
        {
            DataTable result = new DataTable();
            using (var con = database.CreateConnection())
            {
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandType = type;
                    cmd.CommandText = query;

                    using (SqlDataReader dr = cmd.ExecuteReader() as SqlDataReader)
                    {
                        result.Load(dr);
                    }
                }
            }
            return result;
        }
    }
}