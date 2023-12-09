namespace MovieManagement.Domain.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IActorRepository Actor { get; }
        public IBiographyRepository Biography { get; }
        public IMoviesRepository Movie { get; }
        public IGenreRepository Genre { get; }

        int Save();
    }
}
