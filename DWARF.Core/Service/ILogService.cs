using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DWARF.Core.Domain;

namespace DWARF.Core.Service
{
    public interface ILogService<T> where T : ILog
    {
        T GetSingleLog(Guid logId);
        IEnumerable<T> GetManyLogs(IEnumerable<Guid> logIds);
        Task<T> GetSingleLogAsync(Guid logId);
        Task<IEnumerable<T>> GetManyLogsAsync(IEnumerable<Guid> logIds);
        IEnumerable<T> GetManyLogs(Expression<Func<T, bool>> filter = null,
                               Expression<Func<IQueryable<T>, IOrderedQueryable<T>>> order = null,
                               Expression<Func<T, object>> path = null,
                               int skip = 0,
                               int take = 0);
        Task<IEnumerable<T>> GetManyLogsAsync(Expression<Func<T, bool>> filter = null,
                                          Expression<Func<IQueryable<T>, IOrderedQueryable<T>>> order = null,
                                          Expression<Func<T, object>> path = null,
                                          int skip = 0,
                                          int take = 0);
        T InsertLog(T log, bool persist = false);
        IEnumerable<T> InsertManyLogs(IEnumerable<T> logs, bool persist = false);
        Task<T> InsertLogAsync(T log, bool persist = false);
        Task<IEnumerable<T>> InsertManyLogsAsync(IEnumerable<T> logs, bool persist = false);
        bool UpdateLog(T log, bool persist = false);
        int UpdateManyLogs(IEnumerable<T> logs, bool persist = false);
        Task<bool> UpdateLogAsync(T log, bool persist = false);
        Task<int> UpdateManyLogsAsync(IEnumerable<T> logs, bool persist = false);
        T ReplaceLog(Guid logId, T log, bool persist = false, bool reset = true);
        Task<T> ReplaceLogAsync(Guid logId, T log, bool persist = false, bool reset = true);
        bool DeleteLog(T log, bool persist = false);
        int DeleteManyLogs(IEnumerable<T> logs, bool persist = false);
        Task<bool> DeleteLogAsync(T log, bool persist = false);
        Task<int> DeleteManyLogsAsync(IEnumerable<T> logs, bool persist = false);
        bool DeleteLog(Guid logId, bool persist = false);
        int DeleteManyLogs(IEnumerable<Guid> logIds, bool persist = false);
        Task<bool> DeleteLogAsync(Guid logId, bool persist = false);
        Task<int> DeleteManyLogsAsync(IEnumerable<Guid> logIds, bool persist = false);
        IEnumerable<T> ReplaceManyLogs(IEnumerable<Guid> logIds, IEnumerable<T> logs, bool persist = false, bool reset = true);
        Task<IEnumerable<T>> ReplaceManyLogsAsync(IEnumerable<Guid> logIds, IEnumerable<T> logs, bool persist = false, bool reset = true);
    }
}
