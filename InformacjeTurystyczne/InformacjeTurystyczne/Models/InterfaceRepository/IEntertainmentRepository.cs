using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    public interface IEntertainmentRepository
    {
        Task<IEnumerable<Entertainment>> GetAllEntertainment();
        Task<Entertainment> GetEntertainmentByID(int? entertainmentID);
        Task<Entertainment> GetEntertainmentByIDWithoutInclude(int? entertainmentID);
        Task<Entertainment> GetEntertainmentByIDWithoutIncludeAndAsNoTracking(int? entertainmentID);

        Task AddEntertainmentAsync(Entertainment entertainment);
        void EditEntertainment(Entertainment entertainment);
        Task DeleteEntertainmentAsync(Entertainment entertainment);

        Task SaveChangesAsync();
        IEnumerable<Entertainment> GetAllEntertainmentAsNoTracking();
        IEnumerable<Region> GetAllRegionAsNoTracking();
    }
}
