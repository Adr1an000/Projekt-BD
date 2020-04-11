using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InformacjeTurystyczne.Models.InterfaceRepository;

namespace InformacjeTurystyczne.Models.Repository
{
    public class EntertainmentRepository : IEntertainmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public EntertainmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Entertainment> GetAllEntertainment()
        {
            return _appDbContext.Entertainments;
        }

        public Entertainment GetEntertainmentByID(int entertainmentID)
        {
            return _appDbContext.Entertainments.FirstOrDefault(s => s.IdEntertainment == entertainmentID);
        }

        public void AddEntertainment(Entertainment entertainment)
        {
            _appDbContext.Entertainments.Add(entertainment);
            _appDbContext.SaveChanges();
        }

        public void DeleteEntertainment(Entertainment entertainment)
        {
            _appDbContext.Entertainments.Remove(entertainment);
            _appDbContext.SaveChanges();
        }

        public void EditEntertainment(Entertainment entertainment)
        {
            _appDbContext.Entertainments.Update(entertainment);
            _appDbContext.SaveChanges();
        }


    }
}
