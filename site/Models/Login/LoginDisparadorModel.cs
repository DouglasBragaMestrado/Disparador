using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace site.Models
{
    [Table("TB_LOGIN_DISPARADOR")]
    public class LoginDisparadorModel
    {
        [Key]
        [Column("ID_DISPARADOR")]
        public int IdDisparador { get; set; }
        [Column("ID_LOGIN_CADASTRO")]
        public int IdLoginCadastro { get;set; }
        [Column("ID_CONSULTOR")]
        public int IdConsultor { get; set; }
        [Column("ID_STATUS")]
        public int idStatus { get; set; }
        [Column("NR_DATA")]
        public DateTime data { get; set; }=DateTime.Now;
        [Column("NM_CODIGO_VALIDACAO")]
        public int CodigoValidacao { get; set; }

    }
}
