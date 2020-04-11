using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    public interface ITrialRepository
    {
        IEnumerable<Trial> GetAllTrial();
        Trial GetTrialByID(int trialID);

        void AddTrial(Trial trial);
        void EditTrial(Trial trial);
        void DeleteTrial(Trial trial);
    }
}
