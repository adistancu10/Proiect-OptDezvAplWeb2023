using Proiect.Models;

namespace Proiect.Repositories.ElevRepository
{
    public interface IElevRepository
    {
        Task<List<Elev>> GetAllAsync();
        Task<Elev> GetByIdAsync(Guid id);
        Task CreateAsync(Elev elev);
        Task UpdateAsync(Elev elev);
        Task DeleteAsync(Guid id);
    }
}
