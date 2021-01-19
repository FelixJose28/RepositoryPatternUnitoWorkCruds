using RepositoryPatternUnitoWorkCruds.Models;
using RepositoryPatternUnitoWorkCruds.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternUnitoWorkCruds.Repositories.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        private readonly MoviesContext _context;
        public MovieRepository(MoviesContext context): base(context)
        {
            _context = context;
        }

        public IEnumerable<Movie> GetTopTenInAYear(int year, int count)
        {
            return (from m in this._context.Movies
                    orderby m.Rating descending
                    where m.ReleaseDate.Equals(year)
                    select m).Take(count); 
        }
    }
}
