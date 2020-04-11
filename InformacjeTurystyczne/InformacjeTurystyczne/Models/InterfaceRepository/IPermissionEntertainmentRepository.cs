using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    public interface IPermissionEntertainmentRepository
    {
        IEnumerable<PermissionEntertainment> GetAllPermissionEntertainment();
        PermissionEntertainment GetPermissionEntertainmentByID(int permissionEntertainmentID);

        void AddPermissionEntertainment(PermissionEntertainment permissionEntertainment);
        void EditPermissionEntertainment(PermissionEntertainment permissionEntertainment);
        void DeletePermissionEntertainment(PermissionEntertainment permissionEntertainment);
    }
}
