using Microsoft.AspNetCore.Mvc.Rendering;
using RepositoryPatternUnitoWorkCruds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternUnitoWorkCruds.Repositories.IRepositories
{
    public interface IDirectorRepository
    {
        IEnumerable<Director> GetAllDirectorByMovieLanguage(string language);
        IEnumerable<SelectListItem> GetListaDirectoresIDirectores();
    }
}
