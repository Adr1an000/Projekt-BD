using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InformacjeTurystyczne.Controllers.TabelsController
{
    public class TrailController : Controller
    {
        private readonly ITrailRepository _trailRepository;

        public TrailController(ITrailRepository trailRepository)
        {
            _trailRepository = trailRepository;
        }

        public async Task<IActionResult> Index()
        {
            var trails = _trailRepository.GetAllTrail();

            return View(await trails);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trails = await _trailRepository.GetTrailByID(id);
            if (trails == null)
            {
                return NotFound();
            }

            return View(trails);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTrail, Name, Colour, Open, Feedback, Length, Difficulty, Description")] Trail trail)
        {
            if (ModelState.IsValid)
            {
                await _trailRepository.AddTrailAsync(trail);

                return RedirectToAction(nameof(Index));
            }

           

            return View(trail);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trail = await _trailRepository.GetTrailByIDWithoutInclude(id);

            if (trail == null)
            {
                return NotFound();
            }

           

            return View(trail);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trailToUpdate = await _trailRepository.GetTrailByIDWithoutIncludeAndAsNoTracking(id);

            if (await TryUpdateModelAsync<Trail>(trailToUpdate,
                    "",
                    c=>c.Name, c => c.Colour, c=>c.Open, c=>c.Feedback, c=>c.Length, c=>c.Difficulty, c=>c.Description))
            {
                try
                {
                    await _trailRepository.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError(String.Empty, "Nie można zapisać zmian.");
                }

                return RedirectToAction(nameof(Index));
            }


            return View(trailToUpdate);
        }

       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trail = await _trailRepository.GetTrailByID(id);

            if (trail == null)
            {
                return NotFound();
            }

            return View(trail);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trail = await _trailRepository.GetTrailByIDWithoutIncludeAndAsNoTracking(id);
            await _trailRepository.DeleteTrailAsync(trail);

            return RedirectToAction(nameof(Index));
        }
    }
}