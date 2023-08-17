
using site.Interface;
using site.Models.Parametro;
using System.Text.Json;

namespace site.Service
{
    public class CountryService : ICountryService
    {
        private readonly IConfiguration configuration;
        public CountryService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public List<PaisesModel> Get()
        {

            string _json = configuration.GetSection("ConnectionJson").Value.ToString();

            string json = File.ReadAllText(@_json);
            var list = JsonSerializer.Deserialize<List<PaisesModel>>(json);

            return list.OrderBy(o => o.name).ToList();
        }
    }
}
