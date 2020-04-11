using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;
using Microsoft.AspNetCore.Mvc;

namespace InformacjeTurystyczne.Controllers.TabelsController
{
    public class MessageController : Controller
    {
        private readonly IMessageRepository _messageRepository;

        public MessageController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public IActionResult Index()
        {
            return View(_messageRepository.GetAllMesage());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Message message)
        {
            if (ModelState.IsValid)
            {
                _messageRepository.AddMessage(message);
                return RedirectToAction(nameof(Index));
            }

            return View(message);
        }

        public IActionResult Edit(int Id)
        {
            var message = _messageRepository.GetMessageByID(Id);

            if (message == null)
            {
                return NotFound();
            }

            return View(message);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Message message)
        {
            if (ModelState.IsValid)
            {
                _messageRepository.EditMessage(message);
                return RedirectToAction(nameof(Index));
            }

            return View(message);
        }

        public IActionResult Delete(int Id)
        {
            var message = _messageRepository.GetMessageByID(Id);

            if (message == null)
            {
                return NotFound();
            }

            return View(message);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var message = _messageRepository.GetMessageByID(id);
            _messageRepository.DeleteMessage(message);

            return RedirectToAction(nameof(Index));
        }
    }
}