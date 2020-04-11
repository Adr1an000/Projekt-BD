using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;
using Microsoft.AspNetCore.Mvc;

namespace InformacjeTurystyczne.Controllers.TabelsController
{
    public class PermissionShelterController : Controller
    {
        private readonly IPermissionShelterRepository _permissionShelterRepository;

        public PermissionShelterController(IPermissionShelterRepository permissionShelterRepository)
        {
            _permissionShelterRepository = permissionShelterRepository;
        }

        public IActionResult Index()
        {
            return View(_permissionShelterRepository.GetAllPermissionShelter());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PermissionShelter permissionShelter)
        {
            if (ModelState.IsValid)
            {
                _permissionShelterRepository.AddPermissionShelter(permissionShelter);
                return RedirectToAction(nameof(Index));
            }

            return View(permissionShelter);
        }

        public IActionResult Edit(int Id)
        {
            var permissionShelter = _permissionShelterRepository.GetPermissionShelterByID(Id);

            if (permissionShelter == null)
            {
                return NotFound();
            }

            return View(permissionShelter);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PermissionShelter permissionShelter)
        {
            if (ModelState.IsValid)
            {
                _permissionShelterRepository.EditPermissionShelter(permissionShelter);
                return RedirectToAction(nameof(Index));
            }

            return View(permissionShelter);
        }

        public IActionResult Delete(int Id)
        {
            var permissionShelter = _permissionShelterRepository.GetPermissionShelterByID(Id);

            if (permissionShelter == null)
            {
                return NotFound();
            }

            return View(permissionShelter);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var permissionShelter = _permissionShelterRepository.GetPermissionShelterByID(id);
            _permissionShelterRepository.DeletePermissionShelter(permissionShelter);

            return RedirectToAction(nameof(Index));
        }
    }
}