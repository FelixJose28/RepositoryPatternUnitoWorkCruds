using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternUnitoWorkCruds.Repositories.IRepositories
{
    public interface IUnitOfWork: IDisposable
    {
        Task commit();
    }
}
