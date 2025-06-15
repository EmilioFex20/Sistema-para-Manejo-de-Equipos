using Microsoft.AspNetCore.Mvc;

namespace Sitema_Manejo_Equipos.Controllers
{
    public class ProyectoController : Controller
    {
        private readonly AppDbContext _context;
        public ProyectoController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var proyectos = _context.Proyectos.ToList();
            return View(proyectos);
        }
    }
}
