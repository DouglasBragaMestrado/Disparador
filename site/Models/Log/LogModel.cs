using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace site.Models
{
    public class LogModel
    {
        [Key]
        [Column("ID_LOG")]
        public int IdLog { get; set; }
        [Column("NM_LOCAL")]
        public string Local { get; set; }
        [Column("NM_MENSAGEM")]
        public string Mensagem { get; set; }
        [Column("DT_INCLUSAO")]
        public DateTime Inclusao { get; set; } = DateTime.Now;
    }
}
