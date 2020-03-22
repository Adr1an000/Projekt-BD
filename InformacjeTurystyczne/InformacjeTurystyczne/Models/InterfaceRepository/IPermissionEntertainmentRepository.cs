using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    interface IPermissionEntertainmentRepository
    {
        IEnumerable<PermissionEntertainment> GetAllPermissionEntertainment();
        PermissionEntertainment GetMessageByID(int permissionEntertainmentID);
    }
}
