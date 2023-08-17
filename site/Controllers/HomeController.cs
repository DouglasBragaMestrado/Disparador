using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using site.Interface;
using site.Models;
using site.Models.Contato;
using site.Models.Parametro;
using site.Models.Smtp;
using site.Models.WhatsApp;
using System.Diagnostics;
using System.Globalization;


namespace site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICountryService _country;
        private readonly IContatoService _contato;
        private readonly home _home = new home();
        private readonly ISmtpService _smtp;
        private readonly IWhatsAppService _whatsApp;

        //public HomeController(IStringLocalizer<HomeController> localizer)
        //{
        //    _localizer = localizer;
        //}

        public HomeController(ILogger<HomeController> logger, ICountryService country,
            IContatoService contato, ISmtpService smtp, IWhatsAppService whatsApp)
        {
            _logger = logger;
            _country = country;
            _contato = contato;
            _smtp = smtp;
            _whatsApp = whatsApp;

        }

        [HttpGet]
        public IActionResult Index()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;

            _home.idioma = currentCulture.ToString();
            ViewBag.About = _home.about;
            ViewBag.Empresa = _home.empresa;
            ViewBag.Services = _home.service;
            ViewBag.ServicesDetalhe = _home.serviceDetalhe;
            ViewBag.Pricing = _home.pricing;
            ViewBag.Contato = _home.contact;
            ViewBag.Titulo = _home.titulo;
            ViewBag.SubTitulo = _home.subTitulo;
            ViewBag.Iniciar = _home.iniciar;
            ViewBag.Hello = _home.hello;
            ViewBag.HelloSub = _home.helloSub;
            ViewBag.Top1 = _home.top1;
            ViewBag.Top2 = _home.top2;
            ViewBag.Top3 = _home.top3;
            ViewBag.Top4 = _home.top4;
            ViewBag.oQueFazemos = _home.oQueFazemos;
            ViewBag.suboQueFazemos = _home.suboQueFazemos;
            ViewBag.comunicaWhatsApp = _home.comunicaWhatsApp;
            ViewBag.subcomunicaWhatsApp = _home.subcomunicaWhatsApp;
            ViewBag.Name = _home.name;
            ViewBag.Celular = _home.celular;
            ViewBag.Microsoft = _home.microsoft;
            ViewBag.WhatsApp = _home.whatsapp;
            ViewBag.Google = _home.google;
            ViewBag.Vonage = _home.vonage;
            ViewBag.SelecionePais = _home.paisSelecione;
            ViewBag.Pais = _home.pais;
            ViewBag.Assunto = _home.assunto;
            ViewBag.Mensagem = _home.mensagem;
            ViewBag.EnviarMensagem = _home.mensagemEnviar;
            ViewBag.Loading = _home.loading;
            ViewBag.Idioma = _home.idioma;

            //Carregar Json com paises
            List<PaisesModel> paises = new List<PaisesModel>();
            paises = _country.Get();

            ViewBag.PaisSelectList = new SelectList(paises, "ddi", "name");

            return View();
        }
        public IActionResult temporario()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contato([FromForm] contatoModel contato)
        {
            if (contato != null)
            {
                try
                {
                    contato.DataInclusao = DateTime.Now;
                    contato.IdStatus = 3;
                    await _contato.Create(contato);
                    ViewBag.MensagemResposta = _home.mensagemRespostaSucesso;

                    SmtpModel smtp = new SmtpModel();
                    smtp.ToMail = contato.Email;
                    smtp.Body = contato.Mensagem;
                    smtp.Subject = contato.Assunto;
                    _smtp.DisparoEMail(smtp);

                    SendMensagemModel mensagem = new SendMensagemModel();

                    string nome = contato.Nome.ToUpper();

                    var nomes = contato.Nome.Split(" ");
                    if (nome.Count() > 1)
                    {
                        nome = nomes[0].ToString();
                    }

                    _home.idioma = contato.idioma;

                    mensagem.body = _home.mensagemContatoWhatsApp.ToString().Replace("FULANO02", nome).Replace("ASSUNTO02", contato.Assunto);
                    mensagem.number = contato.DDI + contato.Phone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                    await _whatsApp.SendMensagem(mensagem);
                }
                catch (Exception ex)
                {
                    ViewBag.MensagemResposta = _home.mensagemRespostaErro + ex.Message;
                }
            }
            return Ok(ViewBag.MensagemResposta);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}