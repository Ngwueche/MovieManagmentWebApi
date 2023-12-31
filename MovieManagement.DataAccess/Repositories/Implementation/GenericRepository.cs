﻿using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Repositories.Interfaces;
using System.Linq.Expressions;

namespace MovieManagement.DataAccess.Repositories.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        public readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public T Add(T entity)
        {
            var result = _context.Set<T>().Add(entity);

            if (result is not null) return result.Entity;
            return null;
        }

        public void AdddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
    }
}

