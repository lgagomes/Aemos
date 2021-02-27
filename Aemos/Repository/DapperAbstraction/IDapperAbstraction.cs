using System.Collections.Generic;

namespace Aemos.Repository.DapperAbstraction
{
    public interface IDapperAbstraction
    {
        IEnumerable<T> Query<T>(string query, object parameters);
        IEnumerable<T> Query<T>(string query);
    }
}