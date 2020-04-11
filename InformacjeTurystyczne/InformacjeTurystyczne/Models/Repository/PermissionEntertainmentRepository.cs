using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InformacjeTurystyczne.Models.InterfaceRepository;

namespace InformacjeTurystyczne.Models.Repository
{
    public class PermissionEntertainmentRepository : IPermissionEntertainmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public PermissionEntertainmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public PermissionEntertainment GetPermissionEntertainmentByID(int permissionEntertainmentID)
        {
            return _appDbContext.PermissionEntertainments.FirstOrDefault(s => s.IdPermissionEntertainment == permissionEntertainmentID);
        }

        public IEnumerable<PermissionEntertainment> GetAllPermissionEntertainment()
        {
            return _appDbContext.PermissionEntertainments;
        }

        public void AddPermissionEntertainment(PermissionEntertainment permissionEntertainment)
        {
            _appDbContext.PermissionEntertainments.Add(permissionEntertainment);
            _appDbContext.SaveChanges();
        }

        public void DeletePermissionEntertainment(PermissionEntertainment permissionEntertainment)
        {
            _appDbContext.PermissionEntertainments.Remove(permissionEntertainment);
            _appDbContext.SaveChanges();
        }

        public void EditPermissionEntertainment(PermissionEntertainment permissionEntertainment)
        {
            _appDbContext.PermissionEntertainments.Update(permissionEntertainment);
            _appDbContext.SaveChanges();
        }
    }
}
