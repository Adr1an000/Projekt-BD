using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;

namespace InformacjeTurystyczne.Models.Repository
{
    public class PermissionRegionRepository : IPermissionRegionRepository
    {
        private readonly AppDbContext _appDbContext;

        public PermissionRegionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<PermissionRegion> GetAllPermissionRegion()
        {
            return _appDbContext.PermissionRegions;
        }

        public PermissionRegion GetMessageByID(int permissionRegionID)
        {
            return _appDbContext.PermissionRegions.FirstOrDefault(s => s.IdPermissionRegion == permissionRegionID);
        }

        public void AddPermissionRegion(PermissionRegion permissionRegion)
        {
            _appDbContext.PermissionRegions.Add(permissionRegion);
            _appDbContext.SaveChanges();
        }

        public void DeletePermissionRegion(PermissionRegion permissionRegion)
        {
            _appDbContext.PermissionRegions.Remove(permissionRegion);
            _appDbContext.SaveChanges();
        }

        public void EditPermissionRegion(PermissionRegion permissionRegion)
        {
            _appDbContext.PermissionRegions.Update(permissionRegion);
            _appDbContext.SaveChanges();
        }
    }
}
