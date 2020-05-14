using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.ViewModels;

namespace InformacjeTurystyczne.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly IMessageRepository _messageRepository;

        public NotificationsController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public IActionResult Index()
        {
            var viewModel = new NotificationsVM();
            viewModel.messages = _messageRepository;

            return View(viewModel);
        }
    }
}