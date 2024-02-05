using Proiect.Models;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.ProfesorRepository
{
    public interface IProfesorRepository : IGenericRepository<Profesor>
    {
        List<Profesor> OrderByNume(string nume);
        List<dynamic> GetAllWithJoin();
    }
}
