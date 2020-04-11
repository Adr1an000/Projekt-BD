using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    interface IPermissionRegionRepository
    {
        IEnumerable<PermissionRegion> GetAllPermissionRegion();
        PermissionRegion GetMessageByID(int permissionRegionID);

        void AddPermissionRegion(PermissionRegion permissionRegion);
        void EditPermissionRegion(PermissionRegion permissionRegion);
        void DeletePermissionRegion(PermissionRegion permissionRegion);
    }
}
