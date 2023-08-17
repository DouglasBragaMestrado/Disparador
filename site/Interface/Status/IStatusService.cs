using site.Models;

namespace site.Interface
{
    public interface IStatusService
    {
        Task<IEnumerable<StatusModel>> Get();
        Task<StatusModel> Get(int Id);
        Task Create(StatusModel status);
        Task Update(StatusModel status);
        Task Delete(StatusModel status);
    }
}
