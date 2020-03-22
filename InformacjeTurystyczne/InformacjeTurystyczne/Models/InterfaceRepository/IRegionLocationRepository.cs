using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    interface IRegionLocationRepository
    {
        interface ITrialRepository
        {
            IEnumerable<RegionLocation> GetAllRegionLocation();
            RegionLocation GetRegionLocationByID(int regionLocationlID);
        }
    }
}
