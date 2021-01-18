using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace PortNet.Data.Infrastructure
{
    public interface IDapper : IDisposable
    {
        Task<T> Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure, string conn = null);

        Task<IEnumerable<T>> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure, string conn = null);

        int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure, string conn = null);

        Task<T> Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure, string conn = null);

        Task<T> Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure, string conn = null);
    }
}