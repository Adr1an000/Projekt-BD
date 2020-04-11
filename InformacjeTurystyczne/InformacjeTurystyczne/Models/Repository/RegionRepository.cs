using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;

namespace InformacjeTurystyczne.Models.Repository
{
    public class RegionRepository : IRegionRepository
    {
        private readonly AppDbContext _appDbContext;

        public RegionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Region> GetAllRegion()
        {
            return _appDbContext.Regions;
        }

        public Region GetMessageByID(int regionID)
        {
            return _appDbContext.Regions.FirstOrDefault(s => s.IdRegion == regionID);
        }

        public void AddRegion(Region region)
        {
            _appDbContext.Regions.Add(region);
            _appDbContext.SaveChanges();
        }

        public void DeleteRegion(Region region)
        {
            _appDbContext.Regions.Remove(region);
            _appDbContext.SaveChanges();
        }

        public void EditRegion(Region region)
        {
            _appDbContext.Regions.Update(region);
            _appDbContext.SaveChanges();
        }

    }
}
