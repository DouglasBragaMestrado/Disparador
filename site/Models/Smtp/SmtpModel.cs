namespace site.Models.Smtp
{
    public class SmtpModel
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string ToMail { get; set; }
        public string cc { get; set; }
        public string bcc { get; set; }
    }
}
