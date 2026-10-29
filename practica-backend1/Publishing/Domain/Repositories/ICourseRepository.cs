using practica_backend1.Publishing.Domain.Model.Aggregate;
using practica_backend1.Publishing.Domain.Model.ValueObject;
using practica_backend1.Publishing.Shared.Domain.Repositories;

namespace practica_backend1.Publishing.Domain.Repositories;

public interface ICourseRepository : IBaseRepository<Course>
{
    Task<Course?> FindCodeAsync(CourseCode code, CancellationToken cancellationToken = default);
}

