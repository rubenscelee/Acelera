using Api_Postgres_.Data;
using Api_Postgres_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_Postgres_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProfessoresController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Professores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Professor>>> Getprofessores()
        {
            return await _context.professores.ToListAsync();
        }

        // GET: api/Professores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Professor>> GetProfessor(int id)
        {
            var professor = await _context.professores.FindAsync(id);

            if (professor == null)
            {
                return NotFound();
            }

            return professor;
        }

        // GET: api/Professores/5
        [HttpGet("{nome}")]
        public async Task<ActionResult<Professor>> GetProfessorNome(string nome)
        {
            var professor = await _context.professores.FindAsync(nome);

            if (professor == null)
            {
                return NotFound();
            }

            return professor;
        }

        // PUT: api/Professores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfessor(int id, Professor professor)
        {
            if (id != professor.id)
            {
                return BadRequest();
            }

            _context.Entry(professor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfessoresExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Professores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Professor>> PostProfessor(Professor professor)
        {
            _context.professores.Add(professor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfessores", new { id = professor.id }, professor);
        }

        // DELETE: api/Professores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfessor(int id)
        {
            var professor = await _context.professores.FindAsync(id);
            if (professor == null)
            {
                return NotFound();
            }

            _context.professores.Remove(professor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProfessoresExists(int id)
        {
            return _context.professores.Any(e => e.id == id);
        }
    }
}
