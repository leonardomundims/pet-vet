using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace at02_PetVet.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult Agendar()
        {
            return View();
        }


        // implementar envio do formulario
        // [HttpPost]
        // public IActionResult Agendar()
        // {
        //     return View();
        // }

    }
}
