using site.Interface;
using site.Models;

namespace site.Service
{
    public class LoginService : ILoginServive
    {
        public Task Create(LoginModel login)
        {
            throw new NotImplementedException();
        }

        public Task Delete(LoginModel login)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LoginModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<LoginModel> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Update(LoginModel login)
        {
            throw new NotImplementedException();
        }
    }
}
