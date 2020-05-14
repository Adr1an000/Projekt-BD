using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using InformacjeTurystyczne.Models;
using InformacjeTurystyczne.Models.ViewModels;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Repository;
using System.Dynamic;

namespace InformacjeTurystyczne.Controllers
{
    public class TouristInformationController : Controller
    {
        private readonly IAttractionRepository _attractionRepository;
        private readonly IPartyRepository _partyRepository;
        private readonly IShelterRepository _shelterRepository;
        private readonly ITrailRepository _trailRepository;
        private readonly IRegionRepository _regionRepository;


        public TouristInformationController(
            IAttractionRepository attractionRepository,
            IPartyRepository partyRepository,
            IShelterRepository shelterRepository,
            ITrailRepository trailRepository,
            IRegionRepository regionRepository
            )
        {
            _attractionRepository = attractionRepository;
            _partyRepository = partyRepository;
            _regionRepository = regionRepository;
            _shelterRepository = shelterRepository;
            _trailRepository = trailRepository;
        }
        
        public IActionResult Index()
        {
            var viewModel = new TouristInformationVM();
            viewModel.attractions = _attractionRepository;
            viewModel.parties = _partyRepository;
            viewModel.shelters = _shelterRepository;
            viewModel.trails = _trailRepository;
            viewModel.regions = _regionRepository;

            return View(viewModel);
        }
    }
}