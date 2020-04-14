using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InformacjeTurystyczne.Models.InterfaceRepository;

namespace InformacjeTurystyczne.Models.Repository
{
    public class EntertainmentRepository : IEntertainmentRepository
    {
        public readonly AppDbContext _appDbContext;

        public EntertainmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Entertainment>> GetAllEntertainment()
        {
            return await _appDbContext.Entertainments.Include(c => c.Region).AsNoTracking().ToListAsync();
        }

        public async Task<Entertainment> GetEntertainmentByID(int? entertainmentID)
        {
            return await _appDbContext.Entertainments.Include(c => c.Region).AsNoTracking().FirstOrDefaultAsync(s => s.IdEntertainment == entertainmentID);
        }

        public async Task<Entertainment> GetEntertainmentByIDWithoutInclude(int? entertainmentID)
        {
            return await _appDbContext.Entertainments.AsNoTracking().FirstOrDefaultAsync(c => c.IdEntertainment == entertainmentID);
        }

        public async Task<Entertainment> GetEntertainmentByIDWithoutIncludeAndAsNoTracking(int? entertainmentID)
        {
            return await _appDbContext.Entertainments.FirstOrDefaultAsync(c => c.IdEntertainment == entertainmentID);
        }

        public async Task AddEntertainmentAsync(Entertainment entertainment)
        {
            _appDbContext.Entertainments.Add(entertainment);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteEntertainmentAsync(Entertainment entertainment)
        {
            _appDbContext.Entertainments.Remove(entertainment);
            await _appDbContext.SaveChangesAsync();
        }

        public void EditEntertainment(Entertainment entertainment)
        {
            _appDbContext.Entertainments.Update(entertainment);
            _appDbContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }

        public IEnumerable<Entertainment> GetAllEntertainmentAsNoTracking()
        {
            return _appDbContext.Entertainments.AsNoTracking();
        }

        public IEnumerable<Region> GetAllRegionAsNoTracking()
        {
            return _appDbContext.Regions.AsNoTracking();
        }
    }
}
