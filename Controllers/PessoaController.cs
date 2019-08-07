using AspNetCoreMvcControllersActions.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcControllersActions.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            Pessoa p = new Pessoa();
            p.Nome = "Renato";

            p.Telefone = "65-9522222";


            return View(p);
        }


        public IActionResult Formulario()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Formulario(Pessoa pessoa)
        {
            return View("Pessoa", pessoa);
        }

    }
}

