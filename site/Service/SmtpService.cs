using site.Interface;
using site.Models.Smtp;
using System.Net;
using System.Net.Mail;

namespace site.Service
{
    public class SmtpService : ISmtpService
    {
        SmtpConfiguration _configuration = new SmtpConfiguration();

        public void SendMail(SmtpModel bodyMail)
        {
            SmtpClient smtp = new SmtpClient();
            NetworkCredential NetworkCred = new NetworkCredential();

            //creating the object of MailMessage  
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(_configuration.FromMail, "Confirmação do recebimento do seu contato"); //From Email Id  
            mailMessage.Subject = bodyMail.Subject;
            mailMessage.Body = bodyMail.Body; //body or 
            mailMessage.IsBodyHtml = true;

            string[] ToMuliId = bodyMail.ToMail.Split(',');
            foreach (string ToEMailId in ToMuliId)
            {
                mailMessage.To.Add(new MailAddress(ToEMailId)); //adding multiple TO Email Id  
            }

            if (bodyMail.cc != null)
            {

                string[] CCId = bodyMail.cc.Split(',');
                foreach (string CCEmail in CCId)
                {
                    mailMessage.CC.Add(new MailAddress(CCEmail)); //Adding Multiple CC email Id  
                }
            }

            if (bodyMail.bcc != null)
            {
                string[] bccid = bodyMail.bcc.Split(',');

                foreach (string bccEmailId in bccid)
                {
                    mailMessage.Bcc.Add(new MailAddress(bccEmailId)); //Adding Multiple BCC email Id  
                }
            }

            smtp.Host = _configuration.Host;

            smtp.EnableSsl = _configuration.EnableSsl;
            NetworkCred.UserName = _configuration.UserName;
            NetworkCred.Password = _configuration.Password;
            smtp.UseDefaultCredentials = _configuration.UseDefaultCredentials;
            smtp.Credentials = NetworkCred;
            smtp.Port = _configuration.Port;
            smtp.Send(mailMessage);

        }

        public void DisparoEMail(SmtpModel bodyMail)
        {
            MailMessage newMail = new MailMessage();
            SmtpClient client = new SmtpClient(_configuration.Host);
            newMail.From = new MailAddress(_configuration.FromMail, "AtentBot - Confirmação do recebimento do seu contato");

            newMail.To.Add(bodyMail.ToMail);

            newMail.Subject = bodyMail.Subject;

            newMail.IsBodyHtml = true; newMail.Body = bodyMail.Body;

            client.EnableSsl = _configuration.EnableSsl;
            client.Port = _configuration.Port;
            client.Credentials = new System.Net.NetworkCredential(_configuration.UserName, _configuration.Password);

            client.Send(newMail);
        }
    }
}
