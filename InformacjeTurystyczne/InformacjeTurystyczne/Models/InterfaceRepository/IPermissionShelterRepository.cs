using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    public interface IPermissionShelterRepository
    {
        IEnumerable<PermissionShelter> GetAllPermissionShelter();
        PermissionShelter GetPermissionShelterByID(int permissionShelterID);

        void AddPermissionShelter(PermissionShelter permissionShelter);
        void EditPermissionShelter(PermissionShelter permissionShelter);
        void DeletePermissionShelter(PermissionShelter permissionShelter);
    }
}
