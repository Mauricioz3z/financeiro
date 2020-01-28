using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace financeiro.UI.Web.Controllers
{
    public class PerfisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}