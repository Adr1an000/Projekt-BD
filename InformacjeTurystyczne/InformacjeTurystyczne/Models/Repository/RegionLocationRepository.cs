using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Repository
{
    public class RegionLocationRepository
    {
        private readonly AppDbContext _appDbContext;

        public RegionLocationRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<RegionLocation> GetAllPermissionEntertainment()
        {
            return _appDbContext.RegionLocations;
        }
        
        public RegionLocation GetPermissionEntertainmentByID(int regionLocationID)
        {
            return _appDbContext.RegionLocations.FirstOrDefault(s => s.IdRegionLocation == regionLocationID);
        }
    }
}
