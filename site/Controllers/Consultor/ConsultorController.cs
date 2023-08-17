using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using site.Interface;
using site.Models;
using System.Collections.Generic;
using static site.Models.UtilModel;

namespace site.Controllers.Consultor
{
    public class ConsultorController: Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUtil _util;
        private readonly IConsultorService _consultorService;
        private readonly INivelService _nivel;
        private readonly IStatusService _status;
        private readonly ILoginAcessoService _loginAcesso;
        private readonly ILoginDisparadorService _loginDisparador;

        public ConsultorController(ILogger<HomeController> logger, IUtil util, IConsultorService consultorService, INivelService nivelService, 
            IStatusService status, ILoginAcessoService loginAcesso, ILoginDisparadorService loginDisparador)
        {
            _logger = logger;
            _util = util;
            _consultorService = consultorService;
            _nivel = nivelService;
            _status = status;
            _loginAcesso = loginAcesso;
            _loginDisparador = loginDisparador;
        }

        [Route("consultor/cadastro")]
        [HttpGet]
        public async Task<IActionResult> Formulario()
        {
            List<ufModel> uf = new List<ufModel>();
            uf = await _util.getUf();
            ViewBag.UF = uf.Select(d=> new SelectListItem { Text = d.uf, Value = d.uf.ToString()}).ToList();
            
            IEnumerable<NivelModel> nivels = await _nivel.Get();
            ViewBag.Nivel = nivels.Select(d=> new SelectListItem { Text = d.Descricao, Value = d.IdNivel.ToString()}).ToList();

            IEnumerable<StatusModel> status = await _status.Get();
            ViewBag.Status = status.Select(d => new SelectListItem { Text = d.Descricao, Value = d.IdStatus.ToString() }).ToList();

            return View();
        }

        [Route("consultor/cadastro")]
        [HttpPost]
        public async Task<IActionResult> Formulario(ConsultorModel consultor, string? telefone, string botao, string password)
        {

            if (consultor.CEP != null)
            {
                CepModel cepModel = await _util.getCEP(consultor.CEP);
                consultor.logradouro = cepModel.logradouro;
                consultor.uf = cepModel.uf;
                consultor.bairro = cepModel?.bairro;
                consultor.complemento = cepModel?.complemento;
                consultor.localidade = cepModel?.localidade;
                if (telefone?.Length > 9)
                {
                    var tel = telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ","");
                    consultor.ddd = tel.Substring(0, 2);
                    consultor.telefone = tel.Substring(2, 9);
                }

                ViewBag.Telefone = telefone;
                IEnumerable<NivelModel> nivels = await _nivel.Get();
                ViewBag.Nivel = nivels.Select(d => new SelectListItem { Text = d.Descricao, Value = d.IdNivel.ToString() }).ToList();

                IEnumerable<StatusModel> status = await _status.Get();
                ViewBag.Status = status.Select(d => new SelectListItem { Text = d.Descricao, Value = d.IdStatus.ToString() }).ToList();

                if (botao != null)
                {
                    var _coN = await _consultorService.Get(consultor.email);
                    if (_coN != null)
                    {
                        ViewBag.Mensagem = "Ops. Email já registrado!";
                        return View();
                    }
                    else if (check(consultor))
                    {
                        if(consultor.numero == null)
                        {
                            consultor.numero = "sem número";
                        }

                        LoginAcessoModel login = new LoginAcessoModel();
                        LoginDisparadorModel loginDisparador = new LoginDisparadorModel();  
                        login.login = consultor.email;
                        login.senha = password;
                        login.IdStatus = 3;

                        login.IdConsultor = await _consultorService.Create(consultor);
                        loginDisparador.IdLoginCadastro = await _loginAcesso.Create(login);
                        loginDisparador.IdConsultor = login.IdConsultor;
                        loginDisparador.idStatus = 3;
                        loginDisparador.CodigoValidacao = await _util.getNumbers(); ;
                        await _loginDisparador.Create(loginDisparador);


                        ViewBag.Mensagem = "Registro incluso com sucesso!";
                        return View();
                    }
                    else
                    {
                        ViewBag.Mensagem = "Nem todos os campos foram preenchidos!";
                    }

                }
            }
            else
            {
                ViewBag.Mensagem = "Nem todos os campos foram preenchidos!";
            }

            return View(consultor);
        }

        public bool check(ConsultorModel consultor)
        { 

            if (consultor.NomeCompleto != null && consultor.NomeCompleto.Length > 5)
            {
                return  true;
            }
            else
            {
                return false;
            }
            if (consultor.email != null && consultor.email.Length > 5)
            {
                return  true;
            }
            else
            {
                return false;
            }
            if (consultor.telefone != null && consultor.telefone.Length > 5)
            {
                return  true;
            }
            else
            {
                return false;
            }
        }
    }
}
