using site.Interface;
using site.Models;
using System.Reflection;

namespace site.Service
{
    public class LoginDisparadorService: ILoginDisparadorService
    {
        private readonly siteDBContext _context;
        private readonly ILogService _logService;
        private LogModel _logModel = new LogModel();

        public LoginDisparadorService(siteDBContext context, ILogService logService)
        {
            _context = context;
            _logService = logService;
        }

        public async Task Create(LoginDisparadorModel disparador)
        {
            try
            {
                _context.TB_LOGIN_DISPARADOR.Add(disparador);
                await _context.SaveChangesAsync();               
            }
            catch (Exception ex)
            {
                var exp = MethodBase.GetCurrentMethod().ReflectedType;
                _logModel.Local = Path.GetFullPath(GetType().FullName);
                _logModel.Mensagem = "Programa: " + this.GetType().Name + ". Metodo: " + exp.Name.ToString() + ". Erro: " + ex.Message.ToString();
                await _logService.Create(_logModel);
            }
        }

        public Task Delete(LoginDisparadorModel disparador)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LoginDisparadorModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<LoginDisparadorModel> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Update(LoginDisparadorModel disparador)
        {
            throw new NotImplementedException();
        }
    }
}
