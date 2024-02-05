using Proiect.Models;

namespace Proiect.Repositories.ClasaRepository
{
    public interface IClasaRepository
    {
        Task<List<Clasa>> GetAllAsync();
        Task<Clasa> GetByIdAsync(Guid id);
        Task CreateAsync(Clasa clasa);
        Task UpdateAsync(Clasa clasa);
        Task DeleteAsync(Guid id);
    }
}
