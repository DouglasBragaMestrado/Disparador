using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using site.Interface;
using site.Models;
using static site.Models.UtilModel;

namespace site.Controllers.Nivel
{
    public class NivelController: Controller
    {
        private readonly INivelService _nivel;
        private static NivelModel nivel = new NivelModel();

        public NivelController(INivelService nivel)
        {
            _nivel = nivel;
        }

        [Route("consultor/nivel")]
        [HttpGet]
        public async Task<IActionResult> Nivel()
        {
            IEnumerable<NivelModel> nivels = await _nivel.Get();
            return View(nivels);
        }

        [Route("consultor/nivel")]
        [HttpPost]
        public async Task<IActionResult> Nivel(string Descricao, string botao)
        {
            if (botao != null)
            {
                NivelModel nivel = new NivelModel();
                nivel.Descricao = Descricao;
                await _nivel.Create(nivel);
                ViewBag.Mensagem = "Registro incluso com sucesso!";
            }
            IEnumerable<NivelModel> nivels = await _nivel.Get();

            return View(nivels);
        }

        [Route("consultor/nivel/delete")]
        [HttpGet]
        public async Task<IActionResult> Nivel(int id)
        {
            nivel.IdNivel = id;
            await _nivel.Delete(nivel);

            IEnumerable<NivelModel> nivels = await _nivel.Get();
            return View(nivels);
        }
    }

}
