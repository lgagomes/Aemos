using Aemos.DomainClasses;
using System;
using System.Data.SqlClient;

namespace Aemos.Repository.Creators
{
    public class SchoolCreator
    {
        public static SpellSchool GetSchool(SqlDataReader reader)
        {
            return new SpellSchool
            {
                Id = (reader["Id"] == DBNull.Value) ? 0 : (int)reader["Id"],
                SchoolName = (reader["SchoolName"] == DBNull.Value) ? string.Empty : (string)reader["SchoolName"]
            };
        }
    }
}
