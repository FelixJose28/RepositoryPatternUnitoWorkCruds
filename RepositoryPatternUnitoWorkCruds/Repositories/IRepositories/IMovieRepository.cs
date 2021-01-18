using RepositoryPatternUnitoWorkCruds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternUnitoWorkCruds.Repositories.IRepositories
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetTopTenInAYear(int year, int count);
    }
}
