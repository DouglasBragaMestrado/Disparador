using site.Interface;
using site.Models.Contato;

namespace site.Service
{
    public class ContatoService : IContatoService
    {
        private readonly siteDBContext? _context;
        public async Task Create(contatoModel contato)
        {
            _context.contato.Add(contato);
            await _context.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<contatoModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<contatoModel> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Update(contatoModel contato)
        {
            throw new NotImplementedException();
        }
    }
}
