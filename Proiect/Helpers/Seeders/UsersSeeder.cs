using Proiect.Data;
using Proiect.Models;

namespace Proiect.Helpers.Seeders
{
    public class UsersSeeder
    {
        public readonly tableContext _tableContext;

        public UsersSeeder(tableContext tableContext)
        {
            _tableContext = tableContext;
        }
        public void SeedInitialUsers()
        {
            if (!_tableContext.Users.Any())
            {
                var user1 = new User
                {
                    FirstName = "Fistname User1",
                    LastName = "Lastname User1",
                    Email = "user1@email.com",
                    Nickname = "user1"
                };

                var user2 = new User
                {
                    FirstName = "Fistname User2",
                    LastName = "Lastname User2",
                    Email = "user2@email.com",
                    Nickname = "user2"
                };

                _tableContext.Users.Add(user1);
                _tableContext.Users.Add(user2);

                _tableContext.SaveChanges();
            }
        }
    }
}

