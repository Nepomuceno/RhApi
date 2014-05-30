using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RhApi.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Cargos()
        {
            return View();
        }

        // GET: Cadastro
        public ActionResult Funcoes()
        {
            return View();
        }
    }
}