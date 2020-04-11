using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;
using Microsoft.AspNetCore.Mvc;

namespace InformacjeTurystyczne.Controllers.TabelsController
{
    public class ShelterController : Controller
    {
        private readonly IShelterRepository _shelterRepository;

        public ShelterController(IShelterRepository shelterRepository)
        {
            _shelterRepository = shelterRepository;
        }

        public IActionResult Index()
        {
            return View(_shelterRepository.GetAllShelter());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Shelter shelter)
        {
            if (ModelState.IsValid)
            {
                _shelterRepository.AddShelter(shelter);
                return RedirectToAction(nameof(Index));
            }

            return View(shelter);
        }

        public IActionResult Edit(int Id)
        {
            var shelter = _shelterRepository.GetShelterByID(Id);

            if (shelter == null)
            {
                return NotFound();
            }

            return View(shelter);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Shelter shelter)
        {
            if (ModelState.IsValid)
            {
                _shelterRepository.EditShelter(shelter);
                return RedirectToAction(nameof(Index));
            }

            return View(shelter);
        }

        public IActionResult Delete(int Id)
        {
            var shelter = _shelterRepository.GetShelterByID(Id);

            if (shelter == null)
            {
                return NotFound();
            }

            return View(shelter);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var shelter = _shelterRepository.GetShelterByID(id);
            _shelterRepository.DeleteShelter(shelter);

            return RedirectToAction(nameof(Index));
        }
    }
}