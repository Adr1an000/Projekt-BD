using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    public interface ITrialRepository
    {
        Task<IEnumerable<Trial>> GetAllTrial();
        Task<Trial> GetTrialByID(int? trialID);
        Task<Trial> GetTrialByIDWithoutInclude(int? trialID);
        Task<Trial> GetTrialByIDWithoutIncludeAndAsNoTracking(int? trialID);

        Task AddTrialAsync(Trial trial);
        void EditTrial(Trial trial);
        Task DeleteTrialAsync(Trial trial);

        Task SaveChangesAsync();
        IEnumerable<Trial> GetAllTrialAsNoTracking();
    }

}
