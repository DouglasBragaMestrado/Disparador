using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace site.Models.Contato
{
    [Table("contato")]
    public class contatoModel
    {
        [Key]
        public int IdContato { get; set; }
        public int IdStatus { get; set; }
        public string? Nome { get; set; }
        public string? Pais { get; set; }
        public int DDI { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Assunto { get; set; }
        public string? Mensagem { get; set; }
        public DateTime DataInclusao { get; set; }
        public string? idioma { get; set; }
    }
}
