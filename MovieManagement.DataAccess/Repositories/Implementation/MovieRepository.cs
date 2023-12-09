using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repositories.Interfaces;

namespace MovieManagement.DataAccess.Repositories.Implementation
{

    public class MovieRepository : GenericRepository<Movie>, IMoviesRepository
    {
        public MovieRepository(ApplicationDbContext context) : base(context) { }
    }
}
