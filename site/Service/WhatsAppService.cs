using site.Interface;
using site.Models.WhatsApp;

namespace site.Service
{
    public class WhatsAppService : IWhatsAppService
    {
        public async Task SendMensagem(SendMensagemModel mensagem)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://multbackend.atentbot.com/api/messages/send");
            request.Headers.Add("Authorization", "Bearer 15550f24-cb0f-403a-b37d-0be05632720a");
            var content = new StringContent("{\r\n  \"number\": \"" + mensagem.number + "\",\r\n  \"body\": \"" + mensagem.body + "\"\r\n\r\n}", null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            //Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
    }
}
