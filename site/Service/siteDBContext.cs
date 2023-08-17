using Microsoft.EntityFrameworkCore;
using site.Models;
using site.Models.Contato;

namespace site.Service
{
    public partial class siteDBContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public siteDBContext(DbContextOptions<siteDBContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public virtual DbSet<contatoModel> contato { get; set; }
        public virtual DbSet<ConsultorModel> TB_CADASTRO_USUARIO { get; set; }
        public virtual DbSet<NivelModel> TB_CADASTRO_NIVEL { get; set; }
        public virtual DbSet<LogModel> TB_LOG { get; set; }
        public virtual DbSet<StatusModel> TB_STATUS { get; set; }
        public virtual DbSet<LoginAcessoModel> TB_LOGIN_CADASTRO { get; set; }
        public virtual DbSet<LoginDisparadorModel> TB_LOGIN_DISPARADOR { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.Development.json");
            var config = builder.Build();

            var connectionString = config.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value.ToString();

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(connectionString);
            }
        }

    }
}
