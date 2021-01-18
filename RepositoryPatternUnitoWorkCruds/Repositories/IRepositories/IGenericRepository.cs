using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternUnitoWorkCruds.Repositories.IRepositories
{
    public interface IGenericRepository<T> where T: class
    {
        IEnumerable<T> GetAllGeneric();
        T GetByIdGeneric(int id);
        void AddGeneric(T entity);
        void UpdateGeneric(T entity);
        void DeleteGeneric(T entity);
    }
}
