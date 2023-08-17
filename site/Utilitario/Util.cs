using Newtonsoft.Json;
using site.Interface;
using System.Data;
using static site.Models.UtilModel;

namespace site.Utilitario
{
    public class Util: IUtil
    {
        public async Task<CepModel> getCEP(string cep)
        {
            cep = cep.Replace("-", "").ToString().Trim();

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://viacep.com.br/ws/"+cep+"/json/");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var resultado = await response.Content.ReadAsStringAsync();

            CepModel cepResultado =  JsonConvert.DeserializeObject<CepModel>(resultado);

            return cepResultado;

        }
        public async Task<int> getNumbers()
        {
            int count = 1;

            Random random = new Random();
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(10000, 99999);
            }
            return Convert.ToInt32(numbers[0]);
        }
        public async Task<List<ufModel>> getUf()
        {
            List<ufModel> uf = new List<ufModel>();
            DataTable table = new DataTable();
            table.Columns.Add("UF", typeof(string));

            table.Rows.Add("AC");
            table.Rows.Add("AL");
            table.Rows.Add("AP");
            table.Rows.Add("AM");
            table.Rows.Add("BA");
            table.Rows.Add("CE");
            table.Rows.Add("DF");
            table.Rows.Add("ES");
            table.Rows.Add("GO");
            table.Rows.Add("MA");
            table.Rows.Add("MT");
            table.Rows.Add("MS");
            table.Rows.Add("MG");
            table.Rows.Add("PA");
            table.Rows.Add("PB");
            table.Rows.Add("PR");
            table.Rows.Add("PE");
            table.Rows.Add("PI");
            table.Rows.Add("RJ");
            table.Rows.Add("RN");
            table.Rows.Add("RS");
            table.Rows.Add("RO");
            table.Rows.Add("RR");
            table.Rows.Add("SC");
            table.Rows.Add("SP");
            table.Rows.Add("SE");
            table.Rows.Add("TO");

            foreach (DataRow row in table.Rows)
            {
                ufModel _uf = new ufModel();
                _uf.uf = row["UF"].ToString();
                uf.Add(_uf);
            }

            return uf;

        }
    }
}
       
