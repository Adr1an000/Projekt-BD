using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InformacjeTurystyczne.Models.InterfaceRepository;
using Microsoft.EntityFrameworkCore;

namespace InformacjeTurystyczne.Models.Repository
{
    public class TrialRepository : ITrialRepository
    {
        private readonly AppDbContext _appDbContext;

        public TrialRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Trial>> GetAllTrial()
        {
            return await _appDbContext.Trials.AsNoTracking().ToListAsync();
        }

        public async Task<Trial> GetTrialByID(int? trialID)
        {
            return await _appDbContext.Trials.AsNoTracking().FirstOrDefaultAsync(s => s.IdTrial == trialID);
        }

        public async Task<Trial> GetTrialByIDWithoutInclude(int? trialID)
        {
            return await _appDbContext.Trials.AsNoTracking().FirstOrDefaultAsync(c => c.IdTrial == trialID);
        }

        public async Task<Trial> GetTrialByIDWithoutIncludeAndAsNoTracking(int? trialID)
        {
            return await _appDbContext.Trials.FirstOrDefaultAsync(c => c.IdTrial == trialID);
        }

        public async Task AddTrialAsync(Trial trial)
        {
            _appDbContext.Trials.Add(trial);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteTrialAsync(Trial trial)
        {
            _appDbContext.Trials.Remove(trial);
            await _appDbContext.SaveChangesAsync();
        }

        public void EditTrial(Trial trial)
        {
            _appDbContext.Trials.Update(trial);
            _appDbContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }

        public IEnumerable<Trial> GetAllTrialAsNoTracking()
        {
            return _appDbContext.Trials.AsNoTracking();
        }
    }
}
