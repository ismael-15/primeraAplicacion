using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using primeraAplicacion.Models;

namespace primeraAplicacion.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            Personal personal = new Personal();
            personal.name ="Ismae";
            personal.lastname ="Luna";
            personal.age=30;
            personal.email = "ismaleluna18@gmail.com";
            personal.telephone=70206022;
            personal.address = "Menaguera morazan";
            return View(personal);
        }
    }
}


