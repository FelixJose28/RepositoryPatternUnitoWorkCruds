using RepositoryPatternUnitoWorkCruds.Models;
using RepositoryPatternUnitoWorkCruds.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternUnitoWorkCruds.Repositories.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MoviesContext _context;

        public DirectorRepository DirectorRepositoryGG { get; private set; }
        public MovieRepository MovieRepositoryGG { get; private set; }

        public UnitOfWork(MoviesContext context)
        {
            _context = context;
            DirectorRepositoryGG = new DirectorRepository(_context);
            MovieRepositoryGG = new MovieRepository(_context);
        }

        public async Task commit()
        {
            await _context.SaveChangesAsync();
            
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
