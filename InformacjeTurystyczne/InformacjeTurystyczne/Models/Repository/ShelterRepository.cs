using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;

namespace InformacjeTurystyczne.Models.Repository
{
    public class ShelterRepository : IShelterRepository
    {
        private readonly AppDbContext _appDbContext;

        public ShelterRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Shelter> GetAllShelter()
        {
            return _appDbContext.Shelters;
        }

        public Shelter GetMessageByID(int shelterID)
        {
            return _appDbContext.Shelters.FirstOrDefault(s => s.IdRegion == shelterID);
        }

        public void AddShelter(Shelter shelter)
        {
            _appDbContext.Shelters.Add(shelter);
            _appDbContext.SaveChanges();
        }

        public void DeleteShelter(Shelter shelter)
        {
            _appDbContext.Shelters.Remove(shelter);
            _appDbContext.SaveChanges();
        }

        public void EditShelter(Shelter shelter)
        {
            _appDbContext.Shelters.Update(shelter);
            _appDbContext.SaveChanges();
        }
    }
}
