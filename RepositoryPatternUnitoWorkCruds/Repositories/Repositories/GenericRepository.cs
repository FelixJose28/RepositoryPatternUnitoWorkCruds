using Microsoft.EntityFrameworkCore;
using RepositoryPatternUnitoWorkCruds.Models;
using RepositoryPatternUnitoWorkCruds.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternUnitoWorkCruds.Repositories.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MoviesContext _context;
        private readonly DbSet<T> _DbSet; 

        public GenericRepository(MoviesContext context)
        {
            _context = context;
            _DbSet = this._context.Set<T>();
        }
        public void AddGeneric(T entity)
        {
            _DbSet.Add(entity);
        }

        public void DeleteGeneric(T entity)
        {
            _DbSet.Remove(entity);
        }

        public IEnumerable<T> GetAllGeneric()
        {
            return _DbSet.ToList();
        }

        public T GetByIdGeneric(int id)
        {
            return _DbSet.Find(id);
        }

        public void UpdateGeneric(T entity)
        {
            _DbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
