using site.Models;

namespace site.Interface
{
    public interface IConsultorService
    {
        Task<IEnumerable<ConsultorModel>> Get();
        Task<ConsultorModel> Get(int Id);
        Task<ConsultorModel?> Get(string email);
        Task<int> Create(ConsultorModel consultor);
        Task Update(ConsultorModel consultor);
        Task Delete(int id);
    }
}
