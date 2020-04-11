using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    interface IRegionLocationRepository
    {
            IEnumerable<RegionLocation> GetAllRegionLocation();
            RegionLocation GetRegionLocationByID(int regionLocationlID);

            void AddRegionLocation(RegionLocation regionLocation);
            void EditRegionLocation(RegionLocation regionLocation);
            void DeleteRegionLocation(RegionLocation regionLocation);
    }
}
