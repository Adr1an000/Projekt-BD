using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;
using Microsoft.AspNetCore.Mvc;

namespace InformacjeTurystyczne.Controllers.TabelsController
{
    public class PermissionEntertainmentController : Controller
    {
        private readonly IPermissionEntertainmentRepository _permissionEntertainmentRepository;

        public PermissionEntertainmentController(IPermissionEntertainmentRepository permissionEntertainmentRepository)
        {
            _permissionEntertainmentRepository = permissionEntertainmentRepository;
        }

        public IActionResult Index()
        {
            return View(_permissionEntertainmentRepository.GetAllPermissionEntertainment());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PermissionEntertainment permissionEntertainment)
        {
            if (ModelState.IsValid)
            {
                _permissionEntertainmentRepository.AddPermissionEntertainment(permissionEntertainment);
                return RedirectToAction(nameof(Index));
            }

            return View(permissionEntertainment);
        }

        public IActionResult Edit(int Id)
        {
            var permissionEntertainment = _permissionEntertainmentRepository.GetPermissionEntertainmentByID(Id);

            if (permissionEntertainment == null)
            {
                return NotFound();
            }

            return View(permissionEntertainment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PermissionEntertainment permissionEntertainment)
        {
            if (ModelState.IsValid)
            {
                _permissionEntertainmentRepository.EditPermissionEntertainment(permissionEntertainment);
                return RedirectToAction(nameof(Index));
            }

            return View(permissionEntertainment);
        }

        public IActionResult Delete(int Id)
        {
            var permissionEntertainment = _permissionEntertainmentRepository.GetPermissionEntertainmentByID(Id);

            if (permissionEntertainment == null)
            {
                return NotFound();
            }

            return View(permissionEntertainment);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var permissionEntertainment = _permissionEntertainmentRepository.GetPermissionEntertainmentByID(id);
            _permissionEntertainmentRepository.DeletePermissionEntertainment(permissionEntertainment);

            return RedirectToAction(nameof(Index));
        }
    }
}