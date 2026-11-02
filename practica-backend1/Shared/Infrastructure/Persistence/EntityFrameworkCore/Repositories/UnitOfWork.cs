using practica_backend1.Publishing.Shared.Domain.Repositories;
using practica_backend1.Publishing.Shared.Infrastructure.Persistence.EntityFrameworkCore.Configuration;

namespace practica_backend1.Publishing.Shared.Infrastructure.Persistence.EntityFrameworkCore.Repositories;

/// <summary>
///     Implements the unit of work pattern to manage atomic database transactions across repositories.
/// </summary>
/// <param name="context">The application database context.</param>
public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    /// <inheritdoc />
    public async Task CompleteAsync(CancellationToken cancellationToken = default)
    {
        await context.SaveChangesAsync(cancellationToken);
    }
}