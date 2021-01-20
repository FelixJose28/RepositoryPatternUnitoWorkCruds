using RepositoryPatternUnitoWorkCruds.Models;
using RepositoryPatternUnitoWorkCruds.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternUnitoWorkCruds.Repositories.Repositories
{
    public class DirectorRepository : GenericRepository<Director>, IDirectorRepository
    {

        private readonly MoviesContext _context;
        public DirectorRepository(MoviesContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<Director> GetAllDirectorByMovieLanguage(string language)
        {
                return null;
            //return (from m in this._context.Movies.Where(m => m.Language == language));
        }
    }
}
