using Api_Postgres_.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Postgres_.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Aluno> alunos { get; set; }

        public DbSet<Professor> professores { get; set; }

        public DbSet<Materia> materias { get; set; }

    }
}
