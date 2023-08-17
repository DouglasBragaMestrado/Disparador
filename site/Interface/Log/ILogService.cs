using site.Models;

namespace site.Interface
{
    public interface ILogService
    {
        Task<IEnumerable<LogModel>> Get();
        Task<LogModel> Get(int Id);
        Task Create(LogModel log);
        Task Update(LogModel log);
        Task Delete(LogModel log);
    }
}
