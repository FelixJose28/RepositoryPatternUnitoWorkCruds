using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternUnitoWorkCruds.Repositories.IRepositories
{
    public interface IGeneroRepository
    {
        void Nothing();
        IEnumerable<SelectListItem> GetListaGenerosIGeneros();
    }
}
