using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula_02.NetFramework.Models;

namespace Aula_02.NetFramework.Controllers
{
    public class AlunosController : Controller
    {

        public List<Alunos> BD()
        {
            List<Alunos> Lista = new List<Alunos>();

            Lista.Add(new Alunos() { ID = 1, Nome = "Rubens", CPF = "45678915345" });
            Lista.Add(new Alunos() { ID = 2, Nome = "João", CPF = "48798561523" });
            Lista.Add(new Alunos() { ID = 3, Nome = "Bruna", CPF = "15478956482" });
            Lista.Add(new Alunos() { ID = 4, Nome = "Joana", CPF = "15346589715" });

            return Lista;
        }

        public Alunos PesquisaAlunos(int Codigo)
        {
            var item = from Aluno in BD()
                       where Aluno.ID == Codigo
                       select new { Aluno.ID, Aluno.Nome, Aluno.CPF };

            Alunos resultado = new Alunos(); ;

            foreach (var ler in item)
            {
                resultado.ID = ler.ID;
                resultado.Nome = ler.Nome;
                resultado.CPF = ler.CPF;
            }

            return resultado;

        }
     
        public ActionResult TrazerAlunos(int id)
        {
            return View(PesquisaAlunos(id));
        }

        [HttpGet]
        public ActionResult IncluirAluno()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirAluno(FormCollection Form)
        {
            var Cod = Convert.ToInt32(Form["id"]);
            var Nome = Form["Nome"];
            var Cpf = Form["Cpf"];

            Alunos novoAluno = new Alunos();

            novoAluno.ID = Cod;
            novoAluno.Nome = Nome;
            novoAluno.CPF = Cpf;

            return View("VerAluno", novoAluno);
        }

        [HttpGet]
        public ActionResult IncluirAlunoTipado()
        {
            return View();
        }

        [HttpGet]
        public ActionResult IncluirAlunoTipado(Alunos aluno)
        {
            return View("VerAluno", aluno);
        }

        public ActionResult VerAluno()
        {
            return View();
        }

        // GET: Alunos
        public ActionResult Index()
        {
            return View();
        }
    }
}