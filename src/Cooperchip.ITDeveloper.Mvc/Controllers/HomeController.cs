using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cooperchip.ITDeveloper.Mvc.Models;

namespace Cooperchip.ITDeveloper.Mvc.Controllers
{
    [Route("")]
    [Route("paciente")]
    [Route("pacientes")]
    [Route("gestao-de-paciente")]
    [Route("gestao-de-pacientes")]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("pagina-inicial")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("quem-somos")]
        [Route("sobre-nos")]
        [Route("sobre/{id:Guid}/{paciente}/{categoria?}")]
        public IActionResult Sobre(int id, string paciente, string categoria)
        {
            return View();
        }

        [Route("politica-de-privacidade")]
        public IActionResult Privacy()
        {
            return View();
        }
        
        [Route("erro")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("icones")]
        public IActionResult Icones()
        {
            return View();
        }
    }
}
