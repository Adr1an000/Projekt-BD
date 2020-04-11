using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAllRegion();
        Region GetRegionByID(int regionID);

        void AddRegion(Region region);
        void EditRegion(Region region);
        void DeleteRegion(Region region);
    }
}
