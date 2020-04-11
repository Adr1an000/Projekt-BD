using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;

namespace InformacjeTurystyczne.Models.Repository
{
    public class PermissionTrialRepository : IPermissionTrialRepository
    {
        private readonly AppDbContext _appDbContext;

        public PermissionTrialRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<PermissionTrial> GetAllPermissionTrial()
        {
            return _appDbContext.PermissionTrials;
        }

        public PermissionTrial GetPermissionTrialByID(int permissionTrialID)
        {
            return _appDbContext.PermissionTrials.FirstOrDefault(s => s.IdPermissionTrial == permissionTrialID);
        }

        public void AddPermissionTrial(PermissionTrial permissionTrial)
        {
            _appDbContext.PermissionTrials.Add(permissionTrial);
            _appDbContext.SaveChanges();
        }

        public void DeletePermissionTrial(PermissionTrial permissionTrial)
        {
            _appDbContext.PermissionTrials.Remove(permissionTrial);
            _appDbContext.SaveChanges();
        }

        public void EditPermissionTrial(PermissionTrial permissionTrial)
        {
            _appDbContext.PermissionTrials.Update(permissionTrial);
            _appDbContext.SaveChanges();
        }

    }
}
