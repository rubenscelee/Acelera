using Microsoft.AspNetCore.Mvc;

namespace Cadastro_de_contatos.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}