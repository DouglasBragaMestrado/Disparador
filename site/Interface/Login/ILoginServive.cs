using site.Models;

namespace site.Interface
{
    public interface ILoginServive
    {
        Task<IEnumerable<LoginModel>> Get();
        Task<LoginModel> Get(int Id);
        Task Create(LoginModel login);
        Task Update(LoginModel login);
        Task Delete(LoginModel login);
    }
}
