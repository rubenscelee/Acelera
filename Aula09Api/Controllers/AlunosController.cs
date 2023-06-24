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
    public class AlunosController : ApiController
    {
        public AlunosController() { }

        public IEnumerable<string> GetMaterias()
        {
            return DB.ListarMaterias();
        }
    }
}
