using Api_Postgres_.Data;
using Api_Postgres_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_Postgres_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MateriasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Materias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materia>>> Getmaterias()
        {
            return await _context.materias.ToListAsync();
        }

        // GET: api/Materias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Materia>> GetMateria(int id)
        {
            var materia = await _context.materias.FindAsync(id);

            if (materia == null)
            {
                return NotFound();
            }

            return materia;
        }


        // GET: api/Materias/5
        [HttpGet("{nome}")]
        public async Task<ActionResult<Materia>> GetMateriaNome(string nome)
        {
            var materia = await _context.materias.FindAsync(nome);

            if (materia == null)
            {
                return NotFound();
            }

            return materia;
        }

        // PUT: api/Materias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMateria(int id, Materia materia)
        {
            if (id != materia.id)
            {
                return BadRequest();
            }

            _context.Entry(materia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MateriasExists(id))
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

        // POST: api/Materias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Materia>> PostMaterias(Materia materia)
        {
            _context.materias.Add(materia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMaterias", new { id = materia.id }, materia);
        }

        // DELETE: api/Materias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMaterias(int id)
        {
            var materias = await _context.materias.FindAsync(id);
            if (materias == null)
            {
                return NotFound();
            }

            _context.materias.Remove(materias);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MateriasExists(int id)
        {
            return _context.materias.Any(e => e.id == id);
        }
    }
}
