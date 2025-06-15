using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sitema_Manejo_Equipos.Models;

namespace Sitema_Manejo_Equipos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertaApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AlertaApiController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/alertas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<alerta>>> GetAlertas()
        {
            return await _context.Alertas.Include(a => a.equipo).ToListAsync();
        }

        // GET: api/alertaapi/{id_alerta}/{id_equipo}
        [HttpGet("{id_alerta}/{id_equipo}")]
        public async Task<ActionResult<alerta>> GetAlerta(int id_alerta, int id_equipo)
        {
            var alerta = await _context.Alertas
                .Include(a => a.equipo)
                .FirstOrDefaultAsync(a => a.id_alerta == id_alerta && a.id_equipo == id_equipo);

            if (alerta == null)
                return NotFound();

            return alerta;
        }

        // POST: api/alertas
        [HttpPost]
        public async Task<ActionResult<alerta>> PostAlerta(alerta alerta)
        {
            _context.Alertas.Add(alerta);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAlerta), new { id_alerta = alerta.id_alerta, id_equipo = alerta.id_equipo }, alerta);
        }

        // PUT: api/alertas/{id_alerta}/{id_equipo}
        [HttpPut("{id_alerta}/{id_equipo}")]
        public async Task<IActionResult> PutAlerta(int id_alerta, int id_equipo, alerta alerta)
        {
            if (id_alerta != alerta.id_alerta || id_equipo != alerta.id_equipo)
                return BadRequest();

            _context.Entry(alerta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlertaExists(id_alerta, id_equipo))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/alertas/{id_alerta}/{id_equipo}
        [HttpDelete("{id_alerta}/{id_equipo}")]
        public async Task<IActionResult> DeleteAlerta(int id_alerta, int id_equipo)
        {
            var alerta = await _context.Alertas
                .FirstOrDefaultAsync(a => a.id_alerta == id_alerta && a.id_equipo == id_equipo);

            if (alerta == null)
                return NotFound();

            _context.Alertas.Remove(alerta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlertaExists(int id_alerta, int id_equipo)
        {
            return _context.Alertas.Any(e => e.id_alerta == id_alerta && e.id_equipo == id_equipo);
        }

    }
}
