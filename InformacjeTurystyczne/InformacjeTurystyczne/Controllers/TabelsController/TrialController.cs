using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;
using Microsoft.AspNetCore.Mvc;

namespace InformacjeTurystyczne.Controllers.TabelsController
{
    public class TrialController : Controller
    {
        private readonly ITrialRepository _trialRepository;

        public TrialController(ITrialRepository trialRepository)
        {
            _trialRepository = trialRepository;
        }

        public IActionResult Index()
        {
            return View(_trialRepository.GetAllTrial());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Trial trial)
        {
            if (ModelState.IsValid)
            {
                _trialRepository.AddTrial(trial);
                return RedirectToAction(nameof(Index));
            }

            return View(trial);
        }

        public IActionResult Edit(int Id)
        {
            var trial = _trialRepository.GetTrialByID(Id);

            if (trial == null)
            {
                return NotFound();
            }

            return View(trial);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Trial trial)
        {
            if (ModelState.IsValid)
            {
                _trialRepository.EditTrial(trial);
                return RedirectToAction(nameof(Index));
            }

            return View(trial);
        }

        public IActionResult Delete(int Id)
        {
            var trial = _trialRepository.GetTrialByID(Id);

            if (trial == null)
            {
                return NotFound();
            }

            return View(trial);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var trial = _trialRepository.GetTrialByID(id);
            _trialRepository.DeleteTrial(trial);

            return RedirectToAction(nameof(Index));
        }
    }
}