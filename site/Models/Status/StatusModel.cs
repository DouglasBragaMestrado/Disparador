using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace site.Models
{
    [Table("TB_STATUS")]
    public class StatusModel
    {
        [Key]
        [Column("ID_STATUS")]
        public int IdStatus { get; set; }
        [Column("NM_DESCRICAO")]
        public string Descricao { get;set; }
    }
}
