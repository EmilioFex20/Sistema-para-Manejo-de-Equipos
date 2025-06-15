using Microsoft.AspNetCore.Mvc;

namespace Sitema_Manejo_Equipos.Controllers
{
    public class PrestamoController : Controller
    {
        private readonly AppDbContext _context;
        public PrestamoController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var prestamos = _context.Prestamos.ToList();
            return View(prestamos);
        }
    }
}
