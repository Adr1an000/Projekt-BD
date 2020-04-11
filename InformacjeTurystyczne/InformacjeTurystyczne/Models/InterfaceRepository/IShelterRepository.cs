using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    public interface IShelterRepository
    {
        IEnumerable<Shelter> GetAllShelter();
        Shelter GetShelterByID(int shelterID);

        void AddShelter(Shelter shelter);
        void EditShelter(Shelter shelter);
        void DeleteShelter(Shelter shelter);
    }
}
