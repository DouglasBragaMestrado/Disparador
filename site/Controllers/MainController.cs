using Microsoft.AspNetCore.Mvc;

namespace site.Controllers
{
    public class MainController : Controller
    {
        public MainController() { }

        [Route("menu")]
        [HttpGet]
        public async Task<IActionResult> Menu()
        {
            return View();
        }
    }
}
