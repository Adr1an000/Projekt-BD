using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;
using Microsoft.AspNetCore.Mvc;

namespace InformacjeTurystyczne.Controllers.TabelsController
{
    public class RegionLocationController : Controller
    {
        private readonly IRegionLocationRepository _regionLocationRepository;

        public RegionLocationController(IRegionLocationRepository regionLocationRepository)
        {
            _regionLocationRepository = regionLocationRepository;
        }

        public IActionResult Index()
        {
            return View(_regionLocationRepository.GetAllRegionLocation());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RegionLocation regionLocation)
        {
            if (ModelState.IsValid)
            {
                _regionLocationRepository.AddRegionLocation(regionLocation);
                return RedirectToAction(nameof(Index));
            }

            return View(regionLocation);
        }

        public IActionResult Edit(int Id)
        {
            var regionLocation = _regionLocationRepository.GetRegionLocationByID(Id);

            if (regionLocation == null)
            {
                return NotFound();
            }

            return View(regionLocation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(RegionLocation regionLocation)
        {
            if (ModelState.IsValid)
            {
                _regionLocationRepository.EditRegionLocation(regionLocation);
                return RedirectToAction(nameof(Index));
            }

            return View(regionLocation);
        }

        public IActionResult Delete(int Id)
        {
            var regionLocation = _regionLocationRepository.GetRegionLocationByID(Id);

            if (regionLocation == null)
            {
                return NotFound();
            }

            return View(regionLocation);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var regionLocation = _regionLocationRepository.GetRegionLocationByID(id);
            _regionLocationRepository.DeleteRegionLocation(regionLocation);

            return RedirectToAction(nameof(Index));
        }
    }
}