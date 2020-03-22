using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    interface ITrialRepository
    {
        IEnumerable<Trial> GetAllTrial();
        Trial GetMessageByID(int trialID);
    }
}
