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
            return View(_unitOfWork.directorRepositoryGG.GetAllGeneric());
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
                _unitOfWork.directorRepositoryGG.AddGeneric(director);
                await _unitOfWork.commit();
                return RedirectToAction(nameof(Index));
            }
            return View(director);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var objectData = _unitOfWork.directorRepositoryGG.GetByIdGeneric(id);
            if (objectData != null)
            {
                return View(objectData);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(Director director)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.directorRepositoryGG.UpdateGeneric(director);
                await _unitOfWork.commit();
                return RedirectToAction(nameof(Index));
            }
            return View(director);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var objectData = _unitOfWork.directorRepositoryGG.GetByIdGeneric(id);
            if (objectData != null)
            {
                return View(objectData);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(Director director)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.directorRepositoryGG.DeleteGeneric(director);
                await _unitOfWork.commit();
                return RedirectToAction(nameof(Index));
            }
            return View(director);
        }
    }
}