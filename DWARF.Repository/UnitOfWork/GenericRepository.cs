using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DWARF.Core.Repository;
using DWARF.Domain.Model;
using DWARF.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace DWARF.Repository.UnitOfWork
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Base, new()
    {
        private DbContext _dbContext;
        public GenericRepository(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Delete(T baseModel, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object id, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(T baseModel, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(object id, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public int DeleteMany(IEnumerable<T> baseModels, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public int DeleteMany(IEnumerable<object> ids, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteManyAsync(IEnumerable<T> baseModels, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteManyAsync(IEnumerable<object> ids, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetMany(IEnumerable<string> ids)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> filter = null, Expression<Func<IQueryable<T>, IOrderedQueryable<T>>> order = null, Expression<Func<T, object>> path = null, int skip = 0, int take = 0)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetManyAsync(IEnumerable<string> ids)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> filter = null, Expression<Func<IQueryable<T>, IOrderedQueryable<T>>> order = null, Expression<Func<T, object>> path = null, int skip = 0, int take = 0)
        {
            throw new NotImplementedException();
        }

        public T GetSingle(object id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(object id)
        {
            throw new NotImplementedException();
        }

        public T Insert(T baseModel, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<T> InsertAsync(T baseModel, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> InsertMany(IEnumerable<T> baseModels, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> InsertManyAsync(IEnumerable<T> baseModels, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public T Replace(object id, T baseModel, bool persist = false, bool reset = true)
        {
            throw new NotImplementedException();
        }

        public Task<T> ReplaceAsync(object id, T baseModel, bool persist = false, bool reset = true)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ReplaceMany(IEnumerable<object> ids, IEnumerable<T> baseModels, bool persist = false, bool reset = true)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> ReplaceManyAsync(IEnumerable<object> ids, IEnumerable<T> baseModels, bool persist = false, bool reset = true)
        {
            throw new NotImplementedException();
        }

        public bool Update(T baseModel, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T baseModel, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public int UpdateMany(IEnumerable<T> baseModels, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateManyAsync(IEnumerable<T> baseModels, bool persist = false)
        {
            throw new NotImplementedException();
        }
    }
}
