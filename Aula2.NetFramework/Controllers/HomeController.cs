using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula2.NetFramework.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult TransferenciaDados()
        {
            //Existem durante a comunicaçao
            //Stateless
            ViewData["Codigo"] = "1";
            ViewBag.Nome = "Joao";

            //Statefull
            Session["Autenticado"] = "Ok";



            return View();
        }
    }
}