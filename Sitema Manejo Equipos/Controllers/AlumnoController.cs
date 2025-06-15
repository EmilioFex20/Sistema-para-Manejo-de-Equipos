using Microsoft.AspNetCore.Mvc;

namespace Sitema_Manejo_Equipos.Controllers {
    public class AlumnoController : Controller
    {
        private readonly AppDbContext _context;

        public AlumnoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var alumnos = _context.Alumnos.ToList();

            return View(alumnos);
        }
    }
}


