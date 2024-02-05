using Proiect.Models;

namespace Proiect.Repositories.MaterieRepository
{
    public interface IMaterieRepository
    {
        Task<List<Materie>> GetAllAsync();
        Task<Materie> GetByIdAsync(Guid id);
        Task CreateAsync(Materie materie);
        Task UpdateAsync(Materie materie);
        Task DeleteAsync(Guid id);
    }
}
