using Aemos.DomainClasses;
using System;
using System.Data.SqlClient;

namespace Aemos.Repository.Creators
{
    public class SpellDomainCreator
    {
        public static SpellDomain GetDomain(SqlDataReader reader)
        {
            return new SpellDomain
            {
                IdDomain = (reader["Id"] == DBNull.Value) ? 0 : (int)reader["Id"],
                DomainName = (reader["DomainName"] == DBNull.Value) ? string.Empty : (string)reader["DomainName"]
            };
        }
    }
}
