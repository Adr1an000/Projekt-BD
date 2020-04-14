using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace InformacjeTurystyczne.Controllers.TabelsController
{
    public class RegionController : Controller
    {
        private readonly IRegionRepository _regionRepository;

        public RegionController(IRegionRepository regionRepository)
        {
            _regionRepository = regionRepository;
        }

        public async Task<IActionResult> Index(int? id, int? IdEntertainment)
        {
            var regions = _regionRepository.GetAllRegion();

            return View(await regions);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regions = await _regionRepository.GetRegionByID(id);
            if (regions == null)
            {
                return NotFound();
            }

            return View(regions);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRegion,Name")] Region region)
        {
            if (ModelState.IsValid)
            {
                await _regionRepository.AddRegionAsync(region);

                return RedirectToAction(nameof(Index));
            }


            return View(region);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var region = await _regionRepository.GetRegionByIDWithoutInclude(id);

            if (region == null)
            {
                return NotFound();
            }


            return View(region);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regionToUpdate = await _regionRepository.GetRegionByIDWithoutIncludeAndAsNoTracking(id);

            if (await TryUpdateModelAsync<Region>(regionToUpdate,
                    "",
                    c => c.Name))
            {
                try
                {
                    await _regionRepository.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError(String.Empty, "Nie można zapisać zmian.");
                }

                return RedirectToAction(nameof(Index));
            }

            return View(regionToUpdate);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var region = await _regionRepository.GetRegionByID(id);

            if (region == null)
            {
                return NotFound();
            }

            return View(region);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var region = await _regionRepository.GetRegionByIDWithoutIncludeAndAsNoTracking(id);
            await _regionRepository.DeleteRegionAsync(region);

            return RedirectToAction(nameof(Index));
        }
    }
}