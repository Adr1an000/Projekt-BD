using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Repository
{
    public class EntertainmentRepository
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
    }
}
