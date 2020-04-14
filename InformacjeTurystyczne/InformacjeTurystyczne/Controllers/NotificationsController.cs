using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InformacjeTurystyczne.Controllers
{
    public class NotificationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}