using site.Interface;
using site.Models;
using System.Reflection;

namespace site.Service
{
    public class StatusService : IStatusService
    {
        private readonly siteDBContext _context;
        private readonly ILogService _logService;
        private LogModel _logModel = new LogModel();

        public StatusService(siteDBContext context, ILogService logService)
        {
            _context = context;
            _logService = logService;
        }

        public Task Create(StatusModel status)
        {
            throw new NotImplementedException();
        }

        public Task Delete(StatusModel status)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<StatusModel>> Get()
        {
            try
            {
                var _stA = _context.TB_STATUS.ToList();
                return _stA;
            }
            catch (Exception ex)
            {
                var exp = MethodBase.GetCurrentMethod().ReflectedType;
                _logModel.Local = Path.GetFullPath(GetType().FullName);
                _logModel.Mensagem = "Programa: " + this.GetType().Name + ". Metodo: " + exp.Name.ToString() + ". Erro: " + ex.Message.ToString();
                await _logService.Create(_logModel);
                return null;
            }
        }

        public Task<StatusModel> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Update(StatusModel status)
        {
            throw new NotImplementedException();
        }
    }
}
