using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Repository;
using InformacjeTurystyczne.Models.Tabels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace InformacjeTurystyczne.Controllers.TabelsController
{
    public class EntertainmentController : Controller
    {
        private readonly IEntertainmentRepository _entertainmentRepository;

        public EntertainmentController(IEntertainmentRepository entertainmentRepository)
        {
            _entertainmentRepository = entertainmentRepository;
        }

        public async Task<IActionResult> Index()
        {
            var entertainments = _entertainmentRepository.GetAllEntertainment();

            return View(await entertainments);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entertainments = await _entertainmentRepository.GetEntertainmentByID(id);
            if (entertainments == null)
            {
                return NotFound();
            }

            return View(entertainments);
        }

        public IActionResult Create()
        {
            PopulateEntertainment();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEntertainment,Name,PlaceDescription,Description,UpToDate,IdRegion")] Entertainment entertainment)
        {
            if (ModelState.IsValid)
            {
                await _entertainmentRepository.AddEntertainmentAsync(entertainment);

                return RedirectToAction(nameof(Index));
            }

            PopulateEntertainment(entertainment.IdRegion);

            return View(entertainment);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entertainment = await _entertainmentRepository.GetEntertainmentByIDWithoutInclude(id);

            if (entertainment == null)
            {
                return NotFound();
            }

            PopulateEntertainment(entertainment.IdRegion);

            return View(entertainment);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entertainmentToUpdate = await _entertainmentRepository.GetEntertainmentByIDWithoutIncludeAndAsNoTracking(id);

            if (await TryUpdateModelAsync<Entertainment>(entertainmentToUpdate,
                    "",
                    c => c.Name, c => c.PlaceDescription, c => c.Description, c => c.UpToDate, c => c.IdRegion))
            {
                try
                {
                    await _entertainmentRepository.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError(String.Empty, "Nie można zapisać zmian.");
                }

                return RedirectToAction(nameof(Index));
            }

            PopulateEntertainment(entertainmentToUpdate.IdRegion);
            return View(entertainmentToUpdate);
        }

        public void PopulateEntertainment(object selectedRegion = null)
        {

            var regionQuery = from e in _entertainmentRepository.GetAllRegionAsNoTracking()
                              orderby e.Name
                              select e;

            ViewBag.IdRegion = new SelectList(regionQuery, "IdRegion", "Name", selectedRegion);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entertainment = await _entertainmentRepository.GetEntertainmentByID(id);

            if (entertainment == null)
            {
                return NotFound();
            }

            return View(entertainment);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _entertainmentRepository.GetEntertainmentByIDWithoutIncludeAndAsNoTracking(id);
            await _entertainmentRepository.DeleteEntertainmentAsync(course);

            return RedirectToAction(nameof(Index));
        }
    }
}