using Microsoft.EntityFrameworkCore;
using site.Interface;
using site.Models;

namespace site.Service
{
    public class LogService : ILogService
    {
        private readonly siteDBContext? _context;
        public async Task Create(LogModel log)
        {
            _context.TB_LOG.Add(log);
            await _context.SaveChangesAsync();
        }

        public Task Delete(LogModel log)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LogModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<LogModel> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Update(LogModel log)
        {
            throw new NotImplementedException();
        }
    }
}
