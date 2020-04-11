using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;
using Microsoft.AspNetCore.Mvc;

namespace InformacjeTurystyczne.Controllers.TabelsController
{
    public class RegionController : Controller
    {
        private readonly IRegionRepository _regionRepository;

        public RegionController(IRegionRepository regionRepository)
        {
            _regionRepository = regionRepository;
        }

        public IActionResult Index()
        {
            return View(_regionRepository.GetAllRegion());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Region region)
        {
            if (ModelState.IsValid)
            {
                _regionRepository.AddRegion(region);
                return RedirectToAction(nameof(Index));
            }

            return View(region);
        }

        public IActionResult Edit(int Id)
        {
            var region = _regionRepository.GetRegionByID(Id);

            if (region == null)
            {
                return NotFound();
            }

            return View(region);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Region region)
        {
            if (ModelState.IsValid)
            {
                _regionRepository.EditRegion(region);
                return RedirectToAction(nameof(Index));
            }

            return View(region);
        }

        public IActionResult Delete(int Id)
        {
            var region = _regionRepository.GetRegionByID(Id);

            if (region == null)
            {
                return NotFound();
            }

            return View(region);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var region = _regionRepository.GetRegionByID(id);
            _regionRepository.DeleteRegion(region);

            return RedirectToAction(nameof(Index));
        }
    }
}