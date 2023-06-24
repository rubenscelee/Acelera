using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aula09Api.Dados;
using Aula09Api.Models;

namespace Aula09Api.Controllers
{
    [RoutePrefix("api/alunos")]
    public class AlunosController : ApiController
    {
        [HttpGet, Route("ListarMaterias")]
        public IEnumerable<string> GetMaterias()
        {
            return DB.ListarMaterias();
        }
        [HttpGet, Route("ListarAlunos")]
        public IEnumerable<Alunos> GetAlunos()
        {
            return DB.ListarAlunos();
        }

        [HttpGet, Route("PesquisarMateria/{id}")]
        public string PesqMateria(string id)
        {
            List<string> Mats = (List<string>)DB.ListarMaterias();
            return Mats.Find(p => Mats.Contains(id));
        }

        [HttpGet, Route("PesquisarAluno/{id}")]
        public string PesqAluno(string id)
        {
            List<string> Aluno = (List<string>)DB.ListarAlunos();
            return Aluno.Find(p => Aluno.Contains(id));
        }
    }
}
