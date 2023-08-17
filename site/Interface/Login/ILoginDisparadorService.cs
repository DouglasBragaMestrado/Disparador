using site.Models;

namespace site.Interface
{
    public interface ILoginDisparadorService
    {
        Task<IEnumerable<LoginDisparadorModel>> Get();
        Task<LoginDisparadorModel> Get(int Id);
        Task Create(LoginDisparadorModel disparador);
        Task Update(LoginDisparadorModel disparador);
        Task Delete(LoginDisparadorModel disparador);
    }
}
