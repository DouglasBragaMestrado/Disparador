using site.Models;

namespace site.Interface
{
    public interface ILoginAcessoService
    {
        Task<IEnumerable<LoginAcessoModel>> Get();
        Task<LoginAcessoModel> Get(int Id);
        Task<int> Create(LoginAcessoModel loginAcesso);
        Task Update(LoginAcessoModel loginAcesso);
        Task Delete(LoginAcessoModel loginAcesso);
    }
}
