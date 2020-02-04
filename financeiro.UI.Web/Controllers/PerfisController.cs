using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using financeiro.UI.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace financeiro.UI.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PerfisController : Controller
    {
        private RoleManager<IdentityRole> _roleMngr { get; }

        // var roleMngr = new RoleManager<IdentityRole>(roleStore);

        public PerfisController(RoleManager<IdentityRole> RoleMngr)
        {
            _roleMngr = RoleMngr;
        }
        public IActionResult Index()
        {




            var roles = _roleMngr.Roles.ToList().Select(e => new RolesViewModel { Id = e.Id, Name = e.Name });

            return View(roles);
        }
        public IActionResult Edit(string id)
        {
            var role = _roleMngr.Roles.Where(f => f.Id == id).ToList().Select(e => new RolesViewModel { Id = e.Id, Name = e.Name });

            return View(role);
        }
    }
}
