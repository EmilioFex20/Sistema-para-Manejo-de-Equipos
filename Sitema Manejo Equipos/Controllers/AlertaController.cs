using Microsoft.AspNetCore.Mvc;

namespace Sitema_Manejo_Equipos.Controllers {
    public class AlertaController : Controller
    {
        private readonly AppDbContext _context;

        public AlertaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var alertas = _context.Alertas.ToList();

            return View(alertas);
        }
    }

}

