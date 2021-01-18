using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PortNet.Data.Infrastructure
{
    public class DapperBase : IDapper
    {
        private IConfiguration _configuration { get; }

        public DapperBase(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Dispose()
        {
        }

        public int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure, string connectionString = null)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text, string connectionString = null)
        {
            using IDbConnection db = new SqlConnection(_configuration.GetConnectionString(connectionString));
            var data = await db.QueryAsync<T>(sp, parms, commandType: commandType);
            return data.FirstOrDefault();
        }

        public async Task<IEnumerable<T>> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure, string connectionString = null)
        {
            using IDbConnection db = new SqlConnection(_configuration.GetConnectionString(connectionString));
            return await db.QueryAsync<T>(sp, parms, commandType: commandType);
        }

        public async Task<T> Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure, string connectionString = null)
        {
            T result;
            using IDbConnection db = new SqlConnection(_configuration.GetConnectionString(connectionString));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    var data = await db.QueryAsync<T>(sp, parms, commandType: commandType, transaction: tran);
                    result = data.FirstOrDefault();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

            return result;
        }

        public async Task<T> Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure, string connectionString = null)
        {
            T result;
            using IDbConnection db = new SqlConnection(_configuration.GetConnectionString(connectionString));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    var data = await db.QueryAsync<T>(sp, parms, commandType: commandType, transaction: tran);
                    result = data.FirstOrDefault();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

            return result;
        }
    }
}