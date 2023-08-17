using site.Models.WhatsApp;

namespace site.Interface
{
    public interface IWhatsAppService
    {
        Task SendMensagem(SendMensagemModel mensagem);
    }
}
