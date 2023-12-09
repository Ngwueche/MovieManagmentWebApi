using Microsoft.EntityFrameworkCore;
using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repositories.Interfaces;

namespace MovieManagement.DataAccess.Repositories.Implementation
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(ApplicationDbContext context) : base(context) { }

        public IEnumerable<Actor> GetActorsWithMovies()
        {
            var acttorsWithMovies = _context.Actors.Include(u => u.Movies).ToList();
            return acttorsWithMovies;
        }
    }
}
