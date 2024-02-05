using Proiect.Data;
using Proiect.Helpers.Extensions;
using Proiect.Models;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(tableContext tableContext) : base(tableContext)
        {
        }

        //public string Password { get; internal set; }


        //public string Password { get; internal set; }

        public List<User> FindAllActive()
        {
            return _table.GetActiveUsers().ToList();
        }
        public User FindByNickname(string nickname)
        {
            return _table.FirstOrDefault(x => x.Nickname.Equals(nickname));
        }

        UserRepository IUserRepository.FindByNickname(string nickname)
        {
            throw new NotImplementedException();
        }
    }
}
