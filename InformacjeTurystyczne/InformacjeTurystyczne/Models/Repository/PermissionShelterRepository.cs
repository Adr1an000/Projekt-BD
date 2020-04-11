using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;

namespace InformacjeTurystyczne.Models.Repository
{
    public class PermissionShelterRepository : IPermissionShelterRepository
    {
        private readonly AppDbContext _appDbContext;

        public PermissionShelterRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<PermissionShelter> GetAllRegionLocation()
        {
            return _appDbContext.PermissionShelters;
        }

        public PermissionShelter GetRegionLocationByID(int permissionShelterID)
        {
            return _appDbContext.PermissionShelters.FirstOrDefault(s => s.IdPermissionShelter == permissionShelterID);
        }

        public void AddPermissionShelter(PermissionShelter permissionShelter)
        {
            _appDbContext.PermissionShelters.Add(permissionShelter);
            _appDbContext.SaveChanges();
        }

        public void DeletePermissionShelter(PermissionShelter permissionShelter)
        {
            _appDbContext.PermissionShelters.Remove(permissionShelter);
            _appDbContext.SaveChanges();
        }

        public void EditPermissionShelter(PermissionShelter permissionShelter)
        {
            _appDbContext.PermissionShelters.Update(permissionShelter);
            _appDbContext.SaveChanges();
        }

    }
}
