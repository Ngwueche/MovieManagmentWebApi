using MovieManagement.Domain.Entities;

namespace MovieManagement.Domain.Repositories.Interfaces
{
    public interface IActorRepository : IGenericRepository<Actor>
    {
        IEnumerable<Actor> GetActorsWithMovies();
    }
}
