using Cadastro_de_contatos.Data;
using Cadastro_de_contatos.Models;

namespace Cadastro_de_contatos.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly AppDBContext _context;

        public ContatoRepository(AppDBContext context) {
            _context = context;
        }
        public List<ContatoModel> ListarContatos()
        {
            return _context.contatos.ToList();
        }

        public ContatoModel Adicionar(ContatoModel Contato)
        {
            _context.contatos.Add(Contato);
            _context.SaveChanges();

            return Contato;
        }

         
    }
}
