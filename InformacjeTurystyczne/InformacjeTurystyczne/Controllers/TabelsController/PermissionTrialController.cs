using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;
using Microsoft.AspNetCore.Mvc;

namespace InformacjeTurystyczne.Controllers.TabelsController
{
    public class PermissionTrialController : Controller
    {
        private readonly IPermissionTrialRepository _permissionTrialRepository;

        public PermissionTrialController(IPermissionTrialRepository permissionTrialRepository)
        {
            _permissionTrialRepository = permissionTrialRepository;
        }

        public IActionResult Index()
        {
            return View(_permissionTrialRepository.GetAllPermissionTrial());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PermissionTrial permissionTrial)
        {
            if (ModelState.IsValid)
            {
                _permissionTrialRepository.AddPermissionTrial(permissionTrial);
                return RedirectToAction(nameof(Index));
            }

            return View(permissionTrial);
        }

        public IActionResult Edit(int Id)
        {
            var permissionTrial = _permissionTrialRepository.GetPermissionTrialByID(Id);

            if (permissionTrial == null)
            {
                return NotFound();
            }

            return View(permissionTrial);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PermissionTrial permissionTrial)
        {
            if (ModelState.IsValid)
            {
                _permissionTrialRepository.EditPermissionTrial(permissionTrial);
                return RedirectToAction(nameof(Index));
            }

            return View(permissionTrial);
        }

        public IActionResult Delete(int Id)
        {
            var permissionTrial = _permissionTrialRepository.GetPermissionTrialByID(Id);

            if (permissionTrial == null)
            {
                return NotFound();
            }

            return View(permissionTrial);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var permissionTrial = _permissionTrialRepository.GetPermissionTrialByID(id);
            _permissionTrialRepository.DeletePermissionTrial(permissionTrial);

            return RedirectToAction(nameof(Index));
        }
    }
}