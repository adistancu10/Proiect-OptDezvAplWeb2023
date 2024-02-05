using Proiect.Models;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.ProfesorRepository
{
    public interface IProfesorRepository : IGenericRepository<Profesor>
    {
        Task<List<Profesor>> GetAllAsync();
        Task<Profesor> GetByIdAsync(Guid id);
        Task CreateAsync(Profesor profesor);
        Task UpdateAsync(Profesor profesor);
        Task DeleteAsync(Guid id);
    }
}
