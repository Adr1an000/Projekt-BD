using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    interface IShelterRepository
    {
        IEnumerable<Shelter> GetAllShelter();
        Shelter GetMessageByID(int shelterID);

        void AddShelter(Shelter shelter);
        void EditShelter(Shelter shelter);
        void DeleteShelter(Shelter shelter);
    }
}
