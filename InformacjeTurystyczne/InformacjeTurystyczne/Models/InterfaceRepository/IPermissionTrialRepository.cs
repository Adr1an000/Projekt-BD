using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    interface IPermissionTrialRepository
    {
        IEnumerable<PermissionTrial> GetAllPermissionTrial();
        PermissionTrial GetRegionLocationByID(int permissionTrialID);

        void AddPermissionTrial(PermissionTrial permissionTrial);
        void EditPermissionTrial(PermissionTrial permissionTrial);
        void DeletePermissionTrial(PermissionTrial permissionTrial);
    }
}
