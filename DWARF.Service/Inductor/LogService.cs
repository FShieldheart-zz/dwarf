using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DWARF.Core.Service;
using DWARF.Domain.Model;

namespace DWARF.Service.Inductor
{
    public class LogService : ILogService<Log>
    {
        public bool DeleteLog(Log log, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public bool DeleteLog(Guid logId, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteLogAsync(Log log, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteLogAsync(Guid logId, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public int DeleteManyLogs(IEnumerable<Log> logs, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public int DeleteManyLogs(IEnumerable<Guid> logIds, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteManyLogsAsync(IEnumerable<Log> logs, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteManyLogsAsync(IEnumerable<Guid> logIds, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Log> GetManyLogs(IEnumerable<Guid> logIds)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Log> GetManyLogs(System.Linq.Expressions.Expression<Func<Log, bool>> filter = null, System.Linq.Expressions.Expression<Func<System.Linq.IQueryable<Log>, System.Linq.IOrderedQueryable<Log>>> order = null, System.Linq.Expressions.Expression<Func<Log, object>> path = null, int skip = 0, int take = 0)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Log>> GetManyLogsAsync(IEnumerable<Guid> logIds)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Log>> GetManyLogsAsync(System.Linq.Expressions.Expression<Func<Log, bool>> filter = null, System.Linq.Expressions.Expression<Func<System.Linq.IQueryable<Log>, System.Linq.IOrderedQueryable<Log>>> order = null, System.Linq.Expressions.Expression<Func<Log, object>> path = null, int skip = 0, int take = 0)
        {
            throw new NotImplementedException();
        }

        public Log GetSingleLog(Guid logId)
        {
            throw new NotImplementedException();
        }

        public Task<Log> GetSingleLogAsync(Guid logId)
        {
            throw new NotImplementedException();
        }

        public Log InsertLog(Log log, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<Log> InsertLogAsync(Log log, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Log> InsertManyLogs(IEnumerable<Log> logs, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Log>> InsertManyLogsAsync(IEnumerable<Log> logs, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Log ReplaceLog(Guid logId, Log log, bool persist = false, bool reset = true)
        {
            throw new NotImplementedException();
        }

        public Task<Log> ReplaceLogAsync(Guid logId, Log log, bool persist = false, bool reset = true)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Log> ReplaceManyLogs(IEnumerable<Guid> logIds, IEnumerable<Log> logs, bool persist = false, bool reset = true)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Log>> ReplaceManyLogsAsync(IEnumerable<Guid> logIds, IEnumerable<Log> logs, bool persist = false, bool reset = true)
        {
            throw new NotImplementedException();
        }

        public bool UpdateLog(Log log, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateLogAsync(Log log, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public int UpdateManyLogs(IEnumerable<Log> logs, bool persist = false)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateManyLogsAsync(IEnumerable<Log> logs, bool persist = false)
        {
            throw new NotImplementedException();
        }
    }
}
