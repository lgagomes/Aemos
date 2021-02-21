using Aemos.CharacterClasses;
using System;
using System.Data.SqlClient;

namespace Aemos.Repository.Creators
{
    public static class ClassCreator
    {
        public static BaseClass GetSpellcaster(SqlDataReader reader)
        {
            return new BaseClass
            {
                Id = (reader["Id"] == DBNull.Value) ? 0 : (int)reader["Id"],
                ClassName = (reader["ClassName"] == DBNull.Value) ? string.Empty : (string)reader["ClassName"]
            };
        }
    }
}
