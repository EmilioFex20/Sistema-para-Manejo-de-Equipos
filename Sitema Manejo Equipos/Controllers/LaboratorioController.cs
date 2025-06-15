using Microsoft.AspNetCore.Mvc;

namespace Sitema_Manejo_Equipos.Controllers
{
    public class LaboratorioController : Controller
    {
        private readonly AppDbContext _context;
        public LaboratorioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var laboratorios = _context.Laboratorios.ToList();
            return View(laboratorios);
        }
    }
}
