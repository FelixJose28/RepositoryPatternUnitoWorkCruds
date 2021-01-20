using Microsoft.AspNetCore.Mvc;
using RepositoryPatternUnitoWorkCruds.Repositories.IRepositories;
using RepositoryPatternUnitoWorkCruds.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternUnitoWorkCruds.Controllers
{
    public class MoviesController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        public MoviesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }
        public IActionResult Index()
        {
            return View(_unitOfWork.MovieRepositoryGG.GetAllGeneric());
        }
    }
}
