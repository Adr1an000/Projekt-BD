using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using InformacjeTurystyczne.Models;
using InformacjeTurystyczne.Models.ViewModels;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Repository;

namespace InformacjeTurystyczne.Controllers
{
    public class TouristInformationController : Controller
    {
        private readonly IAttractionRepository _attractionRepository;
    //    private readonly ICategoryRepository _categoryRepository;
    //    private readonly IMessageRepository _messageRepository;
        private readonly IPartyRepository _partyRepository;
     //   private readonly IRegionRepository _regionRepository;
        private readonly IShelterRepository _shelterRepository;
    //    private readonly ISubscriptionRepository _subscriptionRepository;
        private readonly ITrailRepository _trailRepository;

        
        public TouristInformationController(
            IAttractionRepository attractionRepository,
        //    ICategoryRepository categoryRepository,
        //    IMessageRepository messageRepository,
            IPartyRepository partyRepository,
        //    IRegionRepository regionRepository,
            IShelterRepository shelterRepository,
        //    ISubscriptionRepository subscriptionRepository,
            ITrailRepository trailRepository)
        {
            _attractionRepository = attractionRepository;
        //    _categoryRepository = categoryRepository;
        //    _messageRepository = messageRepository;
            _partyRepository = partyRepository;
        //    _regionRepository = regionRepository;
            _shelterRepository = shelterRepository;
        //    _subscriptionRepository = subscriptionRepository;
            _trailRepository = trailRepository;
        }
        
        public IActionResult Index()
        {
            var viewModel = new TouristInformationVM();
            InfoRecordVM record;
            
            foreach (var attraction in _attractionRepository.GetAllAttractionToUser())
            {
                record = new InfoRecordVM();

                record.AddProperty("atrakcja", attraction.AttractionType, "Atrakcja", attraction.AttractionType);
                record.AddProperty("nazwa", "", "Temat atrakcji", attraction.Name);
                record.AddProperty("opis", "", "Opis", attraction.Description);

                record.AddProperty("region", "region", "", attraction.Region.Name ?? "");

                viewModel.Records.Add(record);
            }
            
            foreach(var party in _partyRepository.GetAllPartyToUser())
            {
                record = new InfoRecordVM();

                record.AddProperty("impreza", "", "Impreza", party.Name);
                record.AddProperty("lokalizacja", "", "Lokalizacja", party.PlaceDescription);
                record.AddProperty("opis imprezy", "", "Szczegóły", party.Description);
                record.AddProperty("aktualność", "aktualne", "Aktualność", party.UpToDate ? "aktualna" : "nieaktualna");

                record.AddProperty("region", "region", "", party.Region.Name ?? "");

                viewModel.Records.Add(record);
            }

            foreach(var shelter in _shelterRepository.GetAllShelterToUser())
            {
                record = new InfoRecordVM();

                record.AddProperty("schronisko", "", "Schronisko", shelter.Name);
                record.AddProperty("max miejsc", "", "Pojemność", shelter.MaxPlaces.ToString());
                record.AddProperty("ilosc miejsc", "", "Zajęte miejsca", shelter.Places.ToString());
                record.AddProperty("otwartość", "otwarte", "", shelter.IsOpen ? "otwarte" : "zamknięte");
                record.AddProperty("opis schroniska", "", "Opis", shelter.Description);
                record.AddProperty("telefon", "", "Numer telefonu", shelter.PhoneNumber);

                record.AddProperty("region", "region", "", shelter.Region.Name ?? "");

                viewModel.Records.Add(record);
            }

            foreach(var trail in _trailRepository.GetAllTrailToUser())
            {
                record = new InfoRecordVM();

                record.AddProperty("szlak", "", "Szlak", trail.Name);
                record.AddProperty("kolor", "kolor", "Kolor", trail.Colour);
                record.AddProperty("otwartość", "otwarte", "", trail.Open ? "otwarty" : "zamknięty");
                record.AddProperty("przyczyna", "", "Przyczyna zamknięcia", trail.Feedback);
                record.AddProperty("długość", "", "Długość szlaku", trail.Length.ToString() + "m");
                record.AddProperty("trudność", "trudność", "Poziom trudności", trail.Difficulty.ToString());
                record.AddProperty("opis", "", "Opis szlaku", trail.Description);

                viewModel.Records.Add(record);
            }

            return View(viewModel);
        }
    }
}