namespace site.Models.Smtp
{
    public class SmtpBodyModel
    {
        public string ToEmail { get; set; }
        public string cc { get; set; }
        public string bcc { get; set; }
        public string body { get; set; }
        public string subject { get; set; }

    }
}
