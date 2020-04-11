using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;
using Microsoft.AspNetCore.Mvc;

namespace InformacjeTurystyczne.Controllers.TabelsController
{
    public class SubscriptionController : Controller
    {
        private readonly ISubscriptionRepository _subscriptionRepository;

        public SubscriptionController(ISubscriptionRepository subscriptionRepository)
        {
            _subscriptionRepository = subscriptionRepository;
        }

        public IActionResult Index()
        {
            return View(_subscriptionRepository.GetAllSubscription());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                _subscriptionRepository.AddSubscription(subscription);
                return RedirectToAction(nameof(Index));
            }

            return View(subscription);
        }

        public IActionResult Edit(int Id)
        {
            var subscription = _subscriptionRepository.GetSubscriptionByID(Id);

            if (subscription == null)
            {
                return NotFound();
            }

            return View(subscription);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                _subscriptionRepository.EditSubscription(subscription);
                return RedirectToAction(nameof(Index));
            }

            return View(subscription);
        }

        public IActionResult Delete(int Id)
        {
            var subscription = _subscriptionRepository.GetSubscriptionByID(Id);

            if (subscription == null)
            {
                return NotFound();
            }

            return View(subscription);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var subscription = _subscriptionRepository.GetSubscriptionByID(id);
            _subscriptionRepository.DeleteSubscription(subscription);

            return RedirectToAction(nameof(Index));
        }
    }
}