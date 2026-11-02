using practica_backend1.Publishing.Domain.Model.Aggregate;
using practica_backend1.Publishing.Domain.Model.ValueObject;
using practica_backend1.Publishing.Shared.Infrastructure.Persistence.EntityFrameworkCore.Configuration.Extensions;
using practica_backend1.Publishing.Shared.Infrastructure.Persistence.EntityFrameworkCore.Interceptors;
using Microsoft.EntityFrameworkCore;

namespace practica_backend1.Publishing.Shared.Infrastructure.Persistence.EntityFrameworkCore.Configuration;

/// <summary>
///     Represents the Entity Framework Core database context for the CatchUp Platform API.
/// </summary>
/// <param name="options">The options to be used by the <see cref="DbContext"/>.</param>
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    /// <inheritdoc />
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.AddInterceptors(new AuditableEntityInterceptor());
        base.OnConfiguring(builder);
    }

    /// <inheritdoc />
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Course>().HasKey(f => f.id);
        builder.Entity<Course>().Property(f => f.id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Course>().Property(f => f.Code)
            .HasConversion(valueObject => valueObject.Value, value => new CourseCode(value))
            .IsRequired();
        builder.Entity<Course>().Property(f => f.Title)
            .HasConversion(valueObject => valueObject.Value, value => new CourseTitle(value))
            .IsRequired();
        builder.Entity<Course>()
            .HasIndex(f => new { f.Title, f.Code }).IsUnique();
        
        builder.UseSnakeCaseNamingConvention();
    }
}