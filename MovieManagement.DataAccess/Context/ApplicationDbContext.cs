using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Entities;

namespace MovieManagement.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Biographies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                        new Actor { Id = 1, FirstName = "Genevive", LastName = "Nnaji" },
                        new Actor { Id = 2, FirstName = "Emeka", LastName = "Ike" },
                        new Actor { Id = 3, FirstName = "Mercy", LastName = "Ekeh" }
                );

            modelBuilder.Entity<Movie>().HasData(
                        new Movie { Id = 1, Name = "Love Me", Description = "Naija Romance", ActorId = 1 },
                        new Movie { Id = 2, Name = "Love Me", Description = "Naija Romance", ActorId = 2 },
                        new Movie { Id = 3, Name = "Wicked Maiden", Description = "Return of the Princess", ActorId = 1 }


                );

            //base.OnModelCreating(modelBuilder);
        }
    }
}
