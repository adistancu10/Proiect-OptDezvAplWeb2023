using Proiect.Models;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        UserRepository FindByNickname(string nickname);
        List<User> FindAllActive();
    }
}
