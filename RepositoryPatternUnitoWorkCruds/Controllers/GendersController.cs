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
    public class GendersController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        public GendersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }
        public IActionResult Index()
        {
            return View(_unitOfWork.generoRepository.GetAllGeneric());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Genero genero)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.generoRepository.AddGeneric(genero);
                await _unitOfWork.commit();
                return RedirectToAction(nameof(Index));
            }
            return View(genero);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var objectData = _unitOfWork.generoRepository.GetByIdGeneric(id);
            if (objectData != null)
            {
                return View(objectData);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(Genero genero)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.generoRepository.UpdateGeneric(genero);
                await _unitOfWork.commit();
                return RedirectToAction(nameof(Index));
            }
            return View(genero);
        }
    }
}
