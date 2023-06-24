using Cadastro_de_contatos.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_de_contatos.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<ContatoModel> contatos { get; set; }
    }
}
