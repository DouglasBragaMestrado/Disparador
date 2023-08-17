using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace site.Models
{
    [Table("TB_CADASTRO_NIVEL")]
    public class NivelModel
    {
        [Key]
        [Column("ID_USUARIO_NIVEL")]
        public int IdNivel { get; set; }
        [Column("NM_DESCRICAO")]
        public string? Descricao { get; set; }
    }
}
