using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Repository;
using InformacjeTurystyczne.Models.Tabels;
using Microsoft.AspNetCore.Mvc;

namespace InformacjeTurystyczne.Controllers.TabelsController
{
    public class EntertainmentController : Controller
    {
        private readonly IEntertainmentRepository _entertainmentRepository;

        public EntertainmentController(IEntertainmentRepository entertainmentRepository)
        {
            _entertainmentRepository = entertainmentRepository;
        }

        public IActionResult Index()
        {
            return View(_entertainmentRepository.GetAllEntertainment());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Entertainment entertainment)
        {
            if (ModelState.IsValid)
            {
                _entertainmentRepository.AddEntertainment(entertainment);
                return RedirectToAction(nameof(Index));
            }

            return View(entertainment);
        }

        public IActionResult Edit(int Id)
        {
            var entertainment = _entertainmentRepository.GetEntertainmentByID(Id);

            if (entertainment == null)
            {
                return NotFound();
            }

            return View(entertainment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Entertainment entertainment)
        {
            if (ModelState.IsValid)
            {
                _entertainmentRepository.EditEntertainment(entertainment);
                return RedirectToAction(nameof(Index));
            }

            return View(entertainment);
        }

        public IActionResult Delete(int Id)
        {
            var entertainment = _entertainmentRepository.GetEntertainmentByID(Id);

            if (entertainment == null)
            {
                return NotFound();
            }

            return View(entertainment);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var entertainment = _entertainmentRepository.GetEntertainmentByID(id);
            _entertainmentRepository.DeleteEntertainment(entertainment);

            return RedirectToAction(nameof(Index));
        }
    }
}