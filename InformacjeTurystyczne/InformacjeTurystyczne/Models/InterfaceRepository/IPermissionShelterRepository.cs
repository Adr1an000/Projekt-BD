using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    interface IPermissionShelterRepository
    {
        IEnumerable<PermissionShelter> GetAllRegionLocation();
        PermissionShelter GetRegionLocationByID(int permissionShelterID);

        void AddPermissionShelter(PermissionShelter permissionShelter);
        void EditPermissionShelter(PermissionShelter permissionShelter);
        void DeletePermissionShelter(PermissionShelter permissionShelter);
    }
}
