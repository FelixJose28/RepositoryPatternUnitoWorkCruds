using RepositoryPatternUnitoWorkCruds.Models;
using RepositoryPatternUnitoWorkCruds.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternUnitoWorkCruds.Repositories.Repositories
{
    public class DirectorRepository : IGenericRepository<Director>, IDirectorRepository
    {
        public void AddGeneric(Director entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteGeneric(Director entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Director> GetAllDirectorByMovieLanguage(string language)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Director> GetAllGeneric()
        {
            throw new NotImplementedException();
        }

        public Director GetByIdGeneric(int id)
        {
            throw new NotImplementedException();
        }


        public void UpdateGeneric(Director entity)
        {
            throw new NotImplementedException();
        }
    }
}
