using site.Interface;
using site.Models;
using System.Diagnostics;
using System.Reflection;

namespace site.Service
{
    public class NivelService : INivelService
    {
        private readonly  siteDBContext? _context;
        private readonly ILogService _logService;
        private LogModel _logModel = new LogModel();

        public NivelService(siteDBContext context, ILogService logService)
        {
            _context = context;
            _logService = logService;
        }

        public  async Task Create(NivelModel nivel)
        {
            try
            {
                _context.TB_CADASTRO_NIVEL.Add(nivel);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var exp = MethodBase.GetCurrentMethod().ReflectedType;
                _logModel.Local = Path.GetFullPath(GetType().FullName).ToString();
                _logModel.Mensagem = "Programa: " + this.GetType().Name + ". Metodo: " + exp.Name.ToString() + ". Erro: " + ex.Message.ToString();
                await _logService.Create(_logModel);
            }
        }

        public async Task Delete(NivelModel nivel)
        {
            try 
            { 
                _context.TB_CADASTRO_NIVEL.Remove(nivel);
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

        public async Task<IEnumerable<NivelModel>> Get()
        {  
            try
            {
                IEnumerable<NivelModel> nivel = _context.TB_CADASTRO_NIVEL.OrderBy(d => d.Descricao).ToList();
                return nivel;
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

        public async Task<NivelModel> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(NivelModel nivel)
        {
            throw new NotImplementedException();
        }
    }
}
