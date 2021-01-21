using Microsoft.AspNetCore.Mvc;
using RepositoryPatternUnitoWorkCruds.Models;
using RepositoryPatternUnitoWorkCruds.Models.ViewModel;
using RepositoryPatternUnitoWorkCruds.Repositories.IRepositories;
using RepositoryPatternUnitoWorkCruds.Repositories.Repositories;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        [HttpGet]
        public IActionResult Index()
        {
            return View(_unitOfWork.movieRepositoryGG.GetAllGeneric());
        }
        [HttpGet]
        public IActionResult Create()
        {
            MovieVM vm = new MovieVM()
            {
                Movie = new Movie(),
                ListaDirector = _unitOfWork.directorRepositoryGG.GetListaDirectoresIDirectores(),
                ListaGenero = _unitOfWork.generoRepository.GetListaGenerosIGeneros()
            };
            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.movieRepositoryGG.AddGeneric(movie);
                await _unitOfWork.commit();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }
    }
}
