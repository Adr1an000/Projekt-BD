using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    public interface IPermissionRegionRepository
    {
        IEnumerable<PermissionRegion> GetAllPermissionRegion();
        PermissionRegion GetPermissionRegionByID(int permissionRegionID);

        void AddPermissionRegion(PermissionRegion permissionRegion);
        void EditPermissionRegion(PermissionRegion permissionRegion);
        void DeletePermissionRegion(PermissionRegion permissionRegion);
    }
}
