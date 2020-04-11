using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InformacjeTurystyczne.Models.InterfaceRepository;

namespace InformacjeTurystyczne.Models.Repository
{
    public class TrialRepository : ITrialRepository
    {
        private readonly AppDbContext _appDbContext;

        public TrialRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Trial> GetAllTrial()
        {
            return _appDbContext.Trials;
        }

        public Trial GetTrialByID(int trialID)
        {
            return _appDbContext.Trials.FirstOrDefault(s => s.IdTrial == trialID);
        }

        public void AddTrial(Trial trial)
        {
            _appDbContext.Trials.Add(trial);
            _appDbContext.SaveChanges();
        }

        public void DeleteTrial(Trial trial)
        {
            _appDbContext.Trials.Remove(trial);
            _appDbContext.SaveChanges();
        }

        public void EditTrial(Trial trial)
        {
            _appDbContext.Trials.Update(trial);
            _appDbContext.SaveChanges();
        }

    }
}
