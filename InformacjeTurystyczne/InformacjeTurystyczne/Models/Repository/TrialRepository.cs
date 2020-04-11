using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Repository
{
    public class TrialRepository
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
    }
}
