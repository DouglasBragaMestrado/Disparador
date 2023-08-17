using Microsoft.AspNetCore.Mvc;
using site.Models;

namespace site.Controllers.Login
{
    public class LoginController:Controller
    {
        private readonly ILogger<HomeController> _logger;
        public LoginController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("login/acesso/consultor")]
        [HttpGet]
        public async Task<IActionResult> Consultor()
        {
            return View();
        }
        [Route("login/acesso/consultor")]
        [HttpPost]      
        public async Task<IActionResult> Consultor(LoginModel login)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Mensagem = "Teste bem sucedido!";
            }
            
            return View();
        }       
    }
}
