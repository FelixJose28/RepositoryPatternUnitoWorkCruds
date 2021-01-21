using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternUnitoWorkCruds.Models.ViewModel
{
    public class MovieVM
    {
        public Movie Movie { get; set; }
        public IEnumerable<SelectListItem> ListaGenero { get; set; }
        public IEnumerable<SelectListItem> ListaDirector { get; set; }
    }
}
