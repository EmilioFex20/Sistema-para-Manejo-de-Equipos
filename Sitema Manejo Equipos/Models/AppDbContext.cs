using Microsoft.EntityFrameworkCore;
using Sitema_Manejo_Equipos.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<empleado> Empleados { get; set; }
    public DbSet<proyecto> Proyectos { get; set; }
    public DbSet<alumno> Alumnos { get; set; }
    public DbSet<laboratorio> Laboratorios { get; set; }
    public DbSet<equipo> Equipos { get; set; }
    public DbSet<alerta> Alertas { get; set; }
    public DbSet<prestamo> Prestamos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<empleado>().ToTable("empleado");
        modelBuilder.Entity<alumno>().ToTable("alumno");
        modelBuilder.Entity<alerta>().ToTable("alertas");
        modelBuilder.Entity<equipo>().ToTable("equipo");
        modelBuilder.Entity<laboratorio>().ToTable("laboratorio");
        modelBuilder.Entity<prestamo>().ToTable("prestamo");
        modelBuilder.Entity<proyecto>().ToTable("proyecto");

        modelBuilder.Entity<alerta>()
            .HasKey(a => new { a.id_equipo, a.id_alerta });


        modelBuilder.Entity<prestamo>()
            .HasOne(p => p.EmpleadoQueSolicita)
            .WithMany(e => e.PrestamosSolicitados)
            .HasForeignKey(p => p.empleado_solicita)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<prestamo>()
            .HasOne(p => p.EmpleadoQueAutoriza)
            .WithMany(e => e.PrestamosAutorizados)
            .HasForeignKey(p => p.empleado_autoriza)
            .OnDelete(DeleteBehavior.Restrict);
    }

}
