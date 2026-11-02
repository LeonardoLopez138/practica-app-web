using Microsoft.EntityFrameworkCore;
using practica_backend1.Publishing.Domain.Model.Aggregate;
namespace practica_backend1.Publishing.Interfaces.EFC.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Course> Courses { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Aquí configuraremos las tablas, columnas, llaves primarias y restricciones (Fluent API)
        modelBuilder.Entity<Course>().ToTable("Courses");
        modelBuilder.Entity<Course>().HasKey(c => c.id);
        
        // Ejemplo de configuración de propiedades si lo necesitas:
        modelBuilder.Entity<Course>().Property(c => c.id).IsRequired().ValueGeneratedOnAdd();
        modelBuilder.Entity<Course>().Property(c => c.Code).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Course>().Property(c => c.Title).IsRequired().HasMaxLength(150);
    }
}