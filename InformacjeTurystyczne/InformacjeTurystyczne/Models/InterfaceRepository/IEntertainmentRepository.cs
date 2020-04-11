using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    interface IEntertainmentRepository
    {
        IEnumerable<Entertainment> GetAllEntertainment();
        Entertainment GetEntertainmentByID(int entertainmentID);

        void AddEntertainment(Entertainment entertainment);
        void EditEntertainment(Entertainment entertainment);
        void DeleteEntertainment(Entertainment entertainment);
    }
}
