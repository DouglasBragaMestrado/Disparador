using System.ComponentModel.DataAnnotations;

namespace site.Models.Smtp
{
    public class DiparaEmailModel
    {
        [Key]
        public string? assunto { get; set; }
        public string? mensagem { get; set; }
        public int Porta { get; set; }
        public bool SSL { get; set; }
        public string? HOST { get; set; }
        public string? ToEmail { get; set; }
        public string? User { get; set; }
        public string? Password { get; set; }

    }
}
