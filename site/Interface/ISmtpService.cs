using site.Models.Smtp;

namespace site.Interface
{
    public interface ISmtpService
    {
        void SendMail(SmtpModel bodyMail);
        void DisparoEMail(SmtpModel bodyMail);

    }
}
