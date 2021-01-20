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

        public DirectorRepository directorRepositoryGG { get; private set; }
        public MovieRepository movieRepositoryGG { get; private set; }
        public GeneroRepository generoRepository { get; private set; }


        public UnitOfWork(MoviesContext context)
        {
            _context = context;
            directorRepositoryGG = new DirectorRepository(_context);
            movieRepositoryGG = new MovieRepository(_context);
            generoRepository = new GeneroRepository(_context);
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
