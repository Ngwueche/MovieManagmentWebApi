using System.Linq.Expressions;

namespace MovieManagement.Domain.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        void Remove(T entity);
        void AdddRange(IEnumerable<T> entities);
        void RemoveRange(IEnumerable<T> entities);
    }
}
