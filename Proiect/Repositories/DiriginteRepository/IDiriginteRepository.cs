using Proiect.Models;

namespace Proiect.Repositories.DiriginteRepository
{
    public interface IDiriginteRepository
    {
        Task<List<Diriginte>> GetAllAsync();
        Task<Diriginte> GetByIdAsync(Guid id);
        Task CreateAsync(Diriginte diriginte);
        Task UpdateAsync(Diriginte diriginte);
        Task DeleteAsync(Guid id);
    }
}
