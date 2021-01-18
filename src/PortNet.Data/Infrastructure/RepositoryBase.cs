using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PortNet.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PortNet.Data.Infrastructure
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected readonly string _connInfPort = "INFPortConnection";
        protected readonly string _connInfPortObject = "INFPortObjectConnection";
        protected readonly ApplicationDbContext _dbContext;

        public RepositoryBase(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _dbContext.Set<T>().Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(long id)
        {
            var entity = await _dbContext.Set<T>().FindAsync(id);
            if (entity == null)
                return entity;
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public void DeleteMulti(Expression<Func<T, bool>> where)
        {
            foreach (T obj in _dbContext.Set<T>().Where<T>(where).AsEnumerable())
                _dbContext.Set<T>().Remove(obj);
        }

        public async Task<T> GetSingleById(long id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetMany(Expression<Func<T, bool>> where, string includes)
        {
            return await _dbContext.Set<T>().Where(where).ToListAsync();
        }

        public int Count(Expression<Func<T, bool>> where)
        {
            return _dbContext.Set<T>().Count(where);
        }

        public async Task<IEnumerable<T>> GetAll(string[] includes = null)
        {
            if (includes?.Count() > 0)
            {
                var query = _dbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return await query.AsQueryable().ToListAsync();
            }
            return await _dbContext.Set<T>().AsQueryable().ToListAsync();
        }

        public async Task<T> GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            if (includes?.Count() > 0)
            {
                var query = _dbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return await query.FirstOrDefaultAsync(expression);
            }
            return await _dbContext.Set<T>().FirstOrDefaultAsync(expression);
        }

        public async Task<IEnumerable<T>> GetMultiByCondition(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes?.Count() > 0)
            {
                var query = _dbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return await query.Where<T>(predicate).AsQueryable<T>().ToListAsync();
            }

            return await _dbContext.Set<T>().Where<T>(predicate).AsQueryable<T>().ToListAsync();
        }
    }
}