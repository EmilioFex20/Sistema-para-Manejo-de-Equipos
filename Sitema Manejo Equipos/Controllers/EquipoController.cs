using Microsoft.AspNetCore.Mvc;

namespace Sitema_Manejo_Equipos.Controllers
{
    public class EquipoController : Controller
    {
        private readonly AppDbContext _context;
        public EquipoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var equipos = _context.Equipos.ToList();
            return View(equipos);
        }
    }
}
