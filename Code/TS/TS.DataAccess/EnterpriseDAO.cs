using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
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

        public static DataTable Get(string query, CommandType commandtype, List<SqlParameter> pars)
        {
           return Execute(query, commandtype, pars);
        }

        public static void Update(string query, CommandType commandType, List<SqlParameter> pars)
        {
            Execute(query, commandType, pars);
        }

        private static DataTable Execute(string query, CommandType commandtype, List<SqlParameter> sqlParams)
        {
            DataTable result = new DataTable();
            using (var con = database.CreateConnection())
            {
                using (var cmd = con.CreateCommand())
                {
                    if (sqlParams != null)
                    {
                        foreach (IDataParameter para in sqlParams)
                        {
                            cmd.Parameters.Add(para);
                        }
                    }
                    cmd.CommandText = query;
                    cmd.CommandType = commandtype;
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader() as SqlDataReader)
                    {
                        result.Load(dr);
                    }
                    con.Close();
                }
            }
            return result;
        }

        private static void ExecuteNonQuery(string query, CommandType commandtype, List<SqlParameter> sqlParams)
        {
            using (var con = database.CreateConnection())
            {
                using (var cmd = con.CreateCommand())
                {
                    if (sqlParams != null)
                    {
                        foreach (IDataParameter para in sqlParams)
                        {
                            cmd.Parameters.Add(para);
                        }
                    }
                    cmd.CommandText = query;
                    cmd.CommandType = commandtype;
                    con.Open(); 
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        internal static void Delete(string query, CommandType commandType, List<SqlParameter> pars)
        {
            ExecuteNonQuery(query, commandType, pars);
        }
    }
}