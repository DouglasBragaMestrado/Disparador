using site.Models.Contato;

namespace site.Interface
{
    public interface IContatoService
    {
        Task<IEnumerable<contatoModel>> Get();
        Task<contatoModel> Get(int Id);
        Task Create(contatoModel contato);
        Task Update(contatoModel contato);
        Task Delete(int id);
    }
}
