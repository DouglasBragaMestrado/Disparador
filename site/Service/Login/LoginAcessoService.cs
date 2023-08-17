using site.Interface;
using site.Models;
using System.Reflection;

namespace site.Service
{
    public class LoginAcessoService : ILoginAcessoService

    {
        private readonly siteDBContext _context;
        private readonly ILogService _logService;
        private LogModel _logModel = new LogModel();

        public LoginAcessoService(siteDBContext context, ILogService logService)
        {
            _context = context;
            _logService = logService;
        }

        public async Task<int> Create(LoginAcessoModel loginAcesso)
        {
            try
            {
                _context.TB_LOGIN_CADASTRO.Add(loginAcesso);
                await _context.SaveChangesAsync();
                var _reS = _context.TB_LOGIN_CADASTRO.FirstOrDefault(d => d.IdConsultor == loginAcesso.IdConsultor);
                return _reS.IdLoginCadastro;
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

        public Task Delete(LoginAcessoModel loginAcesso)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LoginAcessoModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<LoginAcessoModel> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Update(LoginAcessoModel loginAcesso)
        {
            throw new NotImplementedException();
        }
    }
}
