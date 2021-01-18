using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PortNet.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        // Marks an entity as new
        Task<T> Add(T entity);

        // Marks an entity as modified
        Task<T> Update(T entity);

        // Marks an entity to be removed
        Task<T> Delete(T entity);

        Task<T> Delete(long id);

        //Delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);

        // Get an entity by int id
        Task<T> GetSingleById(long id);

        Task<IEnumerable<T>> GetAll(string[] includes = null);

        Task<T> GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        Task<IEnumerable<T>> GetMultiByCondition(Expression<Func<T, bool>> predicate, string[] includes = null);
    }
}