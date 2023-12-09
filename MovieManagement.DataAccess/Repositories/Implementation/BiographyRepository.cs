using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repositories.Interfaces;

namespace MovieManagement.DataAccess.Repositories.Implementation
{
    public class BiographyRepository : GenericRepository<Biography>, IBiographyRepository
    {
        public BiographyRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
