using Cadastro_de_contatos.Models;
using Cadastro_de_contatos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro_de_contatos.Controllers
{
    public class ContatoController : Controller
    {

        private readonly ContatoRepository _contatoRepository;

        public ContatoController(ContatoRepository contatoRepository) {
            _contatoRepository = contatoRepository;
        }  

        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepository.ListarContatos();

            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel Contato)
        {
            _contatoRepository.Adicionar(Contato);

            return RedirectToAction("Index");
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Excluir()
        {
            return View();
        }
    }
}
