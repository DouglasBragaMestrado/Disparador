namespace site.Models.Smtp
{
    public class SmtpConfiguration
    {
        public string Host { get; set; } = "smtp.kinghost.net";
        public int Port { get; set; } = 587;
        public string UserName { get; set; } = "notreply@dewconsultoria.com.br";
        public string Password { get; set; } = "H7bEmhDn3#U$jiK";
        //public string UserName { get; set; } = "doug_dev@outlook.com";
        //public string Password { get; set; } = "Master20$";
        public string FromMail { get; set; } = "notreply@dewconsultoria.com.br";
        public bool EnableSsl { get; set; } = false;
        public bool UseDefaultCredentials { get; set; } = true;
    }
}
