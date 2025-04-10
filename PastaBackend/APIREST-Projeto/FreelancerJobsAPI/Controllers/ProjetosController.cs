using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FreelancerJobsAPI.Models;

namespace FreelancerJobsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjetosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProjetosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/projetos/usuario/{usuarioId}
        [HttpGet("usuario/{usuarioId}")]
        public async Task<ActionResult<IEnumerable<Projeto>>> GetProjetosPorUsuario(int usuarioId)
        {
            var projetos = await _context.Projetos
                                         .Where(p => p.UsuarioId == usuarioId)
                                         .ToListAsync();

            if (projetos == null || !projetos.Any())
                return NotFound("Nenhum projeto encontrado para este usuário.");

            return Ok(projetos);
        }

        // POST: api/projetos
        [HttpPost]
        public async Task<ActionResult<Projeto>> CriarProjeto(Projeto projeto)
        {
            _context.Projetos.Add(projeto);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProjetosPorUsuario), new { usuarioId = projeto.UsuarioId }, projeto);
        }

        // PUT: api/projetos/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> EditarProjeto(int id, Projeto projeto)
        {
            if (id != projeto.Id)
                return BadRequest("ID do projeto não confere.");

            _context.Entry(projeto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Projetos.Any(p => p.Id == id))
                    return NotFound("Projeto não encontrado.");

                throw;
            }

            return NoContent();
        }

        // DELETE: api/projetos/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> ExcluirProjeto(int id)
        {
            var projeto = await _context.Projetos.FindAsync(id);
            if (projeto == null)
                return NotFound("Projeto não encontrado.");

            _context.Projetos.Remove(projeto);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
