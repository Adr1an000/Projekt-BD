using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Repository;

namespace InformacjeTurystyczne.Models.ViewModels
{
    public class TouristInformationVM
    {
        public IAttractionRepository attractionRepository { get; set; }
        public IPartyRepository partyRepository { get; set; }
        public IShelterRepository shelterRepository { get; set; }
        public ITrailRepository trailRepository { get; set; }
        public ICategoryRepository categoryRepository { get; set; }
        public IRegionRepository regionRepository { get; set; }
    }
}
