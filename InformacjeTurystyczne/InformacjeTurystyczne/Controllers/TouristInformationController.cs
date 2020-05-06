using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using InformacjeTurystyczne.Models;
using InformacjeTurystyczne.Models.ViewModels;

namespace InformacjeTurystyczne.Controllers
{
    public class TouristInformationController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new TouristInformationVM();
            var record = new InfoRecordVM();
            record.AddProperty("name", "shelter 1", "", "Schronisko 1");
            record.AddProperty("type", "shelter", "", "Schronisko");
            record.AddProperty("region", "slask", "Region", "Śląsk");
            record.AddProperty("contact", "", "kontakt", "123-456-789");
            record.AddProperty("capacity", "", "Liczba miejsc", "10");
            viewModel.Records.Add(record);
            record = new InfoRecordVM();
            record.AddProperty("name", "museum 1", "", "Muzeum 1");
            record.AddProperty("type", "museum", "", "Muzeum");
            record.AddProperty("region", "mazowsze", "Region", "Mazowsze");
            record.AddProperty("contact", "", "kontakt", "123-123-123");
            record.AddProperty("open", "", "Godziny otwarcia", "pn-pt 8:00 - 20:00; sb,nd 10:00 - 20:00");
            viewModel.Records.Add(record);

            return View(viewModel);
        }
    }
}