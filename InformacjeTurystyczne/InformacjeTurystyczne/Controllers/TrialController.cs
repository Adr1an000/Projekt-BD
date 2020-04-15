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
    public class TrialController : Controller
    {
        private readonly ITrialRepository _trialRepository;

        public TrialController(ITrialRepository trialRepository)
        {
            _trialRepository = trialRepository;
        }

        public async Task<IActionResult> Index()
        {
            var trials = _trialRepository.GetAllTrial();

            return View(await trials);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trials = await _trialRepository.GetTrialByID(id);
            if (trials == null)
            {
                return NotFound();
            }

            return View(trials);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTrial, Colour, Open, Feedback, Length, Difficulty, Description")] Trial trial)
        {
            if (ModelState.IsValid)
            {
                await _trialRepository.AddTrialAsync(trial);

                return RedirectToAction(nameof(Index));
            }

           

            return View(trial);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trial = await _trialRepository.GetTrialByIDWithoutInclude(id);

            if (trial == null)
            {
                return NotFound();
            }

           

            return View(trial);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trialToUpdate = await _trialRepository.GetTrialByIDWithoutIncludeAndAsNoTracking(id);

            if (await TryUpdateModelAsync<Trial>(trialToUpdate,
                    "",
                    c => c.Colour, c=>c.Open, c=>c.Feedback, c=>c.Length, c=>c.Difficulty, c=>c.Description))
            {
                try
                {
                    await _trialRepository.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError(String.Empty, "Nie można zapisać zmian.");
                }

                return RedirectToAction(nameof(Index));
            }


            return View(trialToUpdate);
        }

       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trial = await _trialRepository.GetTrialByID(id);

            if (trial == null)
            {
                return NotFound();
            }

            return View(trial);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trial = await _trialRepository.GetTrialByIDWithoutIncludeAndAsNoTracking(id);
            await _trialRepository.DeleteTrialAsync(trial);

            return RedirectToAction(nameof(Index));
        }
    }
}