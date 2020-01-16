using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using financeiro.UI.Web.Models;
using financeiro.ApplicationCore.Interfaces.Services;

namespace financeiro.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IClienteServices _clienteServices;

        public HomeController(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }

        public IActionResult Index()
        {
            var x= _clienteServices.ObterTodos();

            return View();
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
