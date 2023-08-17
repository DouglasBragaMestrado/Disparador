using site.Models;

namespace site.Interface
{
    public interface INivelService
    {
        Task<IEnumerable<NivelModel>> Get();
        Task<NivelModel> Get(int Id);
        Task Create(NivelModel nivel);
        Task Update(NivelModel nivel);
        Task Delete(NivelModel nivel);
    }
}
