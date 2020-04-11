using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    interface IRegionRepository
    {
        IEnumerable<Region> GetAllRegion();
        Region GetMessageByID(int regionID);

        void AddRegion(Region region);
        void EditRegion(Region region);
        void DeleteRegion(Region region);
    }
}
