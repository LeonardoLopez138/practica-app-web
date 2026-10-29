namespace practica_backend1.Publishing.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync(CancellationToken cancellationToken = default);
}