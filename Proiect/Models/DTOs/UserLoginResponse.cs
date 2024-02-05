using Proiect.Repositories.UserRepository;

namespace Proiect.Models.DTOs
{
    public class UserLoginResponse
    {
        private UserRepository user;
        private object token;

        public Guid Id { get; set; }
        public string Nickname { get; set; }
        public string Token { get; set; }

        public UserLoginResponse(User user, string token)
        {
            Id = user.Id;
            Nickname = user.Nickname;
            Token = token;
        }

        public UserLoginResponse(UserRepository user, object token)
        {
            this.user = user;
            this.token = token;
        }
    }
}
