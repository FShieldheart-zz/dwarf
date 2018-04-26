using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DWARF.Core.Domain;

namespace DWARF.Core.Repository
{
    public interface IGenericRepository<T> where T : IBaseComponent
    {
        T GetSingle(object id);
        IEnumerable<T> GetMany(IEnumerable<string> ids);
        Task<T> GetSingleAsync(object id);
        Task<IEnumerable<T>> GetManyAsync(IEnumerable<string> ids);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> filter = null,
                               Expression<Func<IQueryable<T>, IOrderedQueryable<T>>> order = null,
                               Expression<Func<T, object>> path = null,
                               int skip = 0,
                               int take = 0);
        Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> filter = null,
                                          Expression<Func<IQueryable<T>, IOrderedQueryable<T>>> order = null,
                                          Expression<Func<T, object>> path = null,
                                          int skip = 0,
                                          int take = 0);
        T Insert(T baseModel, bool persist = false);
        IEnumerable<T> InsertMany(IEnumerable<T> baseModels, bool persist = false);
        Task<T> InsertAsync(T baseModel, bool persist = false);
        Task<IEnumerable<T>> InsertManyAsync(IEnumerable<T> baseModels, bool persist = false);
        bool Update(T baseModel, bool persist = false);
        int UpdateMany(IEnumerable<T> baseModels, bool persist = false);
        Task<bool> UpdateAsync(T baseModel, bool persist = false);
        Task<int> UpdateManyAsync(IEnumerable<T> baseModels, bool persist = false);
        T Replace(object id, T baseModel, bool persist = false, bool reset = true);
        Task<T> ReplaceAsync(object id, T baseModel, bool persist = false, bool reset = true);
        bool Delete(T baseModel, bool persist = false);
        int DeleteMany(IEnumerable<T> baseModels, bool persist = false);
        Task<bool> DeleteAsync(T baseModel, bool persist = false);
        Task<int> DeleteManyAsync(IEnumerable<T> baseModels, bool persist = false);
        bool Delete(object id, bool persist = false);
        int DeleteMany(IEnumerable<object> ids, bool persist = false);
        Task<bool> DeleteAsync(object id, bool persist = false);
        Task<int> DeleteManyAsync(IEnumerable<object> ids, bool persist = false);
        IEnumerable<T> ReplaceMany(IEnumerable<object> ids, IEnumerable<T> baseModels, bool persist = false, bool reset = true);
        Task<IEnumerable<T>> ReplaceManyAsync(IEnumerable<object> ids, IEnumerable<T> baseModels, bool persist = false, bool reset = true);
    }
}
