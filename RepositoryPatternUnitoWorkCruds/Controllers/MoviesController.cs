using Microsoft.AspNetCore.Mvc;
using RepositoryPatternUnitoWorkCruds.Models;
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.MovieRepositoryGG.AddGeneric(movie);
            }
            return View(movie);
        }
    }
}
