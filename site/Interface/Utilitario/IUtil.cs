using static site.Models.UtilModel;

namespace site.Interface
{
    public interface IUtil
    {
        Task<CepModel> getCEP(string cep);
        Task<List<ufModel>> getUf();
        Task<int> getNumbers();
    }
}
