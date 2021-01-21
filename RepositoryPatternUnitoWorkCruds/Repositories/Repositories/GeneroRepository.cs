using Microsoft.AspNetCore.Mvc.Rendering;
using RepositoryPatternUnitoWorkCruds.Models;
using RepositoryPatternUnitoWorkCruds.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternUnitoWorkCruds.Repositories.Repositories
{
    public class GeneroRepository : GenericRepository<Genero>, IGeneroRepository
    {
        private readonly MoviesContext _context;
        public GeneroRepository(MoviesContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetListaGenerosIGeneros()
        {
            return _context.Generos.Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
        }

        public void Nothing()
        {
            throw new NotImplementedException();
        }
    }
}
