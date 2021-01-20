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
    public class DirectorsController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        public DirectorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }
        public IActionResult Index()
        {
            return View(_unitOfWork.DirectorRepositoryGG.GetAllGeneric());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Director director)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.DirectorRepositoryGG.AddGeneric(director);
                await _unitOfWork.commit();
                return RedirectToAction(nameof(Index));
            }
            return View(director);
        }
    }
}
