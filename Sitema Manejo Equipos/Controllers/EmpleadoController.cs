using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
public class EmpleadoController : Controller
{
    private readonly AppDbContext _context;

    public EmpleadoController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var empleados = _context.Empleados.ToList();
        return View(empleados);
    }
}
