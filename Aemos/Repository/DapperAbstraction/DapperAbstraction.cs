using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Aemos.Repository.DapperAbstraction
{
    public class DapperAbstraction : IDapperAbstraction
    {
        public string ConnectionString { get; set; }

        public DapperAbstraction(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public IEnumerable<T> Query<T>(string query, object parameters)
        {
            IEnumerable<T> objects;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    objects = connection.Query<T>(query, parameters);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, new Exception(ex.InnerException.Message));
            }

            return objects;
        }

        public IEnumerable<T> Query<T>(string query)
        {
            IEnumerable<T> objects;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    objects = connection.Query<T>(query);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, new Exception(ex.InnerException.Message));
            }

            return objects;
        }
    }
}
