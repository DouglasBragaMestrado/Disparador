using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace site.Models
{
    [Table("TB_CADASTRO_USUARIO")]
    public class ConsultorModel
    {
        [Key]
        public int ID_CONSULTOR { get; set; }
        [Column("ID_USUARIO_NIVEL")]
        public int IdNivel { get; set; }
        [Column("ID_STATUS")]
        public int Idstatus { get;set; }
        [Column("NM_NOME_COMPLETO")]
        public string? NomeCompleto { get; set; }
        [Column("NM_ENDERECO")]
        public string? logradouro { get; set; }
        [Column("NR_NUMERO")]
        public string? numero { get; set; }
        [Column("NM_COMPLEMENTO")]
        public string? complemento { get; set; }
        [Column("NR_CEP")]
        public string? CEP { get; set; }
        [Column("NM_BAIRRO")]
        public string? bairro { get; set; }
        [Column("NM_CIDADE")]
        public string? localidade { get; set; }
        [Column("NM_UF")]
        public string? uf { get; set; }
        [Column("NM_EMAIL")]
        public string? email { get; set; }
        [Column("NM_DDD")]
        public string? ddd { get; set; }
        [Column("NM_TELEFONE")]
        public string? telefone { get; set; }
        [Column("DH_DATA_INICIAL")]
        public DateTime DataInicial { get; set; }=DateTime.Now;
        [Column("DH_DATA_ATUALIZACAO")]
        public DateTime DataAtualizacao { get; set; }
    }
}
