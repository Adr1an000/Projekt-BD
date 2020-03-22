using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Repository
{
    public class PermissionEntertainmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public PermissionEntertainmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<PermissionEntertainment> GetAllPermissionEntertainment()
        {
            return _appDbContext.PermissionEntertainments;
        }

        public PermissionEntertainment GetPermissionEntertainmentByID(int permissionEntertainmentID)
        {
            return _appDbContext.PermissionEntertainments.FirstOrDefault(s => s.Id == permissionEntertainmentID);
        }
    }
}
