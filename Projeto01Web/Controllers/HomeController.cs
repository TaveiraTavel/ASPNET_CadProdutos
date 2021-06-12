using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto01Web.Models;

namespace Projeto01Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var produto = new Produto();
            return View(produto);
        }

        [HttpPost]
        public ActionResult Index(Produto produto)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", produto);
            }
            return View(produto);
        }

        public ActionResult Resultado(Produto produto)
        {
            return View(produto);
        }
    }
}