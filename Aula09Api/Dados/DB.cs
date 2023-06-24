using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aula09Api.Models;

namespace Aula09Api.Dados
{
    public class DB
    {
        public static List<Alunos> alunos = new List<Alunos>()
        {
            new Alunos() {Codigo = 1, Nome = "Rubens"},
            new Alunos() {Codigo = 2, Nome = "João"},
            new Alunos() {Codigo = 3, Nome = "Bruna"},
            new Alunos() {Codigo = 4, Nome = "Julia"},
            new Alunos() {Codigo = 5, Nome = "Joana"},
        };

        public static IEnumerable<Alunos> ListarAlunos()
        {
            return alunos;
        }

        public static IEnumerable<string> ListarMaterias()
        {
            return new List<string> {
                "Matematica",
                "Portugues",
                "Historia"
            };
        }

    }
}