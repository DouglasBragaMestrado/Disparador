
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace site.Models
{
    [Table("TB_LOGIN_CADASTRO")]
    public class LoginAcessoModel
    {
        [Key]

        [Column("ID_LOGIN_CADASTRO")]
        public int IdLoginCadastro { get; set; }
        [Column("ID_CONSULTOR")]
        public int IdConsultor { get; set; }
        [Column("NM_LOGIN")]
        public string login { get; set; }
        [Column("NM_SENHA")]
        public string senha { get; set; }
        [Column("ID_STATUS")]
        public int IdStatus { get; set; }
        [Column("DH_DATA_INICIAL")]
        public DateTime DataInicial { get; set; }
        [Column("DH_DATA_ATUALIZACAO")]
        public DateTime DataAtualizacao { get; set; }


    }
}
