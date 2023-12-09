using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Repositories.Interfaces;

namespace MovieManagement.DataAccess.Repositories.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Actor = new ActorRepository(_context);
            Movie = new MovieRepository(_context);
            Biography = new BiographyRepository(_context);
            Genre = new GenreRepository(_context);
        }
        public IActorRepository Actor { get; private set; }
        public IMoviesRepository Movie { get; private set; }
        public IBiographyRepository Biography { get; private set; }
        public IGenreRepository Genre { get; private set; }

        public int Save()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
