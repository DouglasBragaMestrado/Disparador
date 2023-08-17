using site.Interface;
using site.Models;
using System.Reflection;

namespace site.Service
{
    public class ConsultorService : IConsultorService
    {
        private readonly siteDBContext _context;
        private readonly ILogService _logService;
        private LogModel _logModel = new LogModel();

        public ConsultorService(siteDBContext context, ILogService logService)
        {
            _context = context;
            _logService = logService;
        }

        public async Task<int> Create(ConsultorModel consultor)
        {
            try
            {
                _context.TB_CADASTRO_USUARIO.Add(consultor);
                await _context.SaveChangesAsync();
                var _reS = _context.TB_CADASTRO_USUARIO.FirstOrDefault(d => d.email == consultor.email);
                return _reS.ID_CONSULTOR;
            }
            catch (Exception ex)
            {
                var exp = MethodBase.GetCurrentMethod().ReflectedType;
                _logModel.Local = Path.GetFullPath(GetType().FullName);
                _logModel.Mensagem = "Programa: " + this.GetType().Name + ". Metodo: " + exp.Name.ToString() + ". Erro: " + ex.Message.ToString();
                await _logService.Create(_logModel);
                return 0;
            }
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ConsultorModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<ConsultorModel> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<ConsultorModel?> Get(string email)
        {
            var _coN = _context.TB_CADASTRO_USUARIO.Where(d=> d.email == email).FirstOrDefault();
            return _coN;
        }

        public Task Update(ConsultorModel contato)
        {
            throw new NotImplementedException();
        }
    }
}
