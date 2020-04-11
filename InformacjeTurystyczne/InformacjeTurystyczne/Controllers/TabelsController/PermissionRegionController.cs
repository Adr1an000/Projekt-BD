using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;
using Microsoft.AspNetCore.Mvc;

namespace InformacjeTurystyczne.Controllers.TabelsController
{
    public class PermissionRegionController : Controller
    {
        private readonly IPermissionRegionRepository _permissionRegionRepository;

        public PermissionRegionController(IPermissionRegionRepository permissionRegionRepository)
        {
            _permissionRegionRepository = permissionRegionRepository;
        }

        public IActionResult Index()
        {
            return View(_permissionRegionRepository.GetAllPermissionRegion());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PermissionRegion permissionRegion)
        {
            if (ModelState.IsValid)
            {
                _permissionRegionRepository.AddPermissionRegion(permissionRegion);
                return RedirectToAction(nameof(Index));
            }

            return View(permissionRegion);
        }

        public IActionResult Edit(int Id)
        {
            var permissionRegion = _permissionRegionRepository.GetPermissionRegionByID(Id);

            if (permissionRegion == null)
            {
                return NotFound();
            }

            return View(permissionRegion);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PermissionRegion permissionRegion)
        {
            if (ModelState.IsValid)
            {
                _permissionRegionRepository.EditPermissionRegion(permissionRegion);
                return RedirectToAction(nameof(Index));
            }

            return View(permissionRegion);
        }

        public IActionResult Delete(int Id)
        {
            var permissionRegion = _permissionRegionRepository.GetPermissionRegionByID(Id);

            if (permissionRegion == null)
            {
                return NotFound();
            }

            return View(permissionRegion);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var permissionRegion = _permissionRegionRepository.GetPermissionRegionByID(id);
            _permissionRegionRepository.DeletePermissionRegion(permissionRegion);

            return RedirectToAction(nameof(Index));
        }
    }
}